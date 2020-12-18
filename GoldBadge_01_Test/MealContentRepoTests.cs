using GoldBadge_01_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GoldBadge_01_Test
{
    [TestClass]
    public class MealContentRepoTests
    {

        [TestMethod]
        public void AddToMenu_ShouldGetNotNull()
        {
            // Arrange = Setting up the playing field
            MealContentRepo repo = new MealContentRepo();
            MealContent meal = new MealContent(5, "Turkey Breakfast", "Toast, turkey sausage, egg whites, wheat toast, and Milk.", 9, MealType.Breakfast);

            // Act = Get/run the code we want to test
            repo.AddMealToMenuList(meal);

            // Assert = Use the assert class to verify the expected outcome
            List<MealContent> listOfMeals = repo.GetMenuList();

            bool menuNumEqual = false;

            foreach(MealContent food in listOfMeals)
            {
                if(food.MealNumber == meal.MealNumber)
                {
                    menuNumEqual = true;
                    break;
                }
            }
            Assert.IsTrue(menuNumEqual);
        }

        [TestMethod]
        public void GetMenuList_NotBeNull()
        {
            // Arrange
            MealContentRepo mealTestRepo = new MealContentRepo();
            MealContent mealTestCont = new MealContent();

            // Act
            List<MealContent> listFromTestRepo = mealTestRepo.GetMenuList();

            // Assert
            Assert.IsNotNull(listFromTestRepo);
        }

        [TestMethod]
        public void DeleteMeal_True()
        {
            // Arrange
            MealContentRepo repo = new MealContentRepo();
            MealContent meal = new MealContent(5, "Turkey Breakfast", "Toast, turkey sausage, egg whites, wheat toast, and Milk.", 9, MealType.Breakfast);
            // Act
            bool deleteThisTest = repo.DeleteMeal(meal.MealNumber);

            // Assert
            Assert.IsTrue(deleteThisTest);
        }

        [TestMethod]
        public void TestForGetMealByNum()
        {
            //Arrange
            MealContentRepo repo = new MealContentRepo();
            MealContent meal = new MealContent(5, "Turkey Breakfast", "Toast, turkey sausage, egg whites, wheat toast, and Milk.", 9, MealType.Breakfast);

            repo.AddMealToMenuList(meal);

            //Act
            MealContent mealByNum = repo.GetMealByMealNumber(meal.MealNumber);

            //Assert
            Assert.AreEqual(meal, mealByNum);
        }

        [TestMethod]
        public void TestForGetMealByNum2()
        {
            MealContentRepo mealTestRepo = new MealContentRepo();           //Extra test
            MealContent mealTestCont = new MealContent();
            mealTestRepo.AddMealToMenuList(mealTestCont);

            //Act
            MealContent mealByNum = mealTestRepo.GetMealByMealNumber(mealTestCont.MealNumber);

            bool menuNumsAreEqual = mealTestCont.MealName == mealByNum.MealName;

            Assert.IsTrue(menuNumsAreEqual);
        }
    }
}
