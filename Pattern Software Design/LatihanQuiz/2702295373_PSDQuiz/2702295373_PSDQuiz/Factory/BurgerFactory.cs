using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2702295373_PSDQuiz.Models;

namespace _2702295373_PSDQuiz.Factory
{
    public class BurgerFactory
    {
        public static Burger createBurger(string name, int price)
        {
            Burger newBurger = new Burger();
            newBurger.BurgerName = name;
            newBurger.BurgerPrice = price;
            newBurger.BurgerStatus = "Waiting";
            return newBurger;
        }

    }
}