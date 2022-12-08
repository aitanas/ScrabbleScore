using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void ScrabbleConstructor_CreatesInstancesOfWord_Object()
    {
      Scrabble userWord = new Scrabble("word");
      Assert.AreEqual(typeof(Scrabble), userWord.GetType());
    }

    [TestMethod]
    public void ScrabbleConstructor_ReturnsUserInput_String()
    {
      string userInput = "WORD";
      Scrabble userWord = new Scrabble(userInput);
      Assert.AreEqual(userInput, userWord.UserInput);
    }
    
    [TestMethod]
    public void ToCharacterArray_ConvertWordToArray_ArrayObj()
    {
      // Arrange
      string userInput = "word";
      Scrabble userWord = new Scrabble(userInput);
      // Act
      char[] userCharArray = {'W', 'O', 'R', 'D'};
      //Assert
      CollectionAssert.AreEqual(userCharArray, userWord.UserCharArray);
    }

    [TestMethod]
    public void GetLetterScore_AssignScoresBasedOnLetters_Int ()
    {
      string userInput = "word";
      Scrabble userWord = new Scrabble(userInput);
      Assert.AreEqual(4, userWord.GetLetterScore(userWord.UserCharArray[0]));
    }
  }
}