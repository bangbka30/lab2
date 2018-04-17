using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LAB2
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<CriteriaSearch> listCriteria;
        DataTable dataTableProducts;
        string CRITERIA_SEARCH = SEARCH_BY_NAME;
        const string SEARCH_BY_CODE = "Code";
        const string SEARCH_BY_NAME = "Name";
        const string SEARCH_BY_PRICE = "Price";
        const string SEARCH_BY_DATE = "Date";
        const string SEARCH_BY_CATEGORY = "Category";
        private void GetText(string text)
        {
            CRITERIA_SEARCH = text.Trim();
        }
        private void DumpDataTableToListView(DataTable datatable)
        {
            ProductslistView.Items.Clear();
            foreach (DataRow dataRow in datatable.Rows)
            {
                ListViewItem itemListView = new ListViewItem(dataRow["Code"].ToString());
                itemListView.SubItems.Add(dataRow["Name"].ToString());
                itemListView.SubItems.Add(dataRow["Price"].ToString());
                itemListView.SubItems.Add(dataRow["Date"].ToString());
                itemListView.SubItems.Add(dataRow["Category"].ToString());
                ProductslistView.Items.Add(itemListView);
            }
        }
        private void DisplayListView()
        {
            dataTableProducts = new DataTable();
            dataTableProducts = DataTableProducts.AddRows();
            DumpDataTableToListView(dataTableProducts);
        }
        private void StartForm()
        {
            Application.Run(new SplashScreenStartForm());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(StartForm));
            thread.Start();
            Thread.Sleep(3000);
            thread.Abort();
            DisplayListView();
        }
        private int[] GetIdCriteria(string[] stringArray)
        {
            listCriteria = new List<CriteriaSearch>();
            listCriteria = CriteriaSearch.CreateListCriteria();
            int[] criteiraID = new int[stringArray.Length];
            foreach (CriteriaSearch criteriaSearch in listCriteria)
            {
                for (int i = 0; i < stringArray.Length; i++)
                {
                    if (stringArray[i] == criteriaSearch.Criteria)
                    {
                        criteiraID[i] = criteriaSearch.Id;
                    }
                }
            }
            return criteiraID;
        }
        private void SearchProductByCriteria(string[] stringArray)
        {
            int[] intArray = GetIdCriteria(stringArray);
            bool find = false;
            ProductslistView.Items.Clear();
            foreach (DataRow row in dataTableProducts.Rows)
            {
                for (int i = 0; i < intArray.Length; i++)
                {
                    if (row[intArray[i]].ToString().Equals(SearchtextEdit.Text))
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        item.SubItems.Add(row[1].ToString());
                        item.SubItems.Add(row[2].ToString());
                        item.SubItems.Add(row[3].ToString());
                        item.SubItems.Add(row[4].ToString());
                        ProductslistView.Items.Add(item);
                        find = true;
                    }
                }
            }
            if (find == false)
            {
                MessageBox.Show("Không Tìm Thấy");
                DisplayListView();
            }
        }
        private void Searching()
        {
            Application.Run(new ProgressBar());
        }
        //button search
        private void SearchsimpleButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Searching));
            thread.Start();
            Thread.Sleep(300);
            thread.Abort();
            string[] stringArray = CRITERIA_SEARCH.Split(' ');
            SearchProductByCriteria(stringArray);
        }
        private bool CheckExistForm(string nameForm)
        {
            bool check = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == nameForm)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string nameForm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == nameForm)
                {
                    form.Activate();
                    break;
                }
            }
        }
        // button search setting
        private void SearchSettingsimpleButton_Click(object sender, EventArgs e)
        {
            if (CheckExistForm("SearchConfigForm") == false)
            {
                SearchConfigForm form = new SearchConfigForm();
                form.setText = new SearchConfigForm.SetText(GetText);
                form.Show();
            }
            else
            {
                ActiveChildForm("SearchConfigForm");
            }
        }
    }
}
