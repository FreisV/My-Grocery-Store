using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace My_Grocery_Store
{
    public static class FileOperations
    {
        public static void write(string data)
        {
            FileStream filedata = new FileStream("dataBase.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(filedata);

            writer.WriteLine(data);

            writer.Close();
            filedata.Close();
        }
        public static Product[] getProds()
        {
            FileStream filedata = new FileStream("dataBase.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(filedata);

            string rawProduct = reader.ReadLine();
            Product[] allPrds = new Product[15];
            int i = 0;

            while (rawProduct != null)
            {
                allPrds[i]=toProduct(rawProduct);
                i++;
                if(i == allPrds.Length-1)
                {
                    Product[] newArray = new Product[allPrds.Length * 2];
                    Array.Copy(allPrds, newArray, allPrds.Length);
                    allPrds = newArray;
                }
                rawProduct = reader.ReadLine();
            }

            reader.Close();
            filedata.Close();

            return allPrds;
        }
        public static Product toProduct(string line)
        {
            int index = line.IndexOf("@");
            string name = line.Substring(0, index);  

            int indexNext = line.IndexOf("@", index + 1);
            string id = line.Substring(index + 1, indexNext - index - 1);  

            index = line.IndexOf("@", indexNext + 1);
            string price = line.Substring(indexNext + 1, index - indexNext - 1); 

            string rawUnits = line.Substring(index + 1);

            UnitsEnum units = StrToEnum.convert(rawUnits);

            return new Product(name,id,price,units);
        }
    }
}
