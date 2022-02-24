using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using ScrabbleScore.Models;

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
    [TestMethod]
    public void GetArray_ReturnLetters_Char()
    {
      string word = "test";
      char[] array = { 't', 'e', 's', 't' };
      Score newScore = new Score(word);
      char[] result = newScore.GetArray("test");
      Assert.AreEqual(array[0], result[0]);
      Assert.AreEqual(array[1], result[1]);
      Assert.AreEqual(array[2], result[2]);
      Assert.AreEqual(array[3], result[3]);
    }
    [TestMethod]
    public void ScrabbleScoreCounter_ReturnScrabbleWordScore_Int()
    {
      string word = "test";
      Score newScore = new Score(word);
      string result = newScore.Word;
      Assert.AreEqual(4, newScore.ScrabbleScoreCounter("test"));
    }
  }
}