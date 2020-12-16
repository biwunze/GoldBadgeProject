using GoldBadge_01_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace GoldBadge_01_Test
{
    [TestClass]
    public class MealContentRepoTests
    {
        private MealContentRepo _repo;
        private MealContent _mealCont;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MealContentRepo();
            _mealCont = new MealContent(5, "Turkey Breakfast", "Toast, turkey sausage, egg whites, wheat toast, and Milk.", 9, MealType.Breakfast);

            _repo.AddMealToMenuList(_mealCont);
        }

        //Add Method
        [TestMethod]
        public void AddToMenu_ShouldGetNotNull()
        {
            // Arrange = Setting up the playing field
            MealContent meal = new MealContent();
            meal.MealNumber = 7;
            MealContentRepo repo = new MealContentRepo();

            // Act = Get/run the code we want to test
            repo.AddMealToMenuList(meal);
            MealContent mealFromMenu = repo.GetMealByMealNumber(7);

            // Assert = Use the assert class to verify the expected outcome
            Assert.IsNotNull(mealFromMenu);
        }

        [TestMethod]
        public void GetMenuList_NotBeNull()
        {
            // Arrange
            MealContentRepo mealTestRepo = new MealContentRepo();
            //MealContent mealTestCont = new MealContent();

            // Act
            List<MealContent> listFromTestRepo = mealTestRepo.GetMenuList();

            // Assert
            Assert.IsNotNull(listFromTestRepo);

            //_repo.GetMenuList(_mealCont);
            //_repo.GetMenuList(_mealCont);
            //_repo.GetMenuList();
            //MealContentRepo getList = _repo.GetMenuList();
            //return 


        }

        [TestMethod]
        public void DeleteMeal_True()
        {
            // Arrange

            // Act
            bool deleteThisTest = _repo.DeleteMeal(_mealCont.MealNumber);

            // Assert
            Assert.IsTrue(deleteThisTest);
        }

        [TestMethod]
        public void TestForGetMealByNum()
        {
            //Arrange
            MealContentRepo mealTestRepo = new MealContentRepo();
            MealContent mealTestCont = new MealContent();
            mealTestRepo.AddMealToMenuList(mealTestCont);

            //Act
            MealContent mealByNum = mealTestRepo.GetMealByMealNumber(mealTestCont.MealNumber);

            //Assert
            Assert.AreEqual(mealTestCont, mealByNum);
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
