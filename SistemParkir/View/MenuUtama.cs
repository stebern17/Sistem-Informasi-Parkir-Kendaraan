using SistemParkir.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemParkir.Controller;
using SistemParkir.Model.Respository;

namespace SistemParkir.View
{
    public partial class MenuUtama : Form
    {
        public delegate void CreateUpdateEventHandler(Kendaraan ken);
        public event CreateUpdateEventHandler OnCreate;

        //tampil data
        private List<Kendaraan> listOfKendaraan = new List<Kendaraan>();
        private Kendaraan kendaraanSelected = null;
        public string IdPetugas { get; set; }



        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private KendaraanController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private Kendaraan ken;
        //tampil data
        private void InisialisasiListView()
        {
            lvwKendaraan.View = System.Windows.Forms.View.Details;
            lvwKendaraan.FullRowSelect = true;
            lvwKendaraan.GridLines = true;

            lvwKendaraan.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwKendaraan.Columns.Add("Karcis", 91, HorizontalAlignment.Center);
            lvwKendaraan.Columns.Add("Plat Nomer", 250, HorizontalAlignment.Left);
            lvwKendaraan.Columns.Add("Area Parkir", 80, HorizontalAlignment.Center);
            lvwKendaraan.Columns.Add("Nominal", 100, HorizontalAlignment.Center);

        }

        public MenuUtama()
        {

            controller = new KendaraanController();
            InitializeComponent();
            InisialisasiListView();

        }

        //tampil data
        private void LoadDataKendaraan()
        {
            lvwKendaraan.Items.Clear();
            listOfKendaraan = controller.ReadAll(IdPetugas);
            foreach (var item in listOfKendaraan)
            {
                int no = lvwKendaraan.Items.Count + 1;
                var listItem = new ListViewItem(no.ToString());
                listItem.SubItems.Add(item.KarcisParkir);
                listItem.SubItems.Add(item.PlatNomer);
                listItem.SubItems.Add(item.AreaParkir);
                listItem.SubItems.Add(item.Nominal);
                lvwKendaraan.Items.Add(listItem);
            }
        }

        public MenuUtama(string idPetugas)
            : this()
        {
            this.IdPetugas = idPetugas;
            LoadDataKendaraan();
        }
/*
        public MenuUtama(string title, Kendaraan obj, KendaraanController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; // set status edit data
            ken = obj; // set objek mhs yang akan diedit

            // untuk edit data, tampilkan data lama
            *//*  txtPlatNomer.Text = ken.PlatNomer;
              txtAreaParkir.Text = ken.AreaParkir;
              txtNominal.Text = ken.Nominal;*//*

        }*/

        /* private void button1_Click(object sender, EventArgs e)
         {
             if (isNewData) ken = new Kendaraan();

             ken.PlatNomer = txtPlatNomer.Text;
             ken.AreaParkir = txtAreaParkir.Text;
             ken.Nominal = txtNominal.Text;

             int result = 0;

             if (isNewData)
             {
                 result = controller.Create(ken);

                 if(result > 0)
                 {
                     OnCreate(ken);

                     ResetForm();

                 }
             }

         }*/

        private void ResetForm()
        {
            txtAreaParkir.Clear();
            txtNominal.Clear();
            textPlatKendaraan.Clear();
            txtNoKarcis.Clear();
            kendaraanSelected = null;
        }

        private void lvwKendaraan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwKendaraan.SelectedIndices.Count > 0)
            {
                kendaraanSelected = listOfKendaraan[lvwKendaraan.SelectedIndices[0]];
                txtNominal.Text = kendaraanSelected.Nominal;
                txtAreaParkir.Text = kendaraanSelected.AreaParkir;
                textPlatKendaraan.Text = kendaraanSelected.PlatNomer;
                txtNoKarcis.Text = kendaraanSelected.KarcisParkir;
            }
            else
            {
                ResetForm();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (kendaraanSelected == null)
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (MessageBox.Show("Apakah anda yakin !!!", "Peringatan",
              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    kendaraanSelected.KarcisParkir = txtNoKarcis.Text;
                    controller.Delete(kendaraanSelected);
                    LoadDataKendaraan();
                    ResetForm();
                }
            }
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnTambahData_Click(object sender, EventArgs e)
        {
            kendaraanSelected = new Kendaraan()
            {
                IdPetugas=this.IdPetugas,
                AreaParkir = txtAreaParkir.Text,
                Nominal = txtNominal.Text,
                PlatNomer = textPlatKendaraan.Text,
            };
            controller.Create(kendaraanSelected);
            LoadDataKendaraan();
            ResetForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (kendaraanSelected == null)
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
              MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                kendaraanSelected = new Kendaraan()
                {
                    KarcisParkir = txtNoKarcis.Text,
                    AreaParkir = txtAreaParkir.Text,
                    Nominal = txtNominal.Text,
                    PlatNomer = textPlatKendaraan.Text,
                };
                controller.Update(kendaraanSelected);
                LoadDataKendaraan();
                ResetForm();

            }
        }
    }
}
