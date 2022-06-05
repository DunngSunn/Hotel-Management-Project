using System;
using System.Data;
using System.Data.SqlClient;

namespace CDM.DAO
{
    public class DataProvider
    {
        #region Singleton
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DataProvider();
                return instance;
            }
        }

        private DataProvider() { }
        #endregion

        #region Public Properties
        //public static readonly string ConnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + "\\AppData\\MyHotel.mdf;Integrated Security=True";
        public static readonly string ConnString = @"Data Source=.\SQLEXPRESS;Initial Catalog=MyHotel;Integrated Security=True";
        #endregion

        #region Methods

        public DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public DataSet GetDataSet(string query)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                conn.Close();
            }
            return ds;
        }

        public int ExecuteNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    data = cmd.ExecuteNonQuery();
                }
                catch (Exception) { }
                conn.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query)
        {
            object dt = 0;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                dt = cmd.ExecuteScalar();
                conn.Close();
            }
            return dt;
        }

        public string GetString(string query)
        {
            string dt = string.Empty;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dt = dr.GetValue(0).ToString();
                }
                conn.Close();
            }
            return dt;
        }

        public bool GetBool(string query)
        {
            bool dt = false;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dt = dr.GetSqlBoolean(0).IsTrue;
                }
                conn.Close();
            }
            return dt;
        }

        public int GetInt(string query)
        {
            int dt = -1;
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    dt = dr.GetInt32(0);
                }
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
