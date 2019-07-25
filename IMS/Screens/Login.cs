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
    public partial class Login : Template
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text.Trim() == string.Empty) { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (passtxt.Text.Trim() == string.Empty) { PassErrorLabel.Visible = true; } else { PassErrorLabel.Visible = false; }
            if (nameErrorLabel.Visible || PassErrorLabel.Visible)
            {
                MainClass.showMSG("Fields with * are mandatory", "Stop", "Error"); //Error is the type of message
            }
            else
            {
                if(usernameTxt.Text != "" && passtxt.Text != "")
                {
                    if (retrieval.getUserDetails(usernameTxt.Text, passtxt.Text))
                    {
                        HomeScreen hs = new HomeScreen();
                        MainClass.showWindow(hs, this, MDI.ActiveForm);
                    }
                    else
                    {

                    }
                }  
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (usernameTxt.Text.Trim() == string.Empty) { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            if (passtxt.Text.Trim() == string.Empty) { PassErrorLabel.Visible = true; } else { PassErrorLabel.Visible = false; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
