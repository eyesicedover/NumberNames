using System;
using System.Collections.Generic;

namespace NumberNames.Models
{
  public class Naming
  {
      private string _input;
      private List<string> _chunks = new List<string> {};
      private Dictionary<string, string> _digits = new Dictionary<string, string>(){
        {"1", "one"},
        {"2", "two"},
        {"3", "three"},
        {"4", "four"},
        {"5", "five"},
        {"6", "six"},
        {"7", "seven"},
        {"8", "eight"},
        {"9", "nine"},
      };

      private Dictionary<string, string> _teens = new Dictionary<string, string>(){
        {"10", "ten"},
        {"11", "eleven"},
        {"12", "twelve"},
        {"13", "thirteen"},
        {"14", "fourteen"},
        {"15", "fifteen"},
        {"16", "sixteen"},
        {"17", "seventeen"},
        {"18", "eightteen"},
        {"19", "nineteen"},
      };

      private Dictionary<int, string> _suffixes = new Dictionary<int, string>(){
        //by index number in the string list
        {0, "hundred"},
        {1, "thousand"},
        {2, "million"},
        {3, "billion"},
        {4, "trillion"}
      };

      private Dictionary<string, string> _tens = new Dictionary<string, string>(){
        {"2", "twenty"},
        {"3", "thirty"},
        {"4", "forty"},
        {"5", "fifty"},
        {"6", "sixty"},
        {"7", "seventy"},
        {"8", "eighty"},
        {"9", "ninety"}
      };

      public Naming(string userInput)
      {
          _input = userInput;
      }

      public string GetInput()
      {
          return _input;
      }

      public List<string> GetChunks()
      {
          return _chunks;
      }

      public string GetDigits(string key)
      {
        return _digits[key];
      }

      public string GetSuffixes(int key)
      {
        return _suffixes[key];
      }

      public string GetTens(string key)
      {
        return _tens[key];
      }

      public bool CheckTeens(string[] array)
      {
        if (array[1] == "1")
        {
          return true;
        }
        else
        {
          return false;
        }
      }

      public string GetTeens(string[] array)
      {
        if (CheckTeens(array) == true)
        {
          string teen = array[1] + array[2];
          return _teens[teen];
        }
        else
        {
          return "hello";
        }
      }

      public void SetChunks()
      {
          char[] charSplitInput = _input.ToCharArray();
          string[] splitInput = new string[charSplitInput.Length];
          for (int i = 0; i < charSplitInput.Length; i++)
          {
              splitInput[i] = charSplitInput[i].ToString();
          }
          string newString = "";
		      int indexLength = splitInput.Length - 1;
          for (int index = indexLength; index >= 0; index-=1)
          {
              newString += splitInput[index];
              if ((newString.Length == 3) || (splitInput[index] == splitInput[0]))
              {
                char[] reversing = newString.ToCharArray();
                Array.Reverse( reversing );
                string result = new string(reversing);
                _chunks.Add(result);
                newString = "";
              }
          }
      }
  }
}
