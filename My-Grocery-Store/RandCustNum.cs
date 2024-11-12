using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AddProductPage
{
    public static class RandCustNum
    {
        public static string generate() 
        {
            int randNum = new Random().Next(0,10000);
            string id = randNum.ToString("D4");

            return id;
        }
    }
}
