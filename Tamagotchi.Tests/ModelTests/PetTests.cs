using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests
  {
    private static string _inputName = "Baldwin";
    private Pet _petObject = new Pet(_inputName);

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
    public void GiveAttention_AttentionToPet_IncreaseAttentionBy10()
    {
    _petObject.Attention = 90;
    _petObject.GiveAttention();
    Assert.AreEqual(100, _petObject.Attention);
    }

  }
}
    // Food, attention and rest
    // 