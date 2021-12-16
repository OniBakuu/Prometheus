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
    private String limb, spectype, biome, trait1, trait2, trait3; 

    private List<CivTraits> allTraits = new List<CivTraits>()
    {
        CivTraits.ADVENTUROUS, CivTraits.DEVOUT, CivTraits.GREEDY, CivTraits.WARLIKE, CivTraits.CAUTIOUS,
        CivTraits.DELICATE, CivTraits.ENDURING,CivTraits.PASSSIVE, CivTraits.PEACEFUL, CivTraits.INDUSTRIUOS,
        CivTraits.INTELLIGENT
    };

    public void Start()
    {
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
    }

    private void GenerateCivilization()
    {
        langGen.Init_Syllables(species);
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

        trait1 = civ.traits[0].ToString();
        trait2 = civ.traits[1].ToString();
        trait3 = civ.traits[2].ToString();
        

    }

    private void DisplayInfo()
    {
        display.text += "The civilization of " + civ.name;
        display.text += "\n" + trait1;

    }
}
