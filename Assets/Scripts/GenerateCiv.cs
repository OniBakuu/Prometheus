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

    public Species species = new Species();
    public Civilization civ = new Civilization();
    public LanguageGen langGen;
    
    //UI Stuff
    public Text display;
    private String limb, spectype, biome;

    private List<string> sybStruct = new List<string>();

    private List<CivTraits> allTraits = new List<CivTraits>()
    {
        CivTraits.ADVENTUROUS, CivTraits.DEVOUT, CivTraits.GREEDY, CivTraits.WARLIKE, CivTraits.CAUTIOUS,
        CivTraits.DELICATE, CivTraits.ENDURING,CivTraits.PASSSIVE, CivTraits.PEACEFUL, CivTraits.INDUSTRIUOS,
        CivTraits.INTELLIGENT
    };

    public void Start()
    {
        sybStruct.Add("CV");
        sybStruct.Add("CVV");
        CreateLife();
        
    }

    public void CreateLife()
    {
        GenerateSpecies();
        GenerateCivilization();
        SetText();
        DisplayInfo();
    }

    private void GenerateSpecies()
    {
        species.InitSpecies();
        langGen.Init_Syllables(species,sybStruct);
    }

    private void GenerateCivilization()
    {
        
        civ.species = species;
        civ.name = langGen.MakeWord();
        
        for (int i = 0; i < 3; i++)
        {
            ChooseCivTraits();
        }
        
    }

    private void ChooseCivTraits()
    {
        int rand = Random.Range(0, allTraits.Count);
        CivTraits temp = allTraits[rand];
        if (civ.traits.Contains(temp))
        {
            ChooseCivTraits();
        }
        
        civ.traits.Add(temp);
        
        //Add checks for incompatible traits e.g. warlike + peaceful
    }

    private void SetText()
    {
        //int rand;
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

    private void DisplayInfo()
    {
        display.text += "The civilization of " + civ.name + ".\n";
        display.text += civ.name + " is a made up of a " + limb + " " + spectype + " species which live in " + biome + " areas.";
        display.text += "\nThe " + civ.name + " are a " + civ.traits[0] + ", "+ civ.traits[1] + ", and " + civ.traits[2] + " civ";

    }
}
