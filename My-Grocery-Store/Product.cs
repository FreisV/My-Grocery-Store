using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Grocery_Store
{
    
    public enum UnitsEnum
    {
        kg,
        liter,
        piece
    }
    public class Product
    {
        private string _name;
        private string _id;
        private string _price;
        private UnitsEnum _units;
 
        public Product(string name, string id, string price,UnitsEnum units)
        {
            _name = name;
            _id = id;
            _price = price;
            _units = units;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name= value;
            }
        }
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
            }
        }
        public UnitsEnum Units
        {
            get { return _units; }
            set
            {
                _units = value;
            }
        }
    
        public string getAll()
        {
            return _name+"@"+_id+"@"+_price+"@"+_units.ToString();
        }
    }
}
