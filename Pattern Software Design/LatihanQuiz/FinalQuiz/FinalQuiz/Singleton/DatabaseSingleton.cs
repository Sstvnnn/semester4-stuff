using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalQuiz.Models;

namespace FinalQuiz.Singleton
{
    public class DatabaseSingleton
    {
        private static BurgerKingEntities instance;

        public static BurgerKingEntities getInstance()
        {
            if (instance == null)
            {
                instance = new BurgerKingEntities();    
            }
            return instance;
        }

    }
}