using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class Products
    {
        private string code;
        private string name;
        private string price;
        private DateTime date;
        private string category;

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }
        public Products()
        {

        }
        public Products(string vCode, string vName, string vPrice, DateTime vDate, string vCategory)
        {
            this.Code = vCode;
            this.Name = vName;
            this.Price = vPrice;
            this.Date = vDate;
            this.Category = vCategory;
            string text = "koko";
        }

        public string getConcac()
        {
            return "a";
        }
    }
}
