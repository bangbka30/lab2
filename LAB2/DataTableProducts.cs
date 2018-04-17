using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LAB2
{
    public class DataTableProducts
    {
        static DataTable dataTableProducts;
        public static void AddColumns()
        {
            dataTableProducts = new DataTable();
            dataTableProducts.Columns.Add("Code", typeof(string));
            dataTableProducts.Columns.Add("Name", typeof(string));
            dataTableProducts.Columns.Add("Price", typeof(string));
            dataTableProducts.Columns.Add("Date", typeof(string));
            dataTableProducts.Columns.Add("Category", typeof(string));
        }
        public static DataTable AddRows()
        {
            AddColumns();
            DataRow dataRow1;
            dataRow1 = dataTableProducts.NewRow();
            dataRow1["Code"] = "SEM42015";
            dataRow1["Name"] = "Experia M4 Aqua";
            dataRow1["Price"] = "6,490,000";
            dataRow1["Date"] = "01/06/2015";
            dataRow1["Category"] = "Sony";
            dataTableProducts.Rows.Add(dataRow1);

            DataRow dataRow7;
            dataRow7 = dataTableProducts.NewRow();
            dataRow7["Code"] = "SSM42015";
            dataRow7["Name"] = "Experia M4 Aqua";
            dataRow7["Price"] = "7,490,000";
            dataRow7["Date"] = "02/06/2015";
            dataRow7["Category"] = "Sony";
            dataTableProducts.Rows.Add(dataRow7);

            DataRow dataRow2;
            dataRow2 = dataTableProducts.NewRow();
            dataRow2["Code"] = "SGS62015";
            dataRow2["Name"] = "SamSung Galaxy S6";
            dataRow2["Price"] = "16,590,000";
            dataRow2["Date"] = "01/06/2015";
            dataRow2["Category"] = "SamSung";
            dataTableProducts.Rows.Add(dataRow2);

            DataRow dataRow3;
            dataRow3 = dataTableProducts.NewRow();
            dataRow3["Code"] = "IP6P64";
            dataRow3["Name"] = "IPhone 6 Plus 64GB";
            dataRow3["Price"] = "22,190,000";
            dataRow3["Date"] = "15/04/2015";
            dataRow3["Category"] = "Mobile";
            dataTableProducts.Rows.Add(dataRow3);

            DataRow dataRow4;
            dataRow4 = dataTableProducts.NewRow();
            dataRow4["Code"] = "IP6P16";
            dataRow4["Name"] = "IPhone 6 Plus 16GB";
            dataRow4["Price"] = "19,590,000";
            dataRow4["Date"] = "15/04/2015";
            dataRow4["Category"] = "Mobile";
            dataTableProducts.Rows.Add(dataRow4);

            DataRow dataRow5;
            dataRow5 = dataTableProducts.NewRow();
            dataRow5["Code"] = "32LB552A";
            dataRow5["Name"] = "LED LG 32inch HD";
            dataRow5["Price"] = "4,590,000";
            dataRow5["Date"] = "15/06/2015";
            dataRow5["Category"] = "TV";
            dataTableProducts.Rows.Add(dataRow5);

            DataRow dataRow6;
            dataRow6 = dataTableProducts.NewRow();
            dataRow6["Code"] = "KDL48R550C";
            dataRow6["Name"] = "LED Sony 48inch HD";
            dataRow6["Price"] = "14,699,000";
            dataRow6["Date"] = "01/06/2015";
            dataRow6["Category"] = "TV";
            dataTableProducts.Rows.Add(dataRow6);

            return dataTableProducts;
        }
    }
}
