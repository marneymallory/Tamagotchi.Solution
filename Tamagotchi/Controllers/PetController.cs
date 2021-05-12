using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
  public class PetController : Controller
  {
    private static string _inputName = "Baldwin";
    private Pet _petObject = new Pet(_inputName);

    [HttpGet("/pet")]
    public ActionResult Index()
    {
      List<Pet> listOfPets = Pet.GetAllPets();
      return View(listOfPets);
    }
  }
}