using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    class retrieval
    {
        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn pwdGV, DataGridViewColumn phoneGV, DataGridViewColumn emailGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                     cmd = new SqlCommand("st_getUsersData", MainClass.con);
                }
                else
                {
                     cmd = new SqlCommand("st_getUsersDataLike", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                pwdGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error", "Error");
            }
        }

        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoriesData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error", "Error");
            }
        }

        public void getList(string proc, ComboBox cb, string DisplayMember, string ValueMember)
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = null;
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray =  new object[]{0, "Select..."};
                dt.Rows.InsertAt(dr, 0);
                cb.DataSource = dt;
                cb.DisplayMember = DisplayMember;
                cb.ValueMember = ValueMember;
               
                
            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error", "Error");
            }
        }

        public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn proNameGV, DataGridViewColumn barcodeGV, DataGridViewColumn expiryGV, DataGridViewColumn priceGV, DataGridViewColumn catGV, DataGridViewColumn catIDGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                proNameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                barcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error", "Error");
            }
        }

        public static int User_ID
        {
            get;
            private set;
        }
        public static string EMP_NAME
        {
            get;
            private set;
        }
        private string[] productData = new string[3];
        public string[] getProductByBarcode(string barcode)
        {
            try
            {
              
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while (dr.Read())
                    {
                        productData[0] = dr[0].ToString();
                        productData[1] = dr[1].ToString();
                        productData[2] = dr[2].ToString();
                    }

                }
                else
                {
                   
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error", "Error");
            }
            return productData;
        }
        private static string user_name = null, pass_word = null;
        private static bool checkLogin;
        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUsersDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    checkLogin = true;
                    while (dr.Read())
                    {

                        User_ID = Convert.ToInt32(dr["ID"].ToString());
                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
               
                }
                else
                {
                    checkLogin = false;
                    if (username != null && password != null)
                    {
                        if (user_name != username && pass_word == password)
                        {
                            MainClass.showMSG("Invalid Username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.showMSG("Invalid Username and Password", "Error", "Error");
                        }
                       

                    }
                    
                    
                }
                MainClass.con.Close();
            }
            catch (Exception)
            {

                MainClass.con.Close();
                MainClass.showMSG("Unable to Login...", "Error", "Error");
            }

            return checkLogin;
        }

        public void showSuppliers(DataGridView gv, DataGridViewColumn suppIDGV, DataGridViewColumn comNameGV, DataGridViewColumn personGV, DataGridViewColumn phone1GV, DataGridViewColumn phone2GV, DataGridViewColumn addressGV, DataGridViewColumn ntnGV, DataGridViewColumn statusGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getSupplierData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                suppIDGV.DataPropertyName   = dt.Columns["ID"].ToString();
                comNameGV.DataPropertyName  = dt.Columns["Company"].ToString();
                personGV.DataPropertyName   = dt.Columns["Contact Person"].ToString();
                phone1GV.DataPropertyName   = dt.Columns["Phone 1"].ToString();
                phone2GV.DataPropertyName   = dt.Columns["Phone 2"].ToString();
                addressGV.DataPropertyName  = dt.Columns["Address"].ToString();
                ntnGV.DataPropertyName      = dt.Columns["NTN #"].ToString();
                statusGV.DataPropertyName   = dt.Columns["Status"].ToString();

                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MainClass.showMSG(ex.Message, "Error", "Error");
            }
        }
    }

   
}
