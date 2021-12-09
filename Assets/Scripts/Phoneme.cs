using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phoneme
{
   public enum letterType
   {
      VOWEL,
      CONSONANT
   }
   private String sound;
   private letterType type;

   public Phoneme(String sound, letterType type)
   {
      this.sound = sound;
      this.type = type;
   }
}
