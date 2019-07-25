using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class categories : Template2
    {

        int edit = 0; //This 0 is an indication to SAVE operator and 1 is an UPDATE operation
        int catID;
        short stat;
        public categories()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(LeftPanel);
            
        }

        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
            categoryNameTxt.Focus();
            edit = 0;
        }

        public override void BtnEdit_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(LeftPanel);
        }

        public override void BtnSave_Click(object sender, EventArgs e)
        {
            //validation for Users form
            if (categoryNameTxt.Text == string.Empty) { catNameErrorLabel.Visible = true; } else { catNameErrorLabel.Visible = false; }
            if (isActiveCB.SelectedIndex == -1) { IsActiveErrorLabel.Visible = true; } else { IsActiveErrorLabel.Visible = false; }

            if (catNameErrorLabel.Visible || IsActiveErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message
            }
            else
            {

                if (isActiveCB.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (isActiveCB.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) // Code for SAVE Operation
                {

                    Insertion i = new Insertion();
                    i.insertCat(categoryNameTxt.Text, stat);
                    r.showCategories(CatDataGridView, catIDGV, NameGV, StatusGV);
                    MainClass.disable_reset(LeftPanel);
                }
                else if (edit == 1) // Code for EDIT Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, You want to Update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (isActiveCB.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (isActiveCB.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        u.updatetCat(catID, categoryNameTxt.Text, stat);
                        r.showCategories(CatDataGridView, catIDGV, NameGV, StatusGV);
                        MainClass.disable_reset(LeftPanel);
                    }
                }
            }
        }

        public override void BtnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, You want to Delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategories(CatDataGridView, catIDGV, NameGV, StatusGV);
                }
            }
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != string.Empty)
            {
                r.showCategories(CatDataGridView, catIDGV, NameGV, StatusGV, searchTxt.Text);
            }
            else
            {
                r.showCategories(CatDataGridView, catIDGV, NameGV, StatusGV);
            }
        }

        public override void btnViewAll_Click(object sender, EventArgs e)
        {
            r.showCategories(CatDataGridView, catIDGV, NameGV, StatusGV);
        }

        private void CatDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = CatDataGridView.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                categoryNameTxt.Text = row.Cells["NameGV"].Value.ToString();
                isActiveCB.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
