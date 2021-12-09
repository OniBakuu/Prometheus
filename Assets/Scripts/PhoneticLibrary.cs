using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneticLibrary : MonoBehaviour
{
    [SerializeField]
    public List<Phoneme> apeLib;
    [SerializeField]
    public List<Phoneme> repLib;
    [SerializeField]
    public List<Phoneme> insLib;
    
    private Phoneme m = new Phoneme("m", Phoneme.letterType.CONSONANT);
    private Phoneme g = new Phoneme("g", Phoneme.letterType.CONSONANT);
    private Phoneme p = new Phoneme("p", Phoneme.letterType.CONSONANT);
    private Phoneme b = new Phoneme("n", Phoneme.letterType.CONSONANT);
    private Phoneme i = new Phoneme("i", Phoneme.letterType.VOWEL);
    private Phoneme a = new Phoneme("a", Phoneme.letterType.VOWEL);
    private Phoneme e = new Phoneme("e", Phoneme.letterType.VOWEL);
    private Phoneme k = new Phoneme("k", Phoneme.letterType.CONSONANT);
    private Phoneme s = new Phoneme("s", Phoneme.letterType.CONSONANT);
    private Phoneme sh = new Phoneme("sh", Phoneme.letterType.CONSONANT);
    private Phoneme h = new Phoneme("h", Phoneme.letterType.CONSONANT);
    private Phoneme z = new Phoneme("z", Phoneme.letterType.CONSONANT);
    private Phoneme r = new Phoneme("r", Phoneme.letterType.CONSONANT);
    private Phoneme theta = new Phoneme("th", Phoneme.letterType.CONSONANT);
    private Phoneme omega = new Phoneme("oo", Phoneme.letterType.VOWEL);
    private Phoneme schwa = new Phoneme("u", Phoneme.letterType.VOWEL);



    private void Start()
    {
        InitLibs();
    }

    private void InitLibs()
    {
        //Ape like library
        apeLib.Add(m);
        apeLib.Add(g);
        apeLib.Add(p);
        apeLib.Add(b);
        apeLib.Add(i);
        apeLib.Add(omega);
        apeLib.Add(schwa);
        apeLib.Add(a);
        
        //Reptile library
        repLib.Add(k);
        repLib.Add(s);
        repLib.Add(sh);
        repLib.Add(theta);
        repLib.Add(h);
        repLib.Add(e);
        repLib.Add(a);
        repLib.Add(i);
        
        //Insect like library
        insLib.Add(z);
        insLib.Add(s);
        insLib.Add(sh);
        insLib.Add(r);
        insLib.Add(k);
        insLib.Add(e);
        insLib.Add(a);
        insLib.Add(i);
        insLib.Add(schwa);
        
    }
}
