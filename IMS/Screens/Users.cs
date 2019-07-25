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
    public partial class Users : Template2
    {
        
        int edit = 0; //This 0 is an indication to SAVE operator and 1 is an UPDATE operation
        int userID;
        short stat;
        public Users()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable(LeftPanel);
        }

        public override void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(LeftPanel);
            nameTxt.Focus();
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
            if(nameTxt.Text == string.Empty) { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (userNameTxt.Text == string.Empty) { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (pwdTxt.Text == string.Empty) { pwdErrorLabel.Visible = true; } else { pwdErrorLabel.Visible = false; }
            if (phoneTxt.Text == string.Empty) { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (emailTxt.Text == string.Empty) { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (statusCb.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }

            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || pwdErrorLabel.Visible || phoneErrorLabel.Visible || emailErrorLabel.Visible || statusErrorLabel.Visible)
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
                    i.insertUser(nameTxt.Text, userNameTxt.Text, pwdTxt.Text, phoneTxt.Text, emailTxt.Text, stat);
                    r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                    MainClass.disable_reset(LeftPanel);
                }
                else if(edit == 1) // Code for EDIT Operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure, You want to Update record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr  == DialogResult.Yes)
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
                        u.updateUser(userID, nameTxt.Text, userNameTxt.Text, pwdTxt.Text, phoneTxt.Text, emailTxt.Text, stat);
                        r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                        MainClass.disable_reset(LeftPanel);
                    }
                }
            }
        }

        public override void BtnDelete_Click(object sender, EventArgs e)
        {
            if(edit == 1)
            {
                DialogResult dr = MessageBox.Show("Are you sure, You want to Delete record?", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Deletion d = new Deletion();
                    d.delete(userID, "st_deleteUsers", "@id");
                    r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
                }
            }
        }

        public override void SearchTxt_TextChanged(object sender, EventArgs e)
        {
            if (searchTxt.Text != string.Empty)
            {
                r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV, searchTxt.Text);
            }
            else
            {
                r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
            }
        }

        public override void btnViewAll_Click(object sender, EventArgs e)
        {
            r.showUsers(dataGridView1, UserIDGV, NameGV, UsernameGV, PassGV, PhoneGV, EmailGV, StatusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTxt.Text = row.Cells["NameGV"].Value.ToString();
                userNameTxt.Text = row.Cells["UsernameGV"].Value.ToString();
                pwdTxt.Text = row.Cells["PassGV"].Value.ToString();
                phoneTxt.Text = row.Cells["PhoneGV"].Value.ToString();
                emailTxt.Text = row.Cells["EmailGV"].Value.ToString();
                statusCb.SelectedItem = row.Cells["StatusGV"].Value.ToString();
                MainClass.disable(LeftPanel);
            }
        }
    }
}
