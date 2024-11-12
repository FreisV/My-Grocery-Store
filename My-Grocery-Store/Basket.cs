using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace My_Grocery_Store
{
    internal class Basket
    {
        private string[] _products;
        private int _sum;

        public Basket()
        {
            _products = new string[0];
            _sum = 0;
        }


        public string[] Products { get { return _products; } }

        public int Sum
        {
            get { return _sum; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Sum can not be negative");
                }
                _sum = value;
            }
        }

        public void AddProduct(string product, int quantity)
        {
            string[] newProducts = new string[_products.Length + 1];

            Array.Copy(_products, newProducts, _products.Length);

            newProducts[^1] = $"{product} x{quantity}";

            _products = newProducts;
        }

        public void Clear()
        {
            _products = new string[0];
            _sum = 0;
        }   

    }
}
