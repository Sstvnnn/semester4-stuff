using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2702295373_PSDQuiz.Models;

namespace _2702295373_PSDQuiz.Singleton
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