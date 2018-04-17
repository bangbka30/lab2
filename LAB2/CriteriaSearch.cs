using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    public class CriteriaSearch
    {
        private int id;
        private string criteria;

        public string Criteria
        {
            get
            {
                return criteria;
            }

            set
            {
                criteria = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
        public CriteriaSearch()
        {

        }
        public CriteriaSearch(int vid, string vcriteria)
        {
            this.Id = vid;
            this.Criteria = vcriteria;
        }
        public static List<CriteriaSearch> listCriteria;
        public static List<CriteriaSearch> CreateListCriteria()
        {
            listCriteria = new List<CriteriaSearch>();
            CriteriaSearch criteria1 = new CriteriaSearch(0, "Code");
            listCriteria.Add(criteria1);
            CriteriaSearch criteria2 = new CriteriaSearch(1, "Name");
            listCriteria.Add(criteria2);
            CriteriaSearch criteria3 = new CriteriaSearch(2, "Price");
            listCriteria.Add(criteria3);
            CriteriaSearch criteria4 = new CriteriaSearch(3, "Date");
            listCriteria.Add(criteria4);
            CriteriaSearch criteria5 = new CriteriaSearch(4, "Category");
            listCriteria.Add(criteria5);

            return listCriteria;
        }
    }
}
