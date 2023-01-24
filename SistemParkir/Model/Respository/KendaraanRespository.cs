using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using SistemParkir.Model.Context;
using SistemParkir.Model.Entity;

namespace SistemParkir.Model.Respository
{
    public class KendaraanRespository
    {
        private SQLiteConnection _conn;

        public KendaraanRespository(DbContext context)
        {
            _conn = context.conn;
        }

        public int Create(Kendaraan ken)
        {
            int result = 0;

            string sql = @"insert into KarcisParkir (PlatNomer, AreaParkir, NominalTarif,IdPetugas )
                            values (@PlatNomer, @AreaParkir, @Nominal, @IdPetugas)";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@PlatNomer", ken.PlatNomer);
                cmd.Parameters.AddWithValue("@AreaParkir", ken.AreaParkir);
                cmd.Parameters.AddWithValue("@Nominal", ken.Nominal);
                cmd.Parameters.AddWithValue("@IdPetugas", ken.IdPetugas);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;

        }

        public int Update(Kendaraan ken)
        {
            int result = 0;

            string sql = @"update KarcisParkir set PlatNomer = @PlatNomer, AreaParkir = @AreaParkir, NominalTarif = @Nominal
                            where idKarcis = @KarcisParkir";

            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@PlatNomer", ken.PlatNomer);
                cmd.Parameters.AddWithValue("@AreaParkir", ken.AreaParkir);
                cmd.Parameters.AddWithValue("@Nominal", ken.Nominal);
                cmd.Parameters.AddWithValue("@KarcisParkir", ken.KarcisParkir);

                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }

            }
            return result;
        }

        public int Delete(Kendaraan ken)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from KarcisParkir
                           where idKarcis = @KarcisParkir";

            // membuat objek command menggunakan blok using
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@KarcisParkir", ken.KarcisParkir);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Kendaraan> ReadAll(string IdPetugas)
        {
            List<Kendaraan> list = new List<Kendaraan>();

            try
            {
                string sql = @"select idKarcis, PlatNomer, AreaParkir, NominalTarif
                                from KarcisParkir
                                where IdPetugas=@IdPetugas
                                order by idKarcis";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@IdPetugas", IdPetugas);
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Kendaraan ken = new Kendaraan();
                            ken.KarcisParkir = dtr["idKarcis"].ToString();
                            ken.PlatNomer = dtr["PlatNomer"].ToString();
                            ken.AreaParkir = dtr["AreaParkir"].ToString();
                            ken.Nominal = dtr["NominalTarif"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(ken);
                        }

                    }

                }
            }

            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }
    }
}
