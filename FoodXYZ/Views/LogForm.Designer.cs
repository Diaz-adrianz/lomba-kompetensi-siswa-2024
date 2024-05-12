namespace FoodXYZ.Views
{
    partial class LogForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ButFilter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.InpTanggal = new System.Windows.Forms.DateTimePicker();
            this.TabLogs = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabLogs)).BeginInit();
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
            this.label1.Text = "Log Aktivitas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InpTanggal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ButFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.panel1.Size = new System.Drawing.Size(768, 41);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pilih Tanggal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButFilter
            // 
            this.ButFilter.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButFilter.FlatAppearance.BorderSize = 0;
            this.ButFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButFilter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButFilter.Location = new System.Drawing.Point(647, 0);
            this.ButFilter.Name = "ButFilter";
            this.ButFilter.Size = new System.Drawing.Size(121, 29);
            this.ButFilter.TabIndex = 4;
            this.ButFilter.Text = "Filter";
            this.ButFilter.UseVisualStyleBackColor = false;
            this.ButFilter.Click += new System.EventHandler(this.ButFilterClick);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(641, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 29);
            this.panel2.TabIndex = 5;
            // 
            // InpTanggal
            // 
            this.InpTanggal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InpTanggal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InpTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InpTanggal.Location = new System.Drawing.Point(112, 0);
            this.InpTanggal.Name = "InpTanggal";
            this.InpTanggal.Size = new System.Drawing.Size(529, 29);
            this.InpTanggal.TabIndex = 6;
            // 
            // TabLogs
            // 
            this.TabLogs.AllowUserToAddRows = false;
            this.TabLogs.AllowUserToDeleteRows = false;
            this.TabLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.username,
            this.waktu,
            this.aktivitas});
            this.TabLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabLogs.Location = new System.Drawing.Point(0, 85);
            this.TabLogs.MultiSelect = false;
            this.TabLogs.Name = "TabLogs";
            this.TabLogs.ReadOnly = true;
            this.TabLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TabLogs.Size = new System.Drawing.Size(768, 395);
            this.TabLogs.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "ID Log";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // waktu
            // 
            this.waktu.HeaderText = "Waktu";
            this.waktu.Name = "waktu";
            this.waktu.ReadOnly = true;
            // 
            // aktivitas
            // 
            this.aktivitas.HeaderText = "Aktivitas";
            this.aktivitas.Name = "aktivitas";
            this.aktivitas.ReadOnly = true;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 480);
            this.Controls.Add(this.TabLogs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogForm";
            this.Text = "Kelola Log Aktivitas";
            this.Load += new System.EventHandler(this.LogFormLoad);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker InpTanggal;
        private System.Windows.Forms.DataGridView TabLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivitas;
    }
}