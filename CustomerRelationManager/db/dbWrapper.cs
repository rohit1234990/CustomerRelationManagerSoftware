using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;

namespace CustomerRelationManager
{
    static class dbWrapper
    {
        private static SqlCeConnection   conn;

        private static void OpenConnection()
        {
            string connectionString = "Data Source=" + System.IO.Directory.GetCurrentDirectory() + "\\db\\Database.sdf";
            conn = new SqlCeConnection(connectionString);
            conn.Open();
        }
        private static void CloseConnection()
        {
            conn.Close();
        }
        public static void InsertData(string Query)
        {
            OpenConnection();
            SqlCeCommand cmd = new SqlCeCommand(Query, conn);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public static void InsertData(SqlCeCommand cmd)
        {
            OpenConnection();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public static DataTable SelectData(string query)
        {
            OpenConnection();
            SqlCeCommand cmd = new SqlCeCommand(query, conn);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();

            return dt;
        }

        public static DataTable SelectData(SqlCeCommand cmd)
        {
            OpenConnection();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            cmd.Connection = conn;

            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseConnection();

            return dt;
        }

        public static void DeleteData(SqlCeCommand cmd)
        {
            OpenConnection();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public static void UpdateData(SqlCeCommand cmd)
        {
            OpenConnection();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public static object ExecureScaler(SqlCeCommand cmd)
        {
            object result;
            OpenConnection();
            cmd.Connection = conn;
            result = cmd.ExecuteScalar();
            CloseConnection();

            return result;
        }

    }
}
