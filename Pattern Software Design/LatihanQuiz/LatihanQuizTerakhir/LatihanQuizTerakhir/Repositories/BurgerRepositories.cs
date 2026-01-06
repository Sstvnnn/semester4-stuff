using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LatihanQuizTerakhir.Factory;
using LatihanQuizTerakhir.Models;
using LatihanQuizTerakhir.Singleton;

namespace LatihanQuizTerakhir.Repositories
{
    public class BurgerRepositories
    {
        // Di Repo ada 5 Method semua pake public static baru db kita juga disini
        // Insert, GetAll, GetOne, Update, Delete

        protected static BurgerKingEntities db = DatabaseSingleton.getInstance();

        public static void InsertBurger(string burgerName, int burgerPrice)
        {
            // factory cuma dipake pas bikin object burger baru
            Burger newBurger = BurgerFactory.CreateBurger(burgerName, burgerPrice); 
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

        public static Boolean UpdateStatus(int id)
        {
            Burger updatedBurger = getBurger(id);
            if(updatedBurger!= null)
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
                        deleteBurger(id);
                        return true;
                }
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}