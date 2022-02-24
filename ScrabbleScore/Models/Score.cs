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
      char[] array = word.ToCharArray();
      return array;
    }

    public int ScrabbleScoreCounter(string word) {
      string lowerCaseWord = ConvertToLowerCase(word);
      char[] wordArray = GetArray(lowerCaseWord);
      int counter = 0;
      for (int i = 0; i < wordArray.Length; i++) {
        if (wordArray[i] == 'a' || 
        wordArray[i] == 'e' || 
        wordArray[i] == 'i' || 
        wordArray[i] == 'o' || 
        wordArray[i] == 'u' || 
        wordArray[i] == 'l' || 
        wordArray[i] == 'n' ||
        wordArray[i] == 'r' ||
        wordArray[i] == 's' ||
        wordArray[i] == 't'){
        counter = counter + 1;          
        }
        else if (wordArray[i] == 'd' || wordArray[i] == 'g' ) {
          counter = counter + 2;
        }
        else if (wordArray[i] == 'b' || wordArray[i] == 'c' || wordArray[i] == 'm' || wordArray[i] == 'p') {
          counter = counter + 3;
        }
        else if (wordArray[i] == 'f' || wordArray[i] == 'h' || wordArray[i] == 'v' || wordArray[i] == 'w' || wordArray[i] == 'y' ) {
          counter = counter + 4;
        }
        else if (wordArray[i] == 'k' ) {
          counter = counter + 5;
        }
        else if (wordArray[i] == 'j' || wordArray[i] == 'x' ) {
          counter = counter + 8;
        }
        else if (wordArray[i] == 'q' || wordArray[i] == 'z' ) {
          counter = counter + 10;
        }
        else {
          counter = counter + 0;
        }
      }
      return counter;
    }
  }
}