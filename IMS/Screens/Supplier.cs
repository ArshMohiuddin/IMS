using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.Screens
{
    public partial class Supplier : Template2
    {
        int edit = 0; //This 0 is an indication to SAVE operator and 1 is an UPDATE operation
        int supplierID;
        short stat;
        public Supplier()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void Supplier_Load(object sender, EventArgs e)
        {
            MainClass.disable(LeftPanel);
        }

        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
            SupplierCompanyTxt.Focus();
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
            if (SupplierCompanyTxt.Text == string.Empty) { supCompErrorLabel.Visible = true; } else { supCompErrorLabel.Visible = false; }
            if (contactPersonTxt.Text == string.Empty) { contactPerErrorLabel.Visible = true; } else { contactPerErrorLabel.Visible = false; }
            if (phone1Txt.Text == string.Empty) { phone1ErrorLabel.Visible = true; } else { phone1ErrorLabel.Visible = false; }
            if (AddressTxt.Text == string.Empty) { addressErrorLabel.Visible = true; } else { addressErrorLabel.Visible = false; }
            if (statusCb.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (supCompErrorLabel.Visible || contactPerErrorLabel.Visible || phone1ErrorLabel.Visible || addressErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message
            }
            else
            {

                if (statusCb.SelectedIndex == 0)
                {
                    stat = 1;
                }
                else if (statusCb.SelectedIndex == 1)
                {
                    stat = 0;
                }
                if (edit == 0) // Code for SAVE Operation
                {

                    Insertion i = new Insertion();
                    if (phone2Txt.Text == string.Empty && ntnTxt.Text != string.Empty)
                    {
                        i.insertSupplier(SupplierCompanyTxt.Text, contactPersonTxt.Text, phone1Txt.Text, AddressTxt.Text, stat, null, ntnTxt.Text);
                    }
                    else if(phone2Txt.Text != string.Empty && ntnTxt.Text == string.Empty)
                    {
                        i.insertSupplier(SupplierCompanyTxt.Text, contactPersonTxt.Text, phone1Txt.Text, AddressTxt.Text, stat, phone2Txt.Text, null);
                    }
                    else if (phone2Txt.Text == string.Empty && ntnTxt.Text == string.Empty)
                    {
                        i.insertSupplier(SupplierCompanyTxt.Text, contactPersonTxt.Text, phone1Txt.Text, AddressTxt.Text, stat, null, null);
                    }
                    else
                    {
                        i.insertSupplier(SupplierCompanyTxt.Text, contactPersonTxt.Text, phone1Txt.Text, AddressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                    }

                    r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, Phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                    MainClass.disable_reset(LeftPanel);
                }
                else if (edit == 1) // Code for EDIT Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, You want to Update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        Updation u = new Updation();
                        if (statusCb.SelectedIndex == 0)
                        {
                            stat = 1;
                        }
                        else if (statusCb.SelectedIndex == 1)
                        {
                            stat = 0;
                        }
                        if (phone2Txt.Text == string.Empty && ntnTxt.Text != string.Empty)
                        {
                            u.updateSupplier(supplierID, SupplierCompanyTxt.Text, contactPersonTxt.Text, phone1Txt.Text, AddressTxt.Text, stat, null, ntnTxt.Text);
                        }
                        else if (phone2Txt.Text != string.Empty && ntnTxt.Text == string.Empty)
                        {
                            u.updateSupplier(supplierID, SupplierCompanyTxt.Text, contactPersonTxt.Text, phone1Txt.Text, AddressTxt.Text, stat, phone2Txt.Text, null);
                        }
                        else if (phone2Txt.Text == string.Empty && ntnTxt.Text == string.Empty)
                        {
                            u.updateSupplier(supplierID, SupplierCompanyTxt.Text, contactPersonTxt.Text, phone1Txt.Text, AddressTxt.Text, stat, null, null);
                        }
                        else
                        {
                            u.updateSupplier(supplierID, SupplierCompanyTxt.Text, contactPersonTxt.Text, phone1Txt.Text, AddressTxt.Text, stat, phone2Txt.Text, ntnTxt.Text);
                        }
                        r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, Phone1GV, phone2GV, addressGV, ntnGV, statusGV);
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
                    d.delete(supplierID, "st_deleteSupplier", "@suppID");
                    r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, Phone1GV, phone2GV, addressGV, ntnGV, statusGV);
                }
            }
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public override void btnViewAll_Click(object sender, EventArgs e)
        {
            r.showSuppliers(dataGridView1, suppIDGV, companyGV, personGV, Phone1GV, phone2GV, addressGV, ntnGV, statusGV);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                supplierID = Convert.ToInt32(row.Cells["suppIDGV"].Value.ToString());
                SupplierCompanyTxt.Text = row.Cells["companyGV"].Value.ToString();
                contactPersonTxt.Text = row.Cells["personGV"].Value.ToString();
                phone1Txt.Text = row.Cells["Phone1GV"].Value.ToString();
                phone2Txt.Text = row.Cells["phone2GV"].Value.ToString();
                AddressTxt.Text = row.Cells["addressGV"].Value.ToString();
                ntnTxt.Text = row.Cells["ntnGV"].Value.ToString();
                statusCb.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
