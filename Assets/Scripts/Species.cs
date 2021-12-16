using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Species
{
    public SpeciesTraits speciesTrait;
    public BiomeTraits biome;
    public Limbs limbs;
    public List<Phoneme> phonemes = new List<Phoneme>();

    public void InitSpecies()
    {
        int rand;
        rand = Random.Range(0, 4);

        switch (rand)
        {
            case 1:
                speciesTrait = SpeciesTraits.APE;
                break;
            case 2:
                speciesTrait = SpeciesTraits.AVIAN;
                break;
            case 3:
                speciesTrait = SpeciesTraits.INSECT;
                break;
            case 4:
                speciesTrait = SpeciesTraits.REPTILE;
                break;
        }

        rand = Random.Range(0, 2);
        switch (rand)
        {
            case 1:
                limbs = Limbs.BIPEDAL;
                break;
            case 2:
                limbs = Limbs.QUADRUPEDAL;
                break;
        }
        
        switch (speciesTrait)
        {
            case SpeciesTraits.APE:
                phonemes = PhoneticLibrary.Library.apeLib;
                break;
            case SpeciesTraits.AVIAN:
                phonemes = PhoneticLibrary.Library.aviLib;
                break;
            case SpeciesTraits.INSECT:
                phonemes = PhoneticLibrary.Library.insLib;
                break;
            case SpeciesTraits.REPTILE:
                phonemes = PhoneticLibrary.Library.repLib;
                break;
        }

        rand = Random.Range(0, 6);
        switch (rand)
        {
            case 1:
                biome = BiomeTraits.ARID;
                break;
            case 2:
                biome = BiomeTraits.OCEAN;
                break;
            case 3:
                biome = BiomeTraits.FOREST;
                break;
            case 4:
                biome = BiomeTraits.JUNGLE;
                break;
            case 5:
                biome = BiomeTraits.PLAINS;
                break;
            case 6:
                biome = BiomeTraits.TUNDRA;
                break;
        }

    }
    
}
