﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS
{
    class Updation
    {
        public void updateUser(int id, string name, string username, string pwd, string phone, string email, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " updated to the system successfully", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");

            }
        }

        public void updatetCat(int id,string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@id", id);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(name + " Updated successfully", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");

            }
        }

        public void updateProduct(int proID, string product, string barcode, float price, int catID, DateTime? expiry=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_updateProduct", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", product);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@price", price);
                if (expiry == null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);
                }
                cmd.Parameters.AddWithValue("@catID", catID);
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(product + " updated to the system successfully", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");

            }
        }

        public void updateSupplier(int supID, string company, string person, string phone1, string address, Int16 status, string phone2 = null, string ntn = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_UpdateSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@contactPerson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);
                }
                cmd.Parameters.AddWithValue("@address", address);
                if (ntn == null)
                {
                    cmd.Parameters.AddWithValue("@ntn", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@ntn", ntn);
                }
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@suppID", supID);


                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.showMSG(company + " updated successfully", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.showMSG(ex.Message, "Error...", "Error");

            }
        }
    }
}
