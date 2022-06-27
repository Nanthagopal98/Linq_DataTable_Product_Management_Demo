using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_DataTable_Demo
{
    public class Product_DataTable
    {
        public void AddData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Product Name");
            table.Rows.Add("1", "Engine");
            table.Rows.Add("2", "Transmission");
            table.Rows.Add("3", "Breaking System");
            table.Rows.Add("4", "Steering System");
            GetData(table);
        }
        public void GetData(DataTable table)
        {

            var id = from productid in table.AsEnumerable() select productid.Field<string>("ID");
            var data = from productname in table.AsEnumerable() select productname.Field<string>("Product Name");
            Console.WriteLine("Product ID & Products Are");
            foreach(var idValues in id)
            {
                Console.Write(idValues+"\n");               
            }
            foreach (var dataValues in data)
            {
                Console.Write(dataValues+"\n");
            }
        }       
    }
}
