using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PhoneticLibrary : MonoBehaviour
{
    public void Start()
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
    
    public List<Phoneme> apeLib = new List<Phoneme>()
    {
        m,g,p,b,i,omega,schwa,a 
    };
    public List<Phoneme> repLib = new List<Phoneme>()
    {
        k,s,sh,theta,h,e,a,i
    };
    public List<Phoneme> insLib = new List<Phoneme>()
    {
        z,s,sh,r,k,e,a,i,schwa
    };
    public List<Phoneme> aviLib = new List<Phoneme>();
    
}
