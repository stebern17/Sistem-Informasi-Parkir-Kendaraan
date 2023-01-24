using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using SistemParkir.Model.Entity;
using SistemParkir.Model.Respository;
using SistemParkir.Model.Context;

namespace SistemParkir.Controller
{
    public class KendaraanController
    {
        private KendaraanRespository _repository;

        public List<Kendaraan> ReadAll(string IdPetugas)
        {
            // membuat objek collection
            List<Kendaraan> list = new List<Kendaraan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new KendaraanRespository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll(IdPetugas);
            }

            return list;
        }

        public int Create(Kendaraan ken)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(ken.PlatNomer))
            {
                MessageBox.Show("Plat Nomer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(ken.AreaParkir))
            {
                MessageBox.Show("Area Parkir harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(ken.Nominal))
            {
                MessageBox.Show("Nominal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new KendaraanRespository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(ken);
            }

            if (result > 0)
            {
                MessageBox.Show("Data berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Update(Kendaraan ken)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(ken.PlatNomer))
            {
                MessageBox.Show("Plat Nomer harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(ken.AreaParkir))
            {
                MessageBox.Show("Area Parkir harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(ken.Nominal))
            {
                MessageBox.Show("Nominal harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new KendaraanRespository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(ken);
            }

            if (result > 0)
            {
                MessageBox.Show("Data berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int Delete(Kendaraan ken)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(ken.KarcisParkir))
            {
                MessageBox.Show("Nomer Karcis harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new KendaraanRespository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.Delete(ken);
            }

            if (result > 0)
            {
                MessageBox.Show("Data berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
