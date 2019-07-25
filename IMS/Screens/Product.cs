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
    public partial class Product : Template2
    {

        int edit = 0; //This 0 is an indication to SAVE operator and 1 is an UPDATE operation
        int proID;
        public Product()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void Product_Load(object sender, EventArgs e)
        {
            MainClass.disable(LeftPanel);
            r.getList("st_getCategoriesDataList", CatDD, "Category", "ID");
            
        }

        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
            proNameTxt.Focus();
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
            if (proNameTxt.Text == string.Empty) { proNameErrorLabel.Visible = true; } else { proNameErrorLabel.Visible = false; }
            if (barCodeTxt.Text == string.Empty) { BarcodeErrorLabel.Visible = true; } else { BarcodeErrorLabel.Visible = false; }
            if (ExpiryPicker.Value < DateTime.Now ) { ExpiryErrorLabel.Visible = true; ExpiryErrorLabel.Text = "Invalid Date";} else { ExpiryErrorLabel.Visible = false; }
            if (ExpiryPicker.Value.Date == DateTime.Now.Date) { ExpiryErrorLabel.Visible = false; }
            if (PriceTxt.Text == string.Empty) { PriceErrorLabel.Visible = true;} else { PriceErrorLabel.Visible = false; }
            if (CatDD.SelectedIndex == -1 || CatDD.SelectedIndex == 0) { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }
            if (proNameErrorLabel.Visible || BarcodeErrorLabel.Visible || ExpiryErrorLabel.Visible || PriceErrorLabel.Visible || catErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message
            }
            else
            {
                if (edit == 0) // Code for SAVE Operation
                {

                    Insertion i = new Insertion();
                    if(ExpiryPicker.Value.Date == DateTime.Now.Date)
                    {
                        i.insertProduct(proNameTxt.Text, barCodeTxt.Text, Convert.ToSingle(PriceTxt.Text), Convert.ToInt32(CatDD.SelectedValue));
                    }
                    else
                    {
                        i.insertProduct(proNameTxt.Text, barCodeTxt.Text, Convert.ToSingle(PriceTxt.Text), Convert.ToInt32(CatDD.SelectedValue), ExpiryPicker.Value);
                    }
                    r.showProducts(dataGridView1, proIDGV, proNameGV, barcodeGV, expiryGV, priceGV, catGV, catIDGV);
                    MainClass.disable_reset(LeftPanel);
                }
                else if (edit == 1) // Code for EDIT Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, You want to Update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (ExpiryPicker.Value.Date == DateTime.Now.Date)
                        {
                            u.updateProduct(proID, proNameTxt.Text, barCodeTxt.Text, Convert.ToSingle(PriceTxt.Text), Convert.ToInt32(CatDD.SelectedValue));
                        }
                        else
                        {
                            u.updateProduct(proID, proNameTxt.Text, barCodeTxt.Text, Convert.ToSingle(PriceTxt.Text), Convert.ToInt32(CatDD.SelectedValue), ExpiryPicker.Value);
                        }
                        r.showProducts(dataGridView1, proIDGV, proNameGV, barcodeGV, expiryGV, priceGV, catGV, catIDGV);
                        MainClass.disable_reset(LeftPanel);
                    }
                }
            }
            MainClass.enable_reset(LeftPanel);
        }

        public override void BtnDelete_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, You want to Delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(proID, "st_deleteProduct", "@proID");
                    r.showProducts(dataGridView1, proIDGV, proNameGV, barcodeGV, expiryGV, priceGV, catGV, catIDGV);
                }
            }
            MainClass.enable_reset(LeftPanel);
        }
    

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void btnViewAll_Click(object sender, EventArgs e)
        {
            r.showProducts(dataGridView1, proIDGV, proNameGV, barcodeGV, expiryGV, priceGV, catGV, catIDGV);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                proID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                proNameTxt.Text = row.Cells["proNameGV"].Value.ToString();
                barCodeTxt.Text = row.Cells["barcodeGV"].Value.ToString();
                if (row.Cells["expiryGV"].FormattedValue.ToString() == string.Empty)
                {
                    ExpiryPicker.Value = DateTime.Now;
                }
                else
                {
                    ExpiryPicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                }
                PriceTxt.Text = row.Cells["priceGV"].Value.ToString();
                CatDD.SelectedItem = row.Cells["catGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
