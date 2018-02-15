using System;
using System.Collections.Generic;

namespace NumberNames.Models
{
  public class Naming
  {
      private string _input;
      // private List<List<int>> _chunks = new List<List<int>> {};
      private List<string> _chunks = new List<string> {};

      public Naming(string userInput)
      {
          _input = userInput;
      }

      public string GetInput()
      {
          return _input;
      }

      // public List<List<int>> GetChunks()
      // {
      //     Console.WriteLine(_chunks);
      //     return _chunks;
      // }
      //
      // public void SetChunks()
      // {
      //     char[] charSplitInput = _input.ToCharArray();
      //     int[] splitInput = new int[charSplitInput.Length];
      //     for (int i = 0; i < charSplitInput.Length; i++)
      //     {
      //         splitInput[i] = int.Parse(charSplitInput[i].ToString());
      //     }
      //     List<int> newList = new List<int> {};
      //     List<List<int>> newPlaceholder = new List<List<int>> {};
		  //     int indexLength = splitInput.Length - 1;
      //     for (int index = indexLength; index >= 0; index-=1)
      //     {
      //         newList.Add(splitInput[index]);
      //         if ((newList.Count == 3) || (splitInput[index] == splitInput[0]))
      //         {
      //           newList.Reverse();
      //           newPlaceholder.Add(newList);
      //           newList.Clear();
      //         }
      //     }
      //     _chunks = newPlaceholder;
      // }

      public List<string> GetChunks()
      {
          return _chunks;
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
