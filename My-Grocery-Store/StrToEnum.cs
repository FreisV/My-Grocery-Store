using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Grocery_Store
{
    public static class StrToEnum
    {
        public static UnitsEnum convert(string unitsOfPrd)
        {
            try
            {
                return (UnitsEnum)Enum.Parse(typeof(UnitsEnum), unitsOfPrd);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return UnitsEnum.piece;
            }
        }
    }
}
