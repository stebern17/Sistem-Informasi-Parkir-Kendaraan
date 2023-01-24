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

namespace SistemParkir.View
{
    public partial class Login : Form
    {
        private UserController controller = new UserController();
        public string IdPetugas { get; set; }
        public Login()
        {
            InitializeComponent();

            txtPetugas.Text = "7777";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (controller.IsValidUser(txtPetugas.Text)) {
                this.DialogResult = DialogResult.OK;
                IdPetugas= txtPetugas.Text;
                this.Close();
            }
        }
    }
}
