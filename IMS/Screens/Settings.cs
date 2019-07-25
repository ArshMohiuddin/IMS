using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Settings : Template
    {

        public Settings()
        {
            InitializeComponent();
        }
        string s;
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (isCB.Checked)
            {
                if (ServerTxt.Text != string.Empty && databaseTxt.Text != string.Empty)
                {
                    s = "Data Source=" + ServerTxt.Text + "; Initial Catalog=" + databaseTxt.Text + "; Integrated Security=true;";
                    File.WriteAllText(path+ "\\connect", s);

                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to countinue...");
                }
            }
            else
            {
                if (ServerTxt.Text != string.Empty && databaseTxt.Text != string.Empty && UserIdTxt.Text != string.Empty && passTxt.Text != string.Empty)
                {
                    s = "Data Source=" + ServerTxt.Text + "; Initial Catalog=" + databaseTxt.Text + "; User ID="+UserIdTxt.Text+"; Password="+passTxt.Text+";";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Saved Successfully...", "information...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        Login log = new Login();
                        MainClass.showWindow(log, this, MDI.ActiveForm);
                    }
                }
                else
                {
                    MessageBox.Show("Please give complete data to countinue...");
                }
            }
        } 

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                UserIdTxt.Enabled = false;
                passTxt.Enabled = false;
                UserIdTxt.Text = string.Empty;
                passTxt.Text = string.Empty;
            }
            else
            {
                UserIdTxt.Enabled = true;
                passTxt.Enabled = true;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            
        }
    }
}
