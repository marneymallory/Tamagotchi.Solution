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
      return Food += 10;
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