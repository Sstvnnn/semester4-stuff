using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LatihanQuiz1.Models;

namespace LatihanQuiz1.Factory
{
    public class RamenFactory
    {
        public static MsRaman create(string ramenName, int ramenPrice, int ramenTypeID)
        {
            MsRaman ramen = new MsRaman();
            ramen.RamenName = ramenName;
            ramen.RamenPrice = ramenPrice;
            ramen.RamenTypeID = ramenTypeID;
            return ramen;
        }

    }
}