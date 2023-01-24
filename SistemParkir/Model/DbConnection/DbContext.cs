using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Data.Entity;

namespace SistemParkir.Model.Context
{
    public class DbContext : IDisposable
    {
        private SQLiteConnection _conn;

        public SQLiteConnection conn
        {
            get { return _conn ?? (_conn = GetOpenConnection()); }
        }

        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;

            try
            {
                //string dbName = Directory.GetCurrentDirectory() + @"D:\FP Pemro\SistemParkir\Database\SistemParkir.db";
                //string dbName = @"D:\FP Pemro\SistemParkir\Database\SistemParkir.db";
                string dbName = Directory.GetCurrentDirectory() + "\\Database\\SistemParkir.db";
                string connectionString = string.Format("Data Source={0};FailIfMissing=True", dbName);
                conn = new SQLiteConnection(connectionString); // buat objek connection
                conn.Open();

            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }

            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
