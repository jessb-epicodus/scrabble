using System.Collections.Generic;
using System;

namespace ScrabbleScore.Models
{
  public class Score
  {
    public string Word { get; }
    // public int Score;

    public Score(string word)
    {
      Word = word;
    }

    public string ConvertToLowerCase(string word) 
    {
      return word.ToLower();
    }

    public char[] GetArray(string word)
    {
      return word.ToCharArray();
    }

    public int ScrabbleScoreCounter(string word) {
      return 0;
    }
  }
}