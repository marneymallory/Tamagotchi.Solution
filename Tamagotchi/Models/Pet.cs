namespace Tamagotchi.Models
{
  public class Pet
  {
    public string Name {get; set;}
    public int Food {get; set;}
    public int Attention {get; set;}
    public int Rest { get; set; }

    public Pet(string name)
    {
      Name = name;
      Food = 100;
      Attention = 100;
      Rest = 100;
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
  }
}