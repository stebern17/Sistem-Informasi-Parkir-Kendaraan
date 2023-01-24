namespace SistemParkir.View
{
    partial class MenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            this.button4 = new System.Windows.Forms.Button();
            this.lvwKendaraan = new System.Windows.Forms.ListView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoKarcis = new System.Windows.Forms.TextBox();
            this.btnTambahData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.txtAreaParkir = new System.Windows.Forms.TextBox();
            this.textPlatKendaraan = new System.Windows.Forms.TextBox();
            this.txtReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(365, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 48);
            this.button4.TabIndex = 31;
            this.button4.Text = "Tampil Data";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lvwKendaraan
            // 
            this.lvwKendaraan.HideSelection = false;
            this.lvwKendaraan.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.lvwKendaraan.Location = new System.Drawing.Point(73, 250);
            this.lvwKendaraan.Name = "lvwKendaraan";
            this.lvwKendaraan.Size = new System.Drawing.Size(1223, 325);
            this.lvwKendaraan.TabIndex = 30;
            this.lvwKendaraan.UseCompatibleStateImageBehavior = false;
            this.lvwKendaraan.SelectedIndexChanged += new System.EventHandler(this.lvwKendaraan_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(838, 89);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 48);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(741, 89);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(91, 48);
            this.btnHapus.TabIndex = 28;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(738, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "No Karcis";
            // 
            // txtNoKarcis
            // 
            this.txtNoKarcis.Enabled = false;
            this.txtNoKarcis.Location = new System.Drawing.Point(741, 51);
            this.txtNoKarcis.Name = "txtNoKarcis";
            this.txtNoKarcis.Size = new System.Drawing.Size(380, 22);
            this.txtNoKarcis.TabIndex = 24;
            // 
            // btnTambahData
            // 
            this.btnTambahData.Location = new System.Drawing.Point(365, 51);
            this.btnTambahData.Name = "btnTambahData";
            this.btnTambahData.Size = new System.Drawing.Size(91, 48);
            this.btnTambahData.TabIndex = 23;
            this.btnTambahData.Text = "Input";
            this.btnTambahData.UseVisualStyleBackColor = true;
            this.btnTambahData.Click += new System.EventHandler(this.btnTambahData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Area Parkir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Plat Nomer";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 204);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // txtNominal
            // 
            this.txtNominal.Location = new System.Drawing.Point(73, 157);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(238, 22);
            this.txtNominal.TabIndex = 18;
            // 
            // txtAreaParkir
            // 
            this.txtAreaParkir.Location = new System.Drawing.Point(73, 102);
            this.txtAreaParkir.Name = "txtAreaParkir";
            this.txtAreaParkir.Size = new System.Drawing.Size(238, 22);
            this.txtAreaParkir.TabIndex = 17;
            // 
            // textPlatKendaraan
            // 
            this.textPlatKendaraan.Location = new System.Drawing.Point(73, 51);
            this.textPlatKendaraan.Name = "textPlatKendaraan";
            this.textPlatKendaraan.Size = new System.Drawing.Size(238, 22);
            this.textPlatKendaraan.TabIndex = 16;
            // 
            // txtReset
            // 
            this.txtReset.Location = new System.Drawing.Point(935, 89);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(91, 48);
            this.txtReset.TabIndex = 32;
            this.txtReset.Text = "Reset";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 607);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lvwKendaraan);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNoKarcis);
            this.Controls.Add(this.btnTambahData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtNominal);
            this.Controls.Add(this.txtAreaParkir);
            this.Controls.Add(this.textPlatKendaraan);
            this.Name = "MenuUtama";
            this.Text = "MenuUtama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListView lvwKendaraan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoKarcis;
        private System.Windows.Forms.Button btnTambahData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.TextBox txtAreaParkir;
        private System.Windows.Forms.TextBox textPlatKendaraan;
        private System.Windows.Forms.Button txtReset;
    }
}