using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests : IDisposable
  {
    private static string _inputName = "Baldwin";
    private Pet _petObject = new Pet(_inputName);

    public void Dispose()
    {
      Pet.ClearAll();
    }
    
    [TestMethod]
    public void PetConstructor_BaldwinPetObject_PetObject()
    {
      Assert.AreEqual(typeof(Pet), _petObject.GetType());
      Assert.AreEqual(_inputName, _petObject.Name);
    }

    [TestMethod]
    public void FeedPet_FeedInstanceOfPet_IncreaseFoodBy10()
    {
    //Arrange
    _petObject.Food = 90;
    //Act
    _petObject.FeedPet();
    //Assert
    Assert.AreEqual(100, _petObject.Food);
    }

    [TestMethod]
    public void FeedPet_FeedInstanceOfPetAtMaxFood_FoodAt100()
    {
      //Arrange
      _petObject.Food = 100;
      //Act
      _petObject.FeedPet();
      //Assert
      Assert.AreEqual(100, _petObject.Food);
    }

    [TestMethod]
    public void GiveAttention_AttentionToPet_IncreaseAttentionBy10()
    {
    _petObject.Attention = 90;
    _petObject.GiveAttention();
    Assert.AreEqual(100, _petObject.Attention);
    }

    [TestMethod]
    public void GiveAttention_GiveAttentionToPetAtMaxCapacity_AttentionAt100()
    {
    _petObject.Attention = 100;
    _petObject.GiveAttention();
    Assert.AreEqual(100, _petObject.Attention);
    }

    [TestMethod]
    public void GiveRest_RestToPet_IncreaseRestTo100()
    {
    _petObject.Rest = 50;
    _petObject.GetRest();
    Assert.AreEqual(100, _petObject.Rest);
    }

    [TestMethod]
    public void IsDead_DeathToPet_DeadPet()
    {
    _petObject.Food = 0;
    _petObject.Attention = 0;
    _petObject.Rest = 0;

    string result = _petObject.IsDead(); 
    Assert.AreEqual("Dead Pet", result);
    }

    [TestMethod]
    public void TimePassed_TimePassed_DecrementPropertiesByTen()
    {
    _petObject.Food = 90;
    _petObject.Attention = 90;
    _petObject.Rest = 90;

      Pet.TimePassed();
      int food = _petObject.Food;
      int attention = _petObject.Attention;
      int rest = _petObject.Rest;

      int[] result = { food, attention, rest };
      int[] compare = { 80, 80, 80 };

      CollectionAssert.AreEqual(compare, result);
    }

    [TestMethod]
    public void GetAllPets_CallMethod_ListOfPetObjects()
    {
      Pet secondPetObject = new Pet("Pascal");
      List<Pet> expectedList = new List<Pet>(){_petObject, secondPetObject};
      List<Pet> resultList = Pet.GetAllPets();
      Console.WriteLine(expectedList.Count);
      Console.WriteLine(resultList.Count);
      CollectionAssert.AreEqual(expectedList, resultList);
    }

  }
}
    // Food, attention and rest
    // 