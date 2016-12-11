using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace DataAcessLayer
{
    public class DBHandler
    {
        public string connStr = "Data Source=DESKTOP-EFRBUKN;Initial Catalog=TicketResrvation;Integrated Security=True";
        public bool writeonfile(string name,string cntct , string cnic , string seat)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                conn.Open();
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    string query = "insert into information (name,contactno,cnic,seatno) values ('" + name + "','" + cntct + "','" + cnic + "','" + seat + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }

            }
            catch (SqlException obj)
            { }
            catch (NullReferenceException obj)
            { }
            catch (ArgumentException obj)
            { }
            catch (IndexOutOfRangeException obj)
            { }

            return false;
        }
        public bool exist(string seat)
        {
            SqlConnection con = new SqlConnection(connStr);
            try
            {
                 con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string query = "select count(seatno) from information where seatno='" + seat + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    int count = (int)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        con.Close();
                        return true;
                    }
                }
            }
            catch (SqlException obj)
            { }
            catch (NullReferenceException obj)
            { }
            finally
            {
                con.Close();
            }
            return false;
       
        }
        public string[] checkstatus()
        {

            //string colname = "SeatNo";
           // DataTable dt = new DataTable("Information");
            string[] arr = null;
            int countrecords = 0;
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string q = "select count(*) from information";
                    SqlCommand cmd = new SqlCommand(q, con);
                    countrecords = (int)cmd.ExecuteScalar();
                    arr = new string[countrecords];
                    string query = "select seatno from information";
                    SqlCommand cm = new SqlCommand(query, con);
                    int i = 0;
                    using (SqlDataReader reader = cm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            arr[i] = reader.GetValue(0).ToString();
                            i++;
                        }
                    }


                    // return arr;
                }
            }
            catch (SqlException obj)
            { }
            catch (NullReferenceException obj)
            { }
            catch (ArgumentException obj)
            { }
            catch (IndexOutOfRangeException obj)
            { }

            return arr;
        }
        public bool remove(string cnic, string seat)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string quer = "select count(seatno) from information where cnic='" + cnic + "' and seatno='" + seat + "'";
                    SqlCommand cmd = new SqlCommand(quer, con);
                    int c = (int)cmd.ExecuteScalar();
                    if (c > 0)
                    {
                        string q = "delete from information where cnic='" + cnic + "' and seatno='" + seat + "'";
                        SqlCommand cm = new SqlCommand(q, con);
                        cm.ExecuteNonQuery();
                        return true;
                    }
                    else
                        return false;
                }
              //  return false;
            }
            catch (ArgumentNullException obj)
            { }
            catch (NullReferenceException obj)
            { }
            catch (SqlException obj)
            { }
            return false;
        }
        
      }
        
}
