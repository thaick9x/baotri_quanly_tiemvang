using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QuanLyTiemVang
{
    class DataBase
    {
        //protected static String _connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=./QuanLyTiemVang.mdb;";
        //protected static String _connectionString = @"Provider=ADsDSOObject; DATA SOURCE=localhost;UID=root;PWD=123123";
        //protected static String _connectionString = @"Provider=MySQLProv; Data Source=localhost; User ID =root; Password=123123; Initial Catalog=quanly_tiemvang;";
        protected static String _connectionString = @"Provider=MySQL Provider; Data Source=localhost; User ID=root; Password=123123; Initial Catalog=quanly_tiemvang; Activation=N5X9-PENF-AK8M-ZDPW;";
        //protected static String _connectionString = @"Provider=MySQL Provider; Data Source=sql206.byethost32.com; User ID=b32_14607852; Password=159357a; Initial Catalog=b32_14607852_quanly_tiemvang; Activation=N5X9-PENF-AK8M-ZDPW;";
        static OleDbConnection connection;
        public static void OpenConnection()
        {
            try
            {
                connection = new OleDbConnection(_connectionString);
                connection.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }

        public static DataTable ExcuQuery(string sql)
        {
            OpenConnection();
            DataTable dt = new DataTable();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }
        public static void ExcuNonQuery(string sql)
        {
            OpenConnection();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}