using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LatihanQuiz1.Models;

namespace LatihanQuiz1.Singleton
{
    public class DatabaseSingleton
    {
        private static Database1Entities instance;

        public static Database1Entities getInstance()
        {
            if (instance == null)
            {
                instance = new Database1Entities();
            }
            return instance;
        }

    }
}