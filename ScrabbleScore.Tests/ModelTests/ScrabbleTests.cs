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
      string userInput = "word";
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
      string[] userCharArray = {"w", "o", "r", "d"};
      //Assert
      CollectionAssert.AreEqual(userCharArray, userWord.UserCharArray);
    }
  }
}