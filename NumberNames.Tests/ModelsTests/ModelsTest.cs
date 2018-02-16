using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using NumberNames.Models;

namespace NumberNames.Models.Tests
{
  [TestClass]
  public class ProjectTest
  {
    [TestMethod]
    public void SetInput_GetInput_True()
    {
        //Arrange
        Naming newNaming = new Naming ("1234567");
        string compare = "1234567";

        //Act
        string input = newNaming.GetInput();

        //Assert
        Assert.AreEqual(input, compare);
    }

    [TestMethod]
    public void SetChunks_GetChunks_True()
    {
      //Arrange
      Naming newNaming = new Naming ("1234567");
      string first = "567";
      string second = "234";
      string third = "1";
      List<string> compareList = new List<string> {first, second, third};
      List<string> aList = new List<string> {};

      //Act
      newNaming.SetChunks();
      aList = newNaming.GetChunks();

      //Assert

      CollectionAssert.AreEqual(aList, compareList);
    }

    [TestMethod]
    public void TranslateChunks_SpellHundreds_True()
    {
      Naming newNaming = new Naming ("1234567");
      List<string> aList = new List<string> {};
      newNaming.SetChunks();
      aList = newNaming.GetChunks();
      string firstChunk = aList[0];
      char[] firstArray = firstChunk.ToCharArray();
      string hundreds = firstArray[0].ToString();
      if (newNaming.GetDigits(hundreds) != null)
      {
        hundreds = newNaming.GetDigits(hundreds);
      }
      Assert.AreEqual("five hundred", (hundreds + " hundred"));
    }

    [TestMethod]
    public void TranslateChunks_SpellTens_True()
    {
      Naming newNaming = new Naming ("1234567");
      List<string> aList = new List<string> {};
      newNaming.SetChunks();
      aList = newNaming.GetChunks();
      string firstChunk = aList[0];
      char[] firstArray = firstChunk.ToCharArray();
      string tens = firstArray[1].ToString();
      if (newNaming.GetTens(tens) != null)
      {
        tens = newNaming.GetTens(tens);
      }
      Assert.AreEqual("sixty", tens);
    }

    [TestMethod]
    public void TranslateChunks_SpellOnes_True()
    {
      Naming newNaming = new Naming ("1234567");
      List<string> aList = new List<string> {};
      newNaming.SetChunks();
      aList = newNaming.GetChunks();
      string firstChunk = aList[0];
      char[] firstArray = firstChunk.ToCharArray();
      string ones = firstArray[2].ToString();
      if (newNaming.GetDigits(ones) != null)
      {
        ones = newNaming.GetDigits(ones);
      }
      Assert.AreEqual("seven", ones);
    }

    [TestMethod]
    public void CheckIfTeens_True()
    {
      Naming newNaming = new Naming ("188888812");
      List<string> aList = new List<string> {};
      newNaming.SetChunks();
      aList = newNaming.GetChunks();
      string firstChunk = aList[0];
      char[] firstArray = firstChunk.ToCharArray();
      Console.WriteLine(firstArray[0]);
      Console.WriteLine(firstArray[1]);
      Console.WriteLine(firstArray[2]);
      string[] stringArray = new string[firstArray.Length];
      string teens = "";
      for (int i = 0; i < firstArray.Length; i++)
      {
        stringArray[i] = firstArray[i].ToString();
      }
      teens = newNaming.GetTeens(stringArray);

      Assert.AreEqual("thirteen", teens);
    }


  }

}
