using IMS.Screens;
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
    public partial class HomeScreen : Template
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDI.ActiveForm);
        }

        private void catBtn_Click(object sender, EventArgs e)
        {
            categories c = new categories();
            MainClass.showWindow(c, this, MDI.ActiveForm);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            UserLabel.Text = retrieval.EMP_NAME;
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            Login log = new Login();
            MainClass.showWindow(log, this, MDI.ActiveForm);
            
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Supplier p = new Supplier();
            MainClass.showWindow(p, this, MDI.ActiveForm);
        }

        private void btnPurInvoice_Click(object sender, EventArgs e)
        {
            PurchaseInvoice pI = new PurchaseInvoice();
            MainClass.showWindow(pI, this, MDI.ActiveForm);
        }
        
    }
}
