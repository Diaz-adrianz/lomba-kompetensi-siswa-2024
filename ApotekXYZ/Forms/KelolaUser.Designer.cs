namespace apotek_xyz_wf.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InputAlamat = new System.Windows.Forms.TextBox();
            this.InputNama = new System.Windows.Forms.TextBox();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.InputTelepon = new System.Windows.Forms.TextBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.SelectTipeUser = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.InputCari = new System.Windows.Forms.TextBox();
            this.ButtonHapus = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.ButtonTambah = new System.Windows.Forms.Button();
            this.TableUsers = new System.Windows.Forms.DataGridView();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipe_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telepon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label1.Size = new System.Drawing.Size(904, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelola User";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InputAlamat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.InputNama, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.InputUsername, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.InputTelepon, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.InputPassword, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.SelectTipeUser, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 56);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(904, 186);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(455, 124);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label8.Size = new System.Drawing.Size(446, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 124);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label7.Size = new System.Drawing.Size(446, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telepon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 62);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label6.Size = new System.Drawing.Size(446, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label5.Size = new System.Drawing.Size(446, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label4.Size = new System.Drawing.Size(446, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Size = new System.Drawing.Size(446, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tipe user";
            // 
            // InputAlamat
            // 
            this.InputAlamat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputAlamat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputAlamat.Location = new System.Drawing.Point(455, 23);
            this.InputAlamat.MaxLength = 150;
            this.InputAlamat.Name = "InputAlamat";
            this.InputAlamat.Size = new System.Drawing.Size(446, 29);
            this.InputAlamat.TabIndex = 3;
            // 
            // InputNama
            // 
            this.InputNama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputNama.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNama.Location = new System.Drawing.Point(3, 85);
            this.InputNama.MaxLength = 50;
            this.InputNama.Name = "InputNama";
            this.InputNama.Size = new System.Drawing.Size(446, 29);
            this.InputNama.TabIndex = 1;
            // 
            // InputUsername
            // 
            this.InputUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.Location = new System.Drawing.Point(455, 85);
            this.InputUsername.MaxLength = 50;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(446, 29);
            this.InputUsername.TabIndex = 4;
            // 
            // InputTelepon
            // 
            this.InputTelepon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputTelepon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTelepon.Location = new System.Drawing.Point(3, 147);
            this.InputTelepon.MaxLength = 50;
            this.InputTelepon.Name = "InputTelepon";
            this.InputTelepon.Size = new System.Drawing.Size(446, 29);
            this.InputTelepon.TabIndex = 2;
            // 
            // InputPassword
            // 
            this.InputPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InputPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.Location = new System.Drawing.Point(455, 147);
            this.InputPassword.MaxLength = 50;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.Size = new System.Drawing.Size(446, 29);
            this.InputPassword.TabIndex = 5;
            // 
            // SelectTipeUser
            // 
            this.SelectTipeUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectTipeUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectTipeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectTipeUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTipeUser.FormattingEnabled = true;
            this.SelectTipeUser.Location = new System.Drawing.Point(3, 23);
            this.SelectTipeUser.Name = "SelectTipeUser";
            this.SelectTipeUser.Size = new System.Drawing.Size(446, 29);
            this.SelectTipeUser.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.InputCari);
            this.panel1.Controls.Add(this.ButtonHapus);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.ButtonEdit);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.ButtonTambah);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 242);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel1.Size = new System.Drawing.Size(904, 60);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 12);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label3.Size = new System.Drawing.Size(58, 36);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cari";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter3.Location = new System.Drawing.Point(655, 12);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(12, 36);
            this.splitter3.TabIndex = 21;
            this.splitter3.TabStop = false;
            // 
            // InputCari
            // 
            this.InputCari.Dock = System.Windows.Forms.DockStyle.Right;
            this.InputCari.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputCari.Location = new System.Drawing.Point(667, 12);
            this.InputCari.MaxLength = 50;
            this.InputCari.Name = "InputCari";
            this.InputCari.Size = new System.Drawing.Size(237, 29);
            this.InputCari.TabIndex = 9;
            this.InputCari.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputCariKeyDown);
            // 
            // ButtonHapus
            // 
            this.ButtonHapus.AutoSize = true;
            this.ButtonHapus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonHapus.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonHapus.FlatAppearance.BorderSize = 0;
            this.ButtonHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHapus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHapus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonHapus.Location = new System.Drawing.Point(264, 12);
            this.ButtonHapus.Name = "ButtonHapus";
            this.ButtonHapus.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonHapus.Size = new System.Drawing.Size(120, 36);
            this.ButtonHapus.TabIndex = 8;
            this.ButtonHapus.Text = "HAPUS";
            this.ButtonHapus.UseVisualStyleBackColor = false;
            this.ButtonHapus.Click += new System.EventHandler(this.ButtonHapusClick);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(252, 12);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(12, 36);
            this.splitter2.TabIndex = 17;
            this.splitter2.TabStop = false;
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.AutoSize = true;
            this.ButtonEdit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonEdit.FlatAppearance.BorderSize = 0;
            this.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonEdit.Location = new System.Drawing.Point(132, 12);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonEdit.Size = new System.Drawing.Size(120, 36);
            this.ButtonEdit.TabIndex = 7;
            this.ButtonEdit.Text = "EDIT";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEditClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(120, 12);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 36);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // ButtonTambah
            // 
            this.ButtonTambah.AutoSize = true;
            this.ButtonTambah.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonTambah.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonTambah.FlatAppearance.BorderSize = 0;
            this.ButtonTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTambah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTambah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTambah.Location = new System.Drawing.Point(0, 12);
            this.ButtonTambah.Name = "ButtonTambah";
            this.ButtonTambah.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonTambah.Size = new System.Drawing.Size(120, 36);
            this.ButtonTambah.TabIndex = 6;
            this.ButtonTambah.Text = "TAMBAH";
            this.ButtonTambah.UseVisualStyleBackColor = false;
            this.ButtonTambah.Click += new System.EventHandler(this.ButtonTambahClick);
            // 
            // TableUsers
            // 
            this.TableUsers.AllowUserToAddRows = false;
            this.TableUsers.AllowUserToDeleteRows = false;
            this.TableUsers.AllowUserToResizeRows = false;
            this.TableUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_user,
            this.tipe_user,
            this.nama_user,
            this.alamat,
            this.telepon});
            this.TableUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableUsers.Location = new System.Drawing.Point(6, 302);
            this.TableUsers.MultiSelect = false;
            this.TableUsers.Name = "TableUsers";
            this.TableUsers.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableUsers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.TableUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableUsers.Size = new System.Drawing.Size(904, 300);
            this.TableUsers.TabIndex = 14;
            this.TableUsers.SelectionChanged += new System.EventHandler(this.TableUserOnSelect);
            // 
            // id_user
            // 
            this.id_user.HeaderText = "ID user";
            this.id_user.Name = "id_user";
            this.id_user.ReadOnly = true;
            // 
            // tipe_user
            // 
            this.tipe_user.HeaderText = "Tipe user";
            this.tipe_user.Name = "tipe_user";
            this.tipe_user.ReadOnly = true;
            // 
            // nama_user
            // 
            this.nama_user.HeaderText = "Nama user";
            this.nama_user.Name = "nama_user";
            this.nama_user.ReadOnly = true;
            // 
            // alamat
            // 
            this.alamat.HeaderText = "Alamat";
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            // 
            // telepon
            // 
            this.telepon.HeaderText = "Telepon";
            this.telepon.Name = "telepon";
            this.telepon.ReadOnly = true;
            // 
            // KelolaUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.TableUsers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KelolaUserForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "LogActivityForm";
            this.Load += new System.EventHandler(this.KelolaUserFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputAlamat;
        private System.Windows.Forms.TextBox InputNama;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.TextBox InputTelepon;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.ComboBox SelectTipeUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonHapus;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button ButtonTambah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.TextBox InputCari;
        private System.Windows.Forms.DataGridView TableUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipe_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn telepon;
    }
}