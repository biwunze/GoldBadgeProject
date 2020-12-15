using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_01_Repository
{
    public enum MealType
    {
        Breakfast = 1,
        Lunch,
        Dinner
    }
    public class MealContent
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }         // Make a list of strings.  Ingredients, etc.
        public double Price { get; set; }
        public MealType TypeOfMeal { get; set; }

        public MealContent() { }

        public MealContent(int mealNumber, string mealName, string mealDescription, double price, MealType mealTOD)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            Price = price;
            TypeOfMeal = mealTOD;
        }
    }
}
