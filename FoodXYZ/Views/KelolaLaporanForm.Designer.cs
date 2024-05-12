namespace FoodXYZ.Views
{
    partial class KelolaLaporanForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InpTanggalAwal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.InpTanggalAkhir = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButFilter = new System.Windows.Forms.Button();
            this.TabTransaksi = new System.Windows.Forms.DataGridView();
            this.NoTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TglTransaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamaKasir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChaOmset = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButGetChart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChaOmset)).BeginInit();
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
            this.label1.Text = "Kelola Laporan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButFilter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.InpTanggalAkhir);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.InpTanggalAwal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.panel1.Size = new System.Drawing.Size(768, 41);
            this.panel1.TabIndex = 2;
            // 
            // InpTanggalAwal
            // 
            this.InpTanggalAwal.Dock = System.Windows.Forms.DockStyle.Left;
            this.InpTanggalAwal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InpTanggalAwal.Location = new System.Drawing.Point(0, 0);
            this.InpTanggalAwal.Name = "InpTanggalAwal";
            this.InpTanggalAwal.Size = new System.Drawing.Size(128, 29);
            this.InpTanggalAwal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(128, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "sampai";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InpTanggalAkhir
            // 
            this.InpTanggalAkhir.Dock = System.Windows.Forms.DockStyle.Left;
            this.InpTanggalAkhir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InpTanggalAkhir.Location = new System.Drawing.Point(192, 0);
            this.InpTanggalAkhir.Name = "InpTanggalAkhir";
            this.InpTanggalAkhir.Size = new System.Drawing.Size(122, 29);
            this.InpTanggalAkhir.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(314, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 29);
            this.panel2.TabIndex = 9;
            // 
            // ButFilter
            // 
            this.ButFilter.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButFilter.FlatAppearance.BorderSize = 0;
            this.ButFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButFilter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButFilter.Location = new System.Drawing.Point(320, 0);
            this.ButFilter.Name = "ButFilter";
            this.ButFilter.Size = new System.Drawing.Size(121, 29);
            this.ButFilter.TabIndex = 10;
            this.ButFilter.Text = "Filter";
            this.ButFilter.UseVisualStyleBackColor = false;
            this.ButFilter.Click += new System.EventHandler(this.ButFilterClick);
            // 
            // TabTransaksi
            // 
            this.TabTransaksi.AllowUserToAddRows = false;
            this.TabTransaksi.AllowUserToDeleteRows = false;
            this.TabTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoTransaksi,
            this.TglTransaksi,
            this.TotalBayar,
            this.NamaKasir});
            this.TabTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabTransaksi.Location = new System.Drawing.Point(0, 85);
            this.TabTransaksi.MultiSelect = false;
            this.TabTransaksi.Name = "TabTransaksi";
            this.TabTransaksi.ReadOnly = true;
            this.TabTransaksi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TabTransaksi.Size = new System.Drawing.Size(768, 186);
            this.TabTransaksi.TabIndex = 3;
            // 
            // NoTransaksi
            // 
            this.NoTransaksi.HeaderText = "No Transaksi";
            this.NoTransaksi.Name = "NoTransaksi";
            this.NoTransaksi.ReadOnly = true;
            // 
            // TglTransaksi
            // 
            this.TglTransaksi.HeaderText = "Tanggal Transaksi";
            this.TglTransaksi.Name = "TglTransaksi";
            this.TglTransaksi.ReadOnly = true;
            // 
            // TotalBayar
            // 
            this.TotalBayar.HeaderText = "Total Bayar";
            this.TotalBayar.Name = "TotalBayar";
            this.TotalBayar.ReadOnly = true;
            // 
            // NamaKasir
            // 
            this.NamaKasir.HeaderText = "Nama Kasir";
            this.NamaKasir.Name = "NamaKasir";
            this.NamaKasir.ReadOnly = true;
            // 
            // ChaOmset
            // 
            chartArea4.Name = "ChartArea1";
            this.ChaOmset.ChartAreas.Add(chartArea4);
            this.ChaOmset.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.ChaOmset.Legends.Add(legend4);
            this.ChaOmset.Location = new System.Drawing.Point(0, 271);
            this.ChaOmset.Name = "ChaOmset";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Omset";
            this.ChaOmset.Series.Add(series4);
            this.ChaOmset.Size = new System.Drawing.Size(768, 209);
            this.ChaOmset.TabIndex = 4;
            this.ChaOmset.Text = "chart1";
            // 
            // ButGetChart
            // 
            this.ButGetChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButGetChart.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButGetChart.FlatAppearance.BorderSize = 0;
            this.ButGetChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButGetChart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButGetChart.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButGetChart.Location = new System.Drawing.Point(661, 439);
            this.ButGetChart.Name = "ButGetChart";
            this.ButGetChart.Size = new System.Drawing.Size(95, 29);
            this.ButGetChart.TabIndex = 11;
            this.ButGetChart.Text = "Generate";
            this.ButGetChart.UseVisualStyleBackColor = false;
            this.ButGetChart.Click += new System.EventHandler(this.ButGetChartClick);
            // 
            // KelolaLaporanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(768, 480);
            this.Controls.Add(this.ButGetChart);
            this.Controls.Add(this.ChaOmset);
            this.Controls.Add(this.TabTransaksi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KelolaLaporanForm";
            this.Text = "Kelola Log Aktivitas";
            this.Load += new System.EventHandler(this.KelolaLaporanFormLoad);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChaOmset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker InpTanggalAwal;
        private System.Windows.Forms.DateTimePicker InpTanggalAkhir;
        private System.Windows.Forms.Button ButFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView TabTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TglTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaKasir;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChaOmset;
        private System.Windows.Forms.Button ButGetChart;
    }
}