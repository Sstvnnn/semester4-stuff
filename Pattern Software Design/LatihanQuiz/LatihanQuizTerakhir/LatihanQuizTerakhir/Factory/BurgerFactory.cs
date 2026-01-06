using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LatihanQuizTerakhir.Models;

namespace LatihanQuizTerakhir.Factory
{
    public class BurgerFactory
    {
        // Pake static Burger jg 
        public static Burger CreateBurger(string name, int price)
        {
            Burger newBurger = new Burger();
            newBurger.BurgerName = name;
            newBurger.BurgerPrice = price;
            newBurger.BurgerStatus = "Waiting";
            return newBurger;
        }
    }
}