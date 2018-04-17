using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace LAB2
{
    public partial class SearchConfigForm : DevExpress.XtraEditors.XtraForm
    {
        public SearchConfigForm()
        {
            InitializeComponent();
        }
        public delegate void SetText(string text);
        public SetText setText;
        string ACTION_CHECKBOX = null;
        private void SavesimpleButton_Click(object sender, EventArgs e)
        {
            if (CodecheckBox.Checked)
            {
                ACTION_CHECKBOX += CodecheckBox.Text + " ";
            }
            if (NamecheckBox.Checked)
            {
                ACTION_CHECKBOX += NamecheckBox.Text + " ";
            }
            if (PricecheckBox.Checked)
            {
                ACTION_CHECKBOX += PricecheckBox.Text + " ";
            }
            if (DatecheckBox.Checked)
            {
                ACTION_CHECKBOX += DatecheckBox.Text + " ";
            }
            if (CategorycheckBox.Checked)
            {
                ACTION_CHECKBOX += CategorycheckBox.Text + " ";
            }
            setText(ACTION_CHECKBOX);
            this.Close();
        }

        private void SearchConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Properties.Settings.Default.CodeCheckBox = CodecheckBox.Checked;
            Properties.Settings.Default.NameCheckBox = NamecheckBox.Checked;
            Properties.Settings.Default.PriceCheckBox = PricecheckBox.Checked;
            Properties.Settings.Default.DateCheckBox = DatecheckBox.Checked;
            Properties.Settings.Default.CategoryCheckBox = CategorycheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void SearchConfigForm_Load(object sender, EventArgs e)
        {
            CodecheckBox.Checked = Properties.Settings.Default.CodeCheckBox;
            NamecheckBox.Checked = Properties.Settings.Default.NameCheckBox;
            PricecheckBox.Checked = Properties.Settings.Default.PriceCheckBox;
            DatecheckBox.Checked = Properties.Settings.Default.DateCheckBox;
            CategorycheckBox.Checked = Properties.Settings.Default.CategoryCheckBox;
        }

        private void CancelsimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}