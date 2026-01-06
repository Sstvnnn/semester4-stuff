using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalQuiz.Factory;
using FinalQuiz.Models;
using FinalQuiz.Singleton;

namespace FinalQuiz.Repositories
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

        public static List<Burger> getAllBurger()
        {
            return db.Burgers.ToList();
        }

        public static Burger getBurger(int id)
        {
            return db.Burgers.Find(id);
        }

        public static void deleteBurger(int id)
        {
            Burger deletedBurger = getBurger(id);
            db.Burgers.Remove(deletedBurger);
            db.SaveChanges();
        }

        public static Boolean updateBurger(int id)
        {
             Burger updatedBurger = getBurger(id);

            if(updatedBurger != null)
            {
                switch(updatedBurger.BurgerStatus)
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
                        deleteBurger(id);
                        return true;
                }
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}