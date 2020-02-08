using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication6
{
    public class ADOlayer
    {
        string constr = "";
        public ADOlayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstr"].ConnectionString;
        }
        public DataSet getstu(int tid)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tid", tid);
                    cmd.CommandText = "showbid";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                    ada.Update(ds);
                }
            }
            catch { }
            return ds;
        }
        public void updatedata(int tid, string tname)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tid", tid);
                    cmd.Parameters.AddWithValue("@tname", tname);
                    cmd.CommandText = "update";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter uda = new SqlDataAdapter(cmd);
                    uda.Fill(ds);
                    uda.Update(ds);
                }
            }
            catch { }
        }
        public void insertrow(int tid, string tname, string tlocation, string domain, string StartDate)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Parameters.AddWithValue("@tId", tid);
                    cmd.Parameters.AddWithValue("@tname", tname);
                    cmd.Parameters.AddWithValue("@tlocation", tlocation);
                    cmd.Parameters.AddWithValue("@domain",domain);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate);

                    cmd.CommandText = "insert";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
            }
            catch { }
        }
        public DataSet Getallrecords()
        {
            DataSet ds = new DataSet();
            string selqry = "select * from Trainee";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(selqry, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);

                }
            }
            catch (Exception ex)
            {

            }
            return ds;
        }
    }
}

