using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using SistemParkir.Model.Respository;
using SistemParkir.Model.Context;

namespace SistemParkir.Controller
{
    public class UserController
    {
        private UserRespository _repository;
        public bool IsValidUser(string petugas)
        {
            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(petugas))
            {
                MessageBox.Show("Id Petugas harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new UserRespository(context);

                // panggil method Create class repository untuk menambahkan data
                isValidUser = _repository.IsValidUser(petugas);
            }

            if (!isValidUser)
            {
                MessageBox.Show("Id Petugas salah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }
    }
}
