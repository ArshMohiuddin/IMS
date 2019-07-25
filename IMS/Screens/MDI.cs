using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace IMS
{
    public partial class MDI : Form
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public MDI()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path + "\\connect"))
                {
                    Login log = new Login();
                    MainClass.showWindow(log, this);
                }
                else
                {
                    Settings set = new Settings();
                    MainClass.showWindow(set, this);

                    
                }
            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error", "Error");
                
            }
           
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            MainClass.showWindow(set, this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            MainClass.showWindow(log, MDI.ActiveForm);
        }
        
    }
}
