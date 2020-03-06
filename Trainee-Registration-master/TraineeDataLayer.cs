using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Configuration;

namespace TraineeApp
{
    public class TraineeDataLayer
    {
        private string connectedstring;
        DataSet ds = new DataSet();

        public TraineeDataLayer()
        {
            connectedstring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
        }
        
        public void Insert(RepTr r)
        {
            try 
            {
                using(SqlConnection con = new SqlConnection(connectedstring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "sel";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@tid", r.tid);
                    cmd.Parameters.AddWithValue("@tname", r.tname);
                    cmd.Parameters.AddWithValue("@location", r.location);
                    cmd.Parameters.AddWithValue("@techdomain", r.techdomain);
                    cmd.Parameters.AddWithValue("@startdate", r.startdate);

                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    sd.Fill(ds);
                    sd.Update(ds);
                }
            }
            catch(Exception e)
            {               
            }
            
        }

        public void Update(RepTr r)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectedstring))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand();
                    command.CommandText = "upd1";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conn;

                    command.Parameters.AddWithValue("@tid", r.tid);
                    command.Parameters.AddWithValue("@techdomain", r.techdomain);

                    SqlDataAdapter sda = new SqlDataAdapter(command);
                    sda.Fill(ds);
                    sda.Update(ds);
                }
            }
            catch (Exception e)
            {
                
            }
            
        }

        public DataSet GetData()
        {
            
            try
            {
                using(SqlConnection con = new SqlConnection(connectedstring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "ins";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    sd.Fill(ds);
                    sd.Update(ds);
                }
            }
            catch(Exception e)
            {

            }
            return ds;
        }

        public DataSet GetparData(RepTr r)
        {
            
            try
            {
                using (SqlConnection con = new SqlConnection(connectedstring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "selpar";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@tid", r.tid);
                    SqlDataAdapter sd = new SqlDataAdapter(cmd);
                    sd.Fill(ds);
                    sd.Update(ds);
                }
            }
            catch
            {

            }
            return ds;
        }
    }
}