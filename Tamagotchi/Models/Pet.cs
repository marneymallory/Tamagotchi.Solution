namespace Tamagotchi.Models
{
  public class Pet
  {
    public string Name {get; set;}
    public int Food {get; set;}

    public Pet(string name)
    {
      Name = name;
      Food = 100;
    }

    public int FeedPet()
    {
      return Food += 10;
    }
  }
}