using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2702295373_PSDQuiz.Factory;
using _2702295373_PSDQuiz.Models;
using _2702295373_PSDQuiz.Singleton;

namespace _2702295373_PSDQuiz.Repositories
{
    public class BurgerRepositories
    {
        protected static BurgerKingEntities db = DatabaseSingleton.getInstance();
        public static void InsertBurger(string name, int price)
        {
            Burger newBurger = BurgerFactory.createBurger(name, price);
            db.Burgers.Add(newBurger);
            db.SaveChanges();   
        }

        public static List<Burger> GetAllBurgers()
        {
            return db.Burgers.ToList();
        }

        public static Burger GetBurger(int id)
        {
            return db.Burgers.Find(id);
        }

        public static void DeleteBurger(int id)
        {
            Burger deletedBurger = GetBurger(id);
            db.Burgers.Remove(deletedBurger);
            db.SaveChanges();
        }

        public static Boolean UpdateBurger(int id)
        {
            Burger updatedBurger = GetBurger(id); 
            
            if(updatedBurger != null)
            {
                switch (updatedBurger.BurgerStatus)
                {
                    case "Waiting":
                        updatedBurger.BurgerStatus = "Cooking";
                        break;
                    case "Cooking":
                        updatedBurger.BurgerStatus = "Ready";
                        break;
                    case "Ready":
                        updatedBurger.BurgerStatus = "Served";
                        break;
                    case "Served":
                        DeleteBurger(id);
                        return true;
                }
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}