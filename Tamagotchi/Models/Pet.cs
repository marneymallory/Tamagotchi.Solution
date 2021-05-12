using System.Collections.Generic;

namespace Tamagotchi.Models

{
  public class Pet
  {
    public string Name {get; set;}
    public int Food {get; set;}
    public int Attention {get; set;}
    public int Rest { get; set; }

    private static List<Pet> _petList = new List<Pet> { };

    public Pet(string name)
    {
      Name = name;
      Food = 100;
      Attention = 100;
      Rest = 100;
      _petList.Add(this);
    }

    public int FeedPet() 
    {
      Food += 10;
      if (Food >= 100)
      {
        Food = 100;
      }
      return Food;
    }

    public int GiveAttention()
    {
      Attention += 10;
      if (Attention >= 100)
      {
        Attention = 100;
      }
      return Attention;
    }
    
    public int GetRest()
    {
      Rest = 100;
      return  Rest;
    }
    public string IsDead()  //what properties are IsDead looking at? (Food, Rest, Attention)
    {
      if (Food <= 0 || Rest <= 0 || Attention <= 0)
      {
      return "Dead Pet";
      }
      return "Alive Pet";
    }
    
    public static void TimePassed()
    {
      for (int i=0; i < _petList.Count; i++)
      {
        _petList[i].Food -= 10;
        _petList[i].Attention -= 10;
        _petList[i].Rest -= 10;
      }
    }

    public static List<Pet> GetAllPets()
    {
      return _petList;
    }

    public static void ClearAll()
    {
      _petList.Clear();
    }
  }
}

// public Item(string description)
//     {
//       Description = description;
//       _instances.Add(this);
//       Id = _instances.Count; //We don't add a set method, because this property will be set in the constructor automatically.