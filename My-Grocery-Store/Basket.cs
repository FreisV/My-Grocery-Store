using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace My_Grocery_Store
{
    internal class Basket
    {
        private int _sum = 0;
        public Basket() { }

        public int Sum {
            get { return _sum; }
            set
            {
                if (value >= 0)
                {
                    _sum = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
            }
        }

        public int 



    }
}
