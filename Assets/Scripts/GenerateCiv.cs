using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

public class GenerateCiv : MonoBehaviour
{

    
    public LanguageGen langGen;
    
    //UI Stuff
    public Text display;
    private String limb, spectype, biome;

    private List<string> sybStruct = new List<string>();

    private List<CivTraits> allTraits = new List<CivTraits>()
    {
        CivTraits.Adventurous, CivTraits.Devout, CivTraits.Greedy, CivTraits.Warlike, CivTraits.Cautious,
        CivTraits.Delicate, CivTraits.Enduring,CivTraits.Passive, CivTraits.Peaceful, CivTraits.Industrious,
        CivTraits.Industrious, CivTraits.Aggressive, CivTraits.Intelligent
    };

    public void Start()
    {
        sybStruct.Add("CV");
        sybStruct.Add("CVV");
        PhoneticLibrary.Library.InitLibs();
        
    }

    public void CreateLife()
    {
        Species species = new Species();
        Civilization civ = new Civilization();
        GenerateSpecies(species);
        GenerateCivilization(species, civ);
        SetText(species);
        SetCivDesc(civ);
        DisplayInfo(civ);
    }

    private void GenerateSpecies(Species species)
    {
        species.InitSpecies();
        langGen.Init_Syllables(species,sybStruct);
    }

    private void GenerateCivilization(Species species, Civilization civ)
    {
        
        civ.species = species;
        Debug.Log(species.speciesTrait);
        civ.name = langGen.MakeWord();
        
        for (int i = 0; i < 3; i++)
        {
            ChooseCivTraits(civ);
        }
        
    }

    private void ChooseCivTraits(Civilization civ)
    {
        int rand = Random.Range(0, allTraits.Count);
        CivTraits temp = allTraits[rand];
        if (civ.traits.Contains(temp))
        {
            ChooseCivTraits(civ);
        }
        
        civ.traits.Add(temp);
        
        //Add checks for incompatible traits e.g. warlike + peaceful
    }

    private void SetText(Species species)
    {
        limb = species.limbs switch
        {
            Limbs.BIPEDAL => "biped",
            Limbs.QUADRUPEDAL => "quadruped",
            _ => limb
        };

        biome = species.biome switch
        {
            BiomeTraits.ARID => "arid",
            BiomeTraits.OCEAN => "oceanic",
            BiomeTraits.FOREST => "forested",
            BiomeTraits.JUNGLE => "jungle",
            BiomeTraits.PLAINS => "plains",
            BiomeTraits.TUNDRA => "tundra",
            _ => biome
        };

        spectype = species.speciesTrait switch
        {
            SpeciesTraits.APE => "Ape-like",
            SpeciesTraits.INSECT => "Insect-like",
            SpeciesTraits.REPTILE => "Reptile-like",
            SpeciesTraits.AVIAN => "Avian-like",
            _ => spectype
        };
        
        

    }

    private void SetCivDesc(Civilization civ)
    {
        civ.desc = "The civilization of " + civ.name + ".\n" + civ.name + " is a made up of a " + limb + " " + spectype + " species which live in " + biome + " areas."
        + "\nThe " + civ.name + " are a " + civ.traits[0] + ", "+ civ.traits[1] + ", and " + civ.traits[2] + " people";
    }
    private void DisplayInfo(Civilization civ)
    {
        //have list of civs and just loop to set display.text to all civs in list
        display.text = civ.desc;
    }
}
