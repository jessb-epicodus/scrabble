using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

class Program
{
  public static void Main()
  {
    Console.WriteLine("Hello! Please enter your Scrabble word!");
    string currentWord = Console.ReadLine();

    Score currentScore = new Score(currentWord);
    
    // string arrayWord = currentScore.GetArray(currentWord)
    Console.WriteLine("Word score: " + currentScore.ScrabbleScoreCounter(currentWord));
  }
}