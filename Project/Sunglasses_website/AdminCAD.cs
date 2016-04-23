using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace Sunglasses_website
{
    class AdminCAD
    {
        public DataSet searchAdmin(string nameAdmin)
        {
            //String where it's stored the instructions for the connecton for the DB
            string str = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            DataSet virtdb = new DataSet(); // Created the DataSet that is going to be returned with the information asked
            SqlConnection c = new SqlConnection(str);

            try
            {    //The select in SQL language that is processed in the DB which will return all the rows from the table "Admin"
                SqlDataAdapter da = new SqlDataAdapter("select count(*) from Admin where Id = '" + nameAdmin + "'", c);
                da.Fill(virtdb, "admin"); //It introduces the information returned from the select into this virtual DB 

            }
            catch (Exception e)
            {
                e.ToString();
                Console.WriteLine("ERROR: show admin");
            }
            finally
            {
                c.Close();
            }
            return virtdb;
        }
    }
}