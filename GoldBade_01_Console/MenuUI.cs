using GoldBadge_01_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBade_01_Console
{
    class MenuUI
    {
        private MealContentRepo _mealContentRepo = new MealContentRepo();

        public void RunTheUI()
        {
            AddSomeMeals();
            TheMealMenu();
        }

        private void TheMealMenu()
        {
            bool runTheApp = true;
            while (runTheApp)
            {
                Console.WriteLine("Hello what would you like to do today?\n" +
                    "1) See a list of all meals\n" +
                    "2) Create a new meal!\n" +
                    "3) Delete a current meal.\n" +
                    "4) See meal by meal number.\n" +
                    "5) Exit the menu");

                string managerInput = Console.ReadLine();

                switch (managerInput)
                {
                    case "1":
                        SeeFullList();
                        break;
                    case "2":
                        CreateNewMeal();
                        break;
                    case "3":
                        DeleteTheMeal();
                        break;
                    case "4":
                        SeeMealByNumber();
                        break;
                    case "5":
                        Console.WriteLine("See ya later!");
                        runTheApp = false;
                        break;
                    default:
                        Console.WriteLine("**Please enter a correct menu number!**");
                        break;
                }
                Console.WriteLine("Please press any key to move forward.");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void SeeFullList()
        {
            Console.Clear();
            List<MealContent> listOfMeals = _mealContentRepo.GetMenuList();

            foreach(MealContent meal in listOfMeals)
            {
                
                Console.WriteLine($"Meal Number: {meal.MealNumber}\n" +
                    $"Meal Name: {meal.MealName}\n" +
                    $"Description: {meal.MealDescription}\n" +
                    $"Price: {meal.Price}\n");
            }
        }

        private void SeeMealByNumber()
        {
            Console.Clear();
            Console.WriteLine("Which meal number would you like to see?");

            string mealAsString = Console.ReadLine();
            int mealNumber = int.Parse(mealAsString);

            MealContent meal = _mealContentRepo.GetMealByMealNumber(mealNumber);
            
            if(meal != null)
            {
                Console.WriteLine($"Meal Number: {meal.MealNumber}\n" +
                    $"Menu Type: {meal.TypeOfMeal}\n" +
                    $"Meal Name: {meal.MealName}\n" +
                    $"Description: {meal.MealDescription}\n" +
                    $"Price: {meal.Price}");
            }
            else
            {
                Console.WriteLine("No content by that title.");
            }
        }

        private void CreateNewMeal()
        {
            Console.Clear();
            MealContent newMeal = new MealContent();

            Console.WriteLine("Please enter the meal number:");
            string mealAsString = Console.ReadLine();
            newMeal.MealNumber = int.Parse(mealAsString);

            Console.WriteLine("Please enter the meal name:");
            newMeal.MealName = Console.ReadLine();

            Console.WriteLine("Please enter the meals description:");
            newMeal.MealDescription = Console.ReadLine();

            Console.WriteLine("What's the meals price?");
            string priceAsString = Console.ReadLine();
            newMeal.Price = double.Parse(priceAsString);

            Console.WriteLine("Which type of meal are you adding?\n" +
                "1) Breakfast\n" +
                "2) Lunch\n" +   
                "3) Dinner");

            string todAsString = Console.ReadLine();
            int todAsInt = int.Parse(todAsString);
            newMeal.TypeOfMeal = (MealType)todAsInt;

            _mealContentRepo.AddMealToMenuList(newMeal);
        }

        private void DeleteTheMeal()
        {
            SeeFullList();
            Console.WriteLine("Please enter the meal number you'd like to remove:");

            string mealAsString = Console.ReadLine();
            int mealNumber = int.Parse(mealAsString);

            bool weDeletedIt = _mealContentRepo.DeleteMeal(mealNumber);

            if (weDeletedIt)
            {
                Console.WriteLine("\nThe meal has been deleted.\n");
            }
            else
            {
                Console.WriteLine("\nThe meal could not be removed.\n");
            }
        }

        private void AddSomeMeals()
        {
            MealContent bigbkfst = new MealContent(1, "Big Breakfast", "Pancakes, sausage, eggs, biscuits, and OJ.", 8, MealType.Breakfast);
            MealContent lilbkfst = new MealContent(2, "Little Breakfast", "Mini pancakes, turkey bacon, toast, and milk.", 5, MealType.Breakfast);
            MealContent burgerMeal = new MealContent(4, "Cheese Burgers", "Double cheese burger, fries, pie, and Soda.", 11, MealType.Dinner);
            MealContent healthyLunch = new MealContent(3, "Grilled Chicken Salad", "Grilled chicken salad, 1/2 of an avocado sandwich, and green tea.", 9, MealType.Lunch);

            _mealContentRepo.AddMealToMenuList(bigbkfst);
            _mealContentRepo.AddMealToMenuList(lilbkfst);
            _mealContentRepo.AddMealToMenuList(healthyLunch);
            _mealContentRepo.AddMealToMenuList(burgerMeal);
        }
    }
}
