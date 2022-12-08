using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word.");
      string userInput = Console.ReadLine();
      Scrabble userWord = new Scrabble(userInput);
      int wordScore = userWord.GetLetterScore();
      Console.WriteLine("Your word's score is " + wordScore + "!");
    }
  }
}