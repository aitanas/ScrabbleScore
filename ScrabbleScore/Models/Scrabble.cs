using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string UserInput { get; }
    public char[] UserCharArray { get; }
    public Scrabble(string userInput)
    {
      UserInput = userInput;
      UserCharArray = ToCharacterArray(userInput);
    }
    
    public char[] ToCharacterArray(string userInput)
    {
      char[] userCharArray = userInput.ToCharArray();
      return userCharArray;
    }
  }
}