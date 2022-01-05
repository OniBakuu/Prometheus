using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class LanguageGen : MonoBehaviour
{
    //Lists for syllable structures and all possible syllables that can be created with given syllable structures
    public List<String> allSybs = new List<String>();



    // Start is called before the first frame update
    void Start()
    {

    }

    //Makes word based library
    public string MakeWord()
    {
        
        int wordLength = Random.Range(1, 5);
        List<String> syllables = new List<String>();
        String word = "";

        while (syllables.Count <= wordLength)
        {
            int num = Random.Range(0, allSybs.Count);
            syllables.Add(allSybs[num]);
        }
        
        
        for (int i = 0; i < syllables.Count; i++)
        {
            word += syllables[i];
        }
        
        return word;

    }

    //No longer useful words not organized with phoneme list anymore
    public String SyllablesToString(List<Phoneme> sybs)
    {
        String wordString = " ";

        for (int i = 0; i < sybs.Count; i++)
        {
            wordString += sybs[i].sound;
        }


        return wordString;
    }

    public void Init_Syllables(Species species, List<string> structure)
    {
        allSybs.Clear();

        if (structure.Contains("CV"))
        {
            for (int i = 0; i < species.phonemes.Count; i++)
            {
                if (species.phonemes[i].type == Phoneme.letterType.CONSONANT)
                {
                    for (int j = 0; j < species.phonemes.Count; j++)
                    {
                        if (species.phonemes[j].type == Phoneme.letterType.VOWEL)
                        {
                            allSybs.Add(species.phonemes[i].sound+species.phonemes[j].sound);
                        }
                    } 
                }

            }
        }//End of CV

        if (structure.Contains("CVV"))
        {
            for (int i = 0; i < species.phonemes.Count; i++)
            {
                if (species.phonemes[i].type == Phoneme.letterType.CONSONANT)
                {
                    for (int j = 0; j < species.phonemes.Count; j++)
                    {
                        if (species.phonemes[j].type == Phoneme.letterType.VOWEL)
                        {
                            for (int k = 0; k < species.phonemes.Count; k++)
                            {
                                if ((species.phonemes[j].type == Phoneme.letterType.VOWEL))
                                { 
                                    allSybs.Add(species.phonemes[i].sound+species.phonemes[j].sound+species.phonemes[k].sound);
                                }

                            }
                           
                        }
                    } 
                }

            }
        }//End of CVV
        
    }




}
