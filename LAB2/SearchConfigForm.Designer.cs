namespace LAB2
{
    partial class SearchConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelsimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SavesimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.DatecheckBox = new System.Windows.Forms.CheckBox();
            this.CategorycheckBox = new System.Windows.Forms.CheckBox();
            this.PricecheckBox = new System.Windows.Forms.CheckBox();
            this.NamecheckBox = new System.Windows.Forms.CheckBox();
            this.CodecheckBox = new System.Windows.Forms.CheckBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(407, 299);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelsimpleButton);
            this.panel1.Controls.Add(this.SavesimpleButton);
            this.panel1.Controls.Add(this.DatecheckBox);
            this.panel1.Controls.Add(this.CategorycheckBox);
            this.panel1.Controls.Add(this.PricecheckBox);
            this.panel1.Controls.Add(this.NamecheckBox);
            this.panel1.Controls.Add(this.CodecheckBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 275);
            this.panel1.TabIndex = 4;
            // 
            // CancelsimpleButton
            // 
            this.CancelsimpleButton.Location = new System.Drawing.Point(206, 232);
            this.CancelsimpleButton.Name = "CancelsimpleButton";
            this.CancelsimpleButton.Size = new System.Drawing.Size(75, 23);
            this.CancelsimpleButton.TabIndex = 13;
            this.CancelsimpleButton.Text = "Cancel";
            this.CancelsimpleButton.Click += new System.EventHandler(this.CancelsimpleButton_Click);
            // 
            // SavesimpleButton
            // 
            this.SavesimpleButton.Location = new System.Drawing.Point(75, 232);
            this.SavesimpleButton.Name = "SavesimpleButton";
            this.SavesimpleButton.Size = new System.Drawing.Size(75, 23);
            this.SavesimpleButton.TabIndex = 12;
            this.SavesimpleButton.Text = "Save";
            this.SavesimpleButton.Click += new System.EventHandler(this.SavesimpleButton_Click);
            // 
            // DatecheckBox
            // 
            this.DatecheckBox.AutoSize = true;
            this.DatecheckBox.Location = new System.Drawing.Point(156, 159);
            this.DatecheckBox.Name = "DatecheckBox";
            this.DatecheckBox.Size = new System.Drawing.Size(49, 17);
            this.DatecheckBox.TabIndex = 11;
            this.DatecheckBox.Text = "Date";
            this.DatecheckBox.UseVisualStyleBackColor = true;
            // 
            // CategorycheckBox
            // 
            this.CategorycheckBox.AutoSize = true;
            this.CategorycheckBox.Location = new System.Drawing.Point(156, 132);
            this.CategorycheckBox.Name = "CategorycheckBox";
            this.CategorycheckBox.Size = new System.Drawing.Size(71, 17);
            this.CategorycheckBox.TabIndex = 10;
            this.CategorycheckBox.Text = "Category";
            this.CategorycheckBox.UseVisualStyleBackColor = true;
            // 
            // PricecheckBox
            // 
            this.PricecheckBox.AutoSize = true;
            this.PricecheckBox.Location = new System.Drawing.Point(156, 107);
            this.PricecheckBox.Name = "PricecheckBox";
            this.PricecheckBox.Size = new System.Drawing.Size(49, 17);
            this.PricecheckBox.TabIndex = 9;
            this.PricecheckBox.Text = "Price";
            this.PricecheckBox.UseVisualStyleBackColor = true;
            // 
            // NamecheckBox
            // 
            this.NamecheckBox.AutoSize = true;
            this.NamecheckBox.Checked = true;
            this.NamecheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NamecheckBox.Location = new System.Drawing.Point(156, 78);
            this.NamecheckBox.Name = "NamecheckBox";
            this.NamecheckBox.Size = new System.Drawing.Size(53, 17);
            this.NamecheckBox.TabIndex = 8;
            this.NamecheckBox.Text = "Name";
            this.NamecheckBox.UseVisualStyleBackColor = true;
            // 
            // CodecheckBox
            // 
            this.CodecheckBox.AutoSize = true;
            this.CodecheckBox.Location = new System.Drawing.Point(156, 53);
            this.CodecheckBox.Name = "CodecheckBox";
            this.CodecheckBox.Size = new System.Drawing.Size(51, 17);
            this.CodecheckBox.TabIndex = 7;
            this.CodecheckBox.Text = "Code";
            this.CodecheckBox.UseVisualStyleBackColor = true;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(407, 299);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(387, 279);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // SearchConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 299);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SearchConfigForm";
            this.Text = "SearchConfigForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchConfigForm_FormClosed);
            this.Load += new System.EventHandler(this.SearchConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton CancelsimpleButton;
        private DevExpress.XtraEditors.SimpleButton SavesimpleButton;
        private System.Windows.Forms.CheckBox DatecheckBox;
        private System.Windows.Forms.CheckBox CategorycheckBox;
        private System.Windows.Forms.CheckBox PricecheckBox;
        private System.Windows.Forms.CheckBox NamecheckBox;
        private System.Windows.Forms.CheckBox CodecheckBox;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}