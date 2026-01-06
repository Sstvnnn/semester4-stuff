using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LatihanQuiz1.Models;
using LatihanQuiz1.Singleton;

namespace LatihanQuiz1.Repository
{
    public class RamenTypeRepositories
    {
        protected static Database1Entities db = DatabaseSingleton.getInstance();

        public static List<MsRamenType> getAllTypes()
        {
            return db.MsRamenTypes.ToList();
        }

    }
}