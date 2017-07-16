using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace QL_BanHang.Model
{
    class ConnectToSQL
    {
        #region Availible
        private static SqlConnection Conn;
        private SqlCommand _cmd;
        private static string StrCon =null;
        private string _error;




        //----------------
       public static void  ExecuteNonQuery(string cmd) { 
        SqlConnection dbConn = new SqlConnection(StrCon);
        dbConn.Open();
        SqlCommand dbCmd = new SqlCommand(cmd, dbConn);
        dbCmd.ExecuteNonQuery();
        dbConn.Close();
        }


        public static DataTable GetData (string cmd)
        {
            SqlConnection dbConn = new SqlConnection(StrCon);
            SqlDataAdapter adap = new SqlDataAdapter(); 
            dbConn.Open();
            adap.SelectCommand = new SqlCommand(cmd, dbConn);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            dbConn.Close();
            return ds;
        }
        //-------------
       
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public SqlConnection Connection
        {
            get { return Conn; }
        }

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        #endregion
        #region Contrustor
        // chuỗi kết nối với csdl
        public ConnectToSQL()
        {
            StrCon = @"Data Source = (local)\PHUNG;Initial Catalog = QLCH; Integrated Security = True";
            Conn = new SqlConnection(StrCon);
        }
        #endregion

        #region Methods
        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch(Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }
        #endregion
    }
}
