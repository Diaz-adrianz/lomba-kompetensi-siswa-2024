namespace FoodXYZ.Views
{
    partial class KelolaUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SelTipeUser = new System.Windows.Forms.ComboBox();
            this.InpAlamat = new System.Windows.Forms.TextBox();
            this.InpNama = new System.Windows.Forms.TextBox();
            this.InpUsername = new System.Windows.Forms.TextBox();
            this.InpTelpon = new System.Windows.Forms.TextBox();
            this.InpPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InpSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ButHapus = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ButEdit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButTambah = new System.Windows.Forms.Button();
            this.TabUsers = new System.Windows.Forms.DataGridView();
            this.IdUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipeUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(768, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelola Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.SelTipeUser, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.InpAlamat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.InpNama, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.InpUsername, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.InpTelpon, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.InpPassword, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(768, 154);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipe User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Alamat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Telepon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Password";
            // 
            // SelTipeUser
            // 
            this.SelTipeUser.DisplayMember = "TipeUser";
            this.SelTipeUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelTipeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelTipeUser.FormattingEnabled = true;
            this.SelTipeUser.Location = new System.Drawing.Point(3, 23);
            this.SelTipeUser.Name = "SelTipeUser";
            this.SelTipeUser.Size = new System.Drawing.Size(378, 25);
            this.SelTipeUser.TabIndex = 6;
            this.SelTipeUser.ValueMember = "TipeUser";
            // 
            // InpAlamat
            // 
            this.InpAlamat.Dock = System.Windows.Forms.DockStyle.Top;
            this.InpAlamat.Location = new System.Drawing.Point(387, 23);
            this.InpAlamat.MaxLength = 150;
            this.InpAlamat.Name = "InpAlamat";
            this.InpAlamat.Size = new System.Drawing.Size(378, 25);
            this.InpAlamat.TabIndex = 7;
            // 
            // InpNama
            // 
            this.InpNama.Dock = System.Windows.Forms.DockStyle.Top;
            this.InpNama.Location = new System.Drawing.Point(3, 73);
            this.InpNama.MaxLength = 50;
            this.InpNama.Name = "InpNama";
            this.InpNama.Size = new System.Drawing.Size(378, 25);
            this.InpNama.TabIndex = 8;
            // 
            // InpUsername
            // 
            this.InpUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.InpUsername.Location = new System.Drawing.Point(387, 73);
            this.InpUsername.MaxLength = 50;
            this.InpUsername.Name = "InpUsername";
            this.InpUsername.Size = new System.Drawing.Size(378, 25);
            this.InpUsername.TabIndex = 9;
            // 
            // InpTelpon
            // 
            this.InpTelpon.Dock = System.Windows.Forms.DockStyle.Top;
            this.InpTelpon.Location = new System.Drawing.Point(3, 123);
            this.InpTelpon.MaxLength = 50;
            this.InpTelpon.Name = "InpTelpon";
            this.InpTelpon.Size = new System.Drawing.Size(378, 25);
            this.InpTelpon.TabIndex = 10;
            // 
            // InpPassword
            // 
            this.InpPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.InpPassword.Location = new System.Drawing.Point(387, 123);
            this.InpPassword.MaxLength = 50;
            this.InpPassword.Name = "InpPassword";
            this.InpPassword.Size = new System.Drawing.Size(378, 25);
            this.InpPassword.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InpSearch);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.ButHapus);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.ButEdit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ButTambah);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 198);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.panel1.Size = new System.Drawing.Size(768, 46);
            this.panel1.TabIndex = 2;
            // 
            // InpSearch
            // 
            this.InpSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InpSearch.Location = new System.Drawing.Point(442, 6);
            this.InpSearch.MaxLength = 50;
            this.InpSearch.Name = "InpSearch";
            this.InpSearch.Size = new System.Drawing.Size(326, 25);
            this.InpSearch.TabIndex = 15;
            this.InpSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InpSearch_KeyDown);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(378, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 34);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cari user";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(372, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 34);
            this.panel4.TabIndex = 9;
            // 
            // ButHapus
            // 
            this.ButHapus.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButHapus.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButHapus.FlatAppearance.BorderSize = 0;
            this.ButHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButHapus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButHapus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButHapus.Location = new System.Drawing.Point(252, 6);
            this.ButHapus.Name = "ButHapus";
            this.ButHapus.Size = new System.Drawing.Size(120, 34);
            this.ButHapus.TabIndex = 14;
            this.ButHapus.Text = "Hapus";
            this.ButHapus.UseVisualStyleBackColor = false;
            this.ButHapus.Click += new System.EventHandler(this.ButHapusClick);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(246, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 34);
            this.panel3.TabIndex = 7;
            // 
            // ButEdit
            // 
            this.ButEdit.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButEdit.FlatAppearance.BorderSize = 0;
            this.ButEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButEdit.Location = new System.Drawing.Point(126, 6);
            this.ButEdit.Name = "ButEdit";
            this.ButEdit.Size = new System.Drawing.Size(120, 34);
            this.ButEdit.TabIndex = 13;
            this.ButEdit.Text = "Edit";
            this.ButEdit.UseVisualStyleBackColor = false;
            this.ButEdit.Click += new System.EventHandler(this.ButEditClick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(120, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 34);
            this.panel2.TabIndex = 5;
            // 
            // ButTambah
            // 
            this.ButTambah.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButTambah.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButTambah.FlatAppearance.BorderSize = 0;
            this.ButTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButTambah.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButTambah.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButTambah.Location = new System.Drawing.Point(0, 6);
            this.ButTambah.Name = "ButTambah";
            this.ButTambah.Size = new System.Drawing.Size(120, 34);
            this.ButTambah.TabIndex = 12;
            this.ButTambah.Text = "Tambah";
            this.ButTambah.UseVisualStyleBackColor = false;
            this.ButTambah.Click += new System.EventHandler(this.ButTambahClick);
            // 
            // TabUsers
            // 
            this.TabUsers.AllowUserToAddRows = false;
            this.TabUsers.AllowUserToDeleteRows = false;
            this.TabUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUser,
            this.TipeUser,
            this.Nama,
            this.Alamat,
            this.Telpon});
            this.TabUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabUsers.Location = new System.Drawing.Point(0, 244);
            this.TabUsers.MultiSelect = false;
            this.TabUsers.Name = "TabUsers";
            this.TabUsers.ReadOnly = true;
            this.TabUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TabUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabUsers.Size = new System.Drawing.Size(768, 236);
            this.TabUsers.TabIndex = 3;
            this.TabUsers.SelectionChanged += new System.EventHandler(this.TabUsersSelect);
            // 
            // IdUser
            // 
            this.IdUser.HeaderText = "ID User";
            this.IdUser.Name = "IdUser";
            this.IdUser.ReadOnly = true;
            // 
            // TipeUser
            // 
            this.TipeUser.HeaderText = "Tipe User";
            this.TipeUser.Name = "TipeUser";
            this.TipeUser.ReadOnly = true;
            // 
            // Nama
            // 
            this.Nama.HeaderText = "Nama User";
            this.Nama.Name = "Nama";
            this.Nama.ReadOnly = true;
            // 
            // Alamat
            // 
            this.Alamat.HeaderText = "Alamat";
            this.Alamat.Name = "Alamat";
            this.Alamat.ReadOnly = true;
            // 
            // Telpon
            // 
            this.Telpon.HeaderText = "Telepon";
            this.Telpon.Name = "Telpon";
            this.Telpon.ReadOnly = true;
            // 
            // KelolaUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 480);
            this.Controls.Add(this.TabUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KelolaUserForm";
            this.Text = "Kelola Log Aktivitas";
            this.Load += new System.EventHandler(this.KelolaUserFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox SelTipeUser;
        private System.Windows.Forms.TextBox InpAlamat;
        private System.Windows.Forms.TextBox InpNama;
        private System.Windows.Forms.TextBox InpUsername;
        private System.Windows.Forms.TextBox InpTelpon;
        private System.Windows.Forms.TextBox InpPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButTambah;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button ButHapus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ButEdit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox InpSearch;
        private System.Windows.Forms.DataGridView TabUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipeUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telpon;
    }
}