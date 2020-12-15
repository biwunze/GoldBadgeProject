using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadge_01_Repository
{
    public class MealContentRepo
    {
        private List<MealContent> _listOfMeals = new List<MealContent>();

        //CRUD
        public void AddMealToMenuList(MealContent meal)
        {
            _listOfMeals.Add(meal);
        }

        public List<MealContent> GetMenuList()
        {
            return _listOfMeals;
        }

        /*Update **EXTRA**
        public bool UpdateMealsOnMenu(int firstMealNumber, MealContent newMealContent)
        {
            //Find Meal
            MealContent firstMealForm = GetMealByMealNumber(firstMealNumber);

            //Update Meal
            if (firstMealForm != null)
            {
                //Assign new properties
                firstMealForm.MealNumber = newMealContent.MealNumber;
                firstMealForm.MealName = newMealContent.MealName;
                firstMealForm.MealDescription = newMealContent.MealDescription;
                firstMealForm.Price = newMealContent.Price;
                firstMealForm.TypeOfMeal = newMealContent.TypeOfMeal;

                return true;
            }
            else
            {
                return false;
            }

        }*/

        public bool DeleteMeal(int mealNumber)
        {
            MealContent meal = GetMealByMealNumber(mealNumber);

            if(meal == null)
            {
                return false;
            }

            int originalNumberOfMeals = _listOfMeals.Count;
            _listOfMeals.Remove(meal);

            if (originalNumberOfMeals > _listOfMeals.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Get by #
        public MealContent GetMealByMealNumber(int mealNumber)
        {
            foreach(MealContent meal in _listOfMeals)
            {
                if(meal.MealNumber == mealNumber)
                {
                    return meal;
                }
            }

            return null;
        }
    }
}
