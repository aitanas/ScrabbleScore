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
    public void ScrabbleConstructor_CreatesInstancesOfWord_Item()
    {
      Scrabble userWord = new Scrabble();
      Assert.AreEqual(typeof(Scrabble), userWord.GetType());
    }
    
  }
}