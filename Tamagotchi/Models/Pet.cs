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
      return Attention += 10;
    }
    
    public int GetRest()
    {
      Rest = 100;
      return  Rest;
    }
  }
}