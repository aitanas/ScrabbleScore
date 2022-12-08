using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string UserInput { get; }
    public string[] UserCharArray { get; }
    public Scrabble(string userInput)
    {
      UserInput = userInput;
      UserCharArray = ToCharacterArray();
    }
    
    public string[] ToCharacterArray()
    {
      // string[] UserCharArray = userCharArray;
      return new string[] {"w","o","r","d"};
    }
  }
}