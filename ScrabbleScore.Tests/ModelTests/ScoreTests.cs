using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
// using System;
using ScrabbleScore.Models;

// Create new instance of word via constructor  X
// return word as string
// Convert the word to lowercase
// Split the string into an array
// Create counter variable
// If/Else statement adds value to counter depending on letter
// Return counter value

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void ScoreConstructor_CreateInstanceOfScore_Score()
    {
      Score newScore = new Score("test");
      Assert.AreEqual(typeof(Score), newScore.GetType());
    }
    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string word = "test";
      Score newScore = new Score(word);
      string result = newScore.Word;
      Assert.AreEqual(word, result);
    }
    [TestMethod]
    public void ConvertToLowerCase_ReturnLowerCaseWord_String()
    {
      string word = "TEST";
      Score newScore = new Score(word);
      string result = newScore.Word;
      Assert.AreEqual("test", newScore.ConvertToLowerCase("TEST"));
    }
  }
}