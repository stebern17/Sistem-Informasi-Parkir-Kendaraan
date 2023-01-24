using SistemParkir.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemParkir.Model.Respository
{
    public class UserRespository
    {
        private SQLiteConnection _conn;

        public UserRespository(DbContext context)
        {
            _conn = context.conn;
        }

        public bool IsValidUser(string petugas)
        {
            bool result = false;

            string sql = @"select count(*) as row_count
                           from Petugas
                           where IdPetugas = @IdPetugas";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@IdPetugas", petugas);
                

                // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                using (SQLiteDataReader dtr = cmd.ExecuteReader())
                {
                    // panggil method Read untuk mendapatkan baris dari result set
                    if (dtr.Read())
                    {
                        result = Convert.ToInt32(dtr["row_count"]) > 0;
                    }
                }
            }

            return result;
        }
    }
}
