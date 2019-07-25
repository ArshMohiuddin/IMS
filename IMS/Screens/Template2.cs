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
    public partial class Template2 : Template
    {
        public Template2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeScreen obj = new HomeScreen();
            MainClass.showWindow(obj, this, MDI.ActiveForm);
        }

        public virtual void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        public virtual void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        public virtual void BtnSave_Click(object sender, EventArgs e)
        {

        }

        public virtual void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        public virtual void SearchTxt_TextChanged(object sender, EventArgs e)
        {

        }

        public virtual void btnViewAll_Click(object sender, EventArgs e)
        {

        }
    }
}
