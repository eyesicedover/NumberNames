using System;

namespace NumberNames.Models
{
  public class Chunks
  {
      private string _input;
      private List<List<int>> _chunks;

      public Chunks(string userInput)
      {
          _input = userInput;
      }

      public List<List<int>> GetChunks()
      {
          return _chunks;
      }
  }
}
