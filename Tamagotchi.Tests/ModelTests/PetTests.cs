using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;

namespace Tamagotchi.Tests
{
  [TestClass]
  public class PetTests
  {
    [TestMethod]
    public void PetConstructor_CreatesInstanceOfPet_Pet()
    {
      string inputName = "Baldwin";
      Pet petObject = new Pet(inputName);
      Assert.AreEqual(typeof(Pet), petObject.GetType());
      Assert.AreEqual(inputName, petObject.Name);
    }
  }
}

//     [TestMethod]
//     public void ItemConstructor_CreatesInstanceOfItem_Item()
//     {
//       Item newItem = new Item("test");
//       Assert.AreEqual(typeof(Item), newItem.GetType());
//     }