using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Scrabble
  {
    public string UserInput { get; }
    public char[] UserCharArray { get; }

    private Dictionary<char,int> _letterScores = new Dictionary<char, int>() {
      { 'A', 1 }, { 'E', 1 }, { 'I', 1 }, { 'O', 1 }, { 'U', 1 }, { 'L', 1 }, { 'N', 1 }, { 'R', 1 }, { 'S', 1 }, { 'T', 1 },
      { 'D', 2 }, { 'G', 2 },
      { 'B', 3 }, { 'C', 3 }, { 'M', 3 }, { 'P', 3 },
      { 'F', 4 }, { 'H', 4 }, { 'V', 4 }, { 'W', 4 }, { 'Y', 4 },
      { 'K', 5 },
      { 'J', 8 }, { 'X', 8 },
      { 'Q', 10 }, { 'Z', 10 },      
    };

    public Scrabble(string userInput)
    {
      UserInput = userInput.ToUpper();
      UserCharArray = ToCharacterArray(UserInput);
    }

    public char[] ToCharacterArray(string userInput)
    {
      char[] userCharArray = userInput.ToCharArray();
      return userCharArray;
    }

    public int GetLetterScore(char letter) {
      return _letterScores[letter];
    }

  }
}