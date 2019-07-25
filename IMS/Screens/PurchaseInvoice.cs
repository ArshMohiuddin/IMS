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
    public partial class PurchaseInvoice : Template2
    {
        public PurchaseInvoice()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        int productID;
        private void PurchaseInvoice_Load(object sender, EventArgs e)
        {
            r.getList("st_getSupplierList", supCb, "Company", "ID");
        }

        string[] prodARR = new string[3];
        private void barcodeTxt_Validated(object sender, EventArgs e)
        {

            if (barcodeTxt.Text != string.Empty)
            {
                prodARR = r.getProductByBarcode(barcodeTxt.Text);
                productID = Convert.ToInt32(prodARR[0]);
                productTxt.Text = prodARR[1];
                perUnitpriceTxt.Text = prodARR[2];
                productTxt.Enabled = false;
                perUnitpriceTxt.Enabled = false;
            }
            else
            {
                productID = 0;
                productTxt.Text = string.Empty;
                perUnitpriceTxt.Text = string.Empty;
                Array.Clear(prodARR, 0, prodARR.Length);

            }
        }
    }
}
