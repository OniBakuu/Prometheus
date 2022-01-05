using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhoneticLibrary : MonoBehaviour
{
    public void Awake()
    {
        Library = this;
    }

    public static PhoneticLibrary Library = new PhoneticLibrary();
    
    private static Phoneme m = new Phoneme("m", Phoneme.letterType.CONSONANT);
    private static Phoneme g = new Phoneme("g", Phoneme.letterType.CONSONANT);
    private static Phoneme p = new Phoneme("p", Phoneme.letterType.CONSONANT);
    private static Phoneme b = new Phoneme("n", Phoneme.letterType.CONSONANT);
    private static Phoneme i = new Phoneme("i", Phoneme.letterType.VOWEL);
    private static Phoneme a = new Phoneme("a", Phoneme.letterType.VOWEL);
    private static Phoneme e = new Phoneme("e", Phoneme.letterType.VOWEL);
    private static Phoneme k = new Phoneme("k", Phoneme.letterType.CONSONANT);
    private static Phoneme s = new Phoneme("s", Phoneme.letterType.CONSONANT);
    private static Phoneme sh = new Phoneme("sh", Phoneme.letterType.CONSONANT);
    private static Phoneme h = new Phoneme("h", Phoneme.letterType.CONSONANT);
    private static Phoneme z = new Phoneme("z", Phoneme.letterType.CONSONANT);
    private static Phoneme r = new Phoneme("r", Phoneme.letterType.CONSONANT);
    private static Phoneme theta = new Phoneme("th", Phoneme.letterType.CONSONANT);
    private static Phoneme omega = new Phoneme("oo", Phoneme.letterType.VOWEL);
    private static Phoneme schwa = new Phoneme("u", Phoneme.letterType.VOWEL);
    private static Phoneme w = new Phoneme("w", Phoneme.letterType.CONSONANT);
    private static Phoneme t = new Phoneme("t", Phoneme.letterType.CONSONANT);
    
    

    public List<Phoneme> apeLib = new List<Phoneme>();
    public List<Phoneme> repLib = new List<Phoneme>();
    public List<Phoneme> insLib = new List<Phoneme>();
    public List<Phoneme> aviLib = new List<Phoneme>();

    public void InitLibs()
    {
        apeLib.Add(m);
        apeLib.Add(g);
        apeLib.Add(p);
        apeLib.Add(b);
        apeLib.Add(i);
        apeLib.Add(omega);
        apeLib.Add(schwa);
        apeLib.Add(a);
        
        repLib.Add(k);
        repLib.Add(s);
        repLib.Add(sh);
        repLib.Add(theta);
        repLib.Add(h);
        repLib.Add(e);
        repLib.Add(a);
        repLib.Add(i);
        
        insLib.Add(z);
        insLib.Add(s);
        insLib.Add(sh);
        insLib.Add(r);
        insLib.Add(k);
        insLib.Add(e);
        insLib.Add(a);
        insLib.Add(i);
        insLib.Add(schwa);
        
        aviLib.Add(w);
        aviLib.Add(t);
        aviLib.Add(r);
        aviLib.Add(k);
        aviLib.Add(a);
        aviLib.Add(i);
        aviLib.Add(omega);
    }
    
}
