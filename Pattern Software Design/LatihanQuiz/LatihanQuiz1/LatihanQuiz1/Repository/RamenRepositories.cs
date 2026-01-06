using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LatihanQuiz1.Factory;
using LatihanQuiz1.Models;
using LatihanQuiz1.Singleton;

namespace LatihanQuiz1.Repository
{
    public class RamenRepositories
    {

        //Ambil DB
        protected static Database1Entities db = DatabaseSingleton.getInstance();

        // CRUD DB DISINI
        public static void insertRamen(string ramenName, int ramenPrice, int ramenTypeID)
        {
            MsRaman insertedRamen = RamenFactory.create(ramenName, ramenPrice, ramenTypeID);
            db.MsRamen.Add(insertedRamen);
            db.SaveChanges();
        }

        // Get All
        public static List<MsRaman> getAllRamen()
        {
            return db.MsRamen.ToList();
        }

        // Get Ramen Single Object
        public static MsRaman getRamen(int ramenID)
        {
            return db.MsRamen.Find(ramenID);
        } 

        // Update Ramen
        public static void updateRamen (int ramenId, string ramenName, int ramenPrice, int ramenTypeID)
        {
            MsRaman updatedRamen = getRamen(ramenId);
            updatedRamen.RamenName = ramenName;
            updatedRamen.RamenPrice = ramenPrice;
            updatedRamen.RamenTypeID = ramenTypeID;
            db.SaveChanges();
        }

        // Delete Ramen
        public static void deleteRamen(int ramenId)
        {
            MsRaman deletedRamen = getRamen(ramenId);
            db.MsRamen.Remove(deletedRamen);
            db.SaveChanges();
        }
    }
}