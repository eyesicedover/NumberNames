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
      string first = "567";
      string second = "234";
      string third = "1";
      List<string> compareList = new List<string> {first, second, third};
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
  }

}
