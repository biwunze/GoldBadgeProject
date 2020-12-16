using GoldBadge_01_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GoldBadge_01_Test
{
    [TestClass]
    public class MealContentTests
    {
        [TestMethod]
        public void SetMealNumber_ShouldSetCorrectNum()
        {
            MealContent content = new MealContent();                    //Testing propery

            content.MealName = "Large Fiesta Salad Combo";

            string expected = "Large Fiesta Salad Combo";
            string actual = content.MealName;

            Assert.AreEqual(expected, actual);
        }
    }
}
