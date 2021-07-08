using DigitalAv.Models.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DigitalAv.Repositories.Database
{
    public class Db
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-1ADK02IQ\\SQLEXPRESS;Initial Catalog=Digital;Integrated Security=true");

        //Get Country list
        public DataSet GetCountry()
        {
            SqlCommand com = new SqlCommand("Sp_Country", conn);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        //public DataSet GetCustomerName()
        //{
        //    SqlCommand com = new SqlCommand("SelectCustomerName", conn);
        //    com.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter da = new SqlDataAdapter(com);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    return ds;
        //}

        public DataSet GetProduct()
        {
            SqlCommand com = new SqlCommand("dbo.SelectProduct", conn);
            com.CommandType = CommandType.StoredProcedure;
            //com.Parameters.AddWithValue("@ProductID", pid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet GetRegion(string cid)
        {
            SqlCommand com = new SqlCommand("dbo.SelectCountryRegion", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CountryCode", cid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

           // var data = ds.Tables[0];
            return ds;
        }


        public DataSet GetCity(string sid)
        {
            SqlCommand com = new SqlCommand("dbo.SelectCountryRegionCity", conn);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@RegionCode", sid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet GetAllSAles()
        {
            SqlCommand com = new SqlCommand("SelectSales", conn);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public int InsertSalesDetails(Sales sales)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("InsertSales", conn);
           
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SalesName", sales.SalesName);
                cmd.Parameters.AddWithValue("@CountryCode", sales.CountryCode);
                cmd.Parameters.AddWithValue("@RegionCode", sales.RegionCode);
                cmd.Parameters.AddWithValue("@CityCode", sales.CityCode);
                cmd.Parameters.AddWithValue("@ProductId", sales.ProductID);
                cmd.Parameters.AddWithValue("@Quantity", sales.Quantity);

               return cmd.ExecuteNonQuery();

            conn.Close();
           
        }
           



    }
}
