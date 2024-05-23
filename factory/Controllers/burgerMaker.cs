using Microsoft.AspNetCore.Mvc;
using factory.Models;
namespace factory.Controllers
{
    public class burgerMaker : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CreateBurger()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBurger(string selectedBurger)
        {
            if (!string.IsNullOrEmpty(selectedBurger))
            {
                IBurgerFactory burgerFactory;

                switch (selectedBurger)
                {
                    case "Cheeseburger":
                        burgerFactory = new cheeseBurger();
                        break;
                    case "Burger":
                        burgerFactory = new regularBurger();
                        break;
                    case "FishBurger":
                        burgerFactory = new fishBurger();
                        break;

                    case "RoastedChicken":
                        burgerFactory = new chickenBurger();
                        break;
                    default:
                        return NotFound(); 
                }

                string selectedBurgerIngredients = $"Bun: {burgerFactory.Bun}, Condiments: {burgerFactory.Condiments}, Patty: {burgerFactory.Patty}";

                ViewBag.SelectedBurgerIngredients = selectedBurgerIngredients;
                ViewBag.SelectedBurger = selectedBurger;
            }

            return View();
        }






    }




}
