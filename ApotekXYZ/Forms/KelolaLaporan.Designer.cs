namespace apotek_xyz_wf.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.InputTanggalEnd = new System.Windows.Forms.DateTimePicker();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.InputTanggalStart = new System.Windows.Forms.DateTimePicker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label3 = new System.Windows.Forms.Label();
            this.TableTransaksi = new System.Windows.Forms.DataGridView();
            this.tgl_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_bayar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChartTransaksi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ButtonGenerateChart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTransaksi)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(921, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelola Laporan";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonLoad);
            this.panel1.Controls.Add(this.splitter4);
            this.panel1.Controls.Add(this.InputTanggalEnd);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.InputTanggalStart);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 56);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel1.Size = new System.Drawing.Size(921, 54);
            this.panel1.TabIndex = 15;
            // 
            // ButtonLoad
            // 
            this.ButtonLoad.AutoSize = true;
            this.ButtonLoad.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonLoad.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonLoad.FlatAppearance.BorderSize = 0;
            this.ButtonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLoad.Location = new System.Drawing.Point(552, 12);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonLoad.Size = new System.Drawing.Size(120, 30);
            this.ButtonLoad.TabIndex = 34;
            this.ButtonLoad.Text = "LOAD";
            this.ButtonLoad.UseVisualStyleBackColor = false;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoadClick);
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(540, 12);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(12, 30);
            this.splitter4.TabIndex = 33;
            this.splitter4.TabStop = false;
            // 
            // InputTanggalEnd
            // 
            this.InputTanggalEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputTanggalEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTanggalEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InputTanggalEnd.Location = new System.Drawing.Point(375, 12);
            this.InputTanggalEnd.Name = "InputTanggalEnd";
            this.InputTanggalEnd.Size = new System.Drawing.Size(165, 29);
            this.InputTanggalEnd.TabIndex = 32;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(363, 12);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(12, 30);
            this.splitter3.TabIndex = 31;
            this.splitter3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 12);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Size = new System.Drawing.Size(90, 30);
            this.label2.TabIndex = 30;
            this.label2.Text = "Sampai tanggal";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(261, 12);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(12, 30);
            this.splitter2.TabIndex = 26;
            this.splitter2.TabStop = false;
            // 
            // InputTanggalStart
            // 
            this.InputTanggalStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputTanggalStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTanggalStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InputTanggalStart.Location = new System.Drawing.Point(96, 12);
            this.InputTanggalStart.Name = "InputTanggalStart";
            this.InputTanggalStart.Size = new System.Drawing.Size(165, 29);
            this.InputTanggalStart.TabIndex = 24;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(84, 12);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 30);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 12);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label3.Size = new System.Drawing.Size(84, 30);
            this.label3.TabIndex = 22;
            this.label3.Text = "Dari tanggal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TableTransaksi
            // 
            this.TableTransaksi.AllowUserToAddRows = false;
            this.TableTransaksi.AllowUserToDeleteRows = false;
            this.TableTransaksi.AllowUserToResizeRows = false;
            this.TableTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableTransaksi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableTransaksi.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tgl_transaksi,
            this.total_bayar});
            this.TableTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableTransaksi.Location = new System.Drawing.Point(6, 110);
            this.TableTransaksi.MultiSelect = false;
            this.TableTransaksi.Name = "TableTransaksi";
            this.TableTransaksi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableTransaksi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableTransaksi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.TableTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableTransaksi.Size = new System.Drawing.Size(921, 130);
            this.TableTransaksi.TabIndex = 16;
            // 
            // tgl_transaksi
            // 
            this.tgl_transaksi.HeaderText = "Tanggal transaksi";
            this.tgl_transaksi.Name = "tgl_transaksi";
            this.tgl_transaksi.ReadOnly = true;
            // 
            // total_bayar
            // 
            this.total_bayar.HeaderText = "Total bayar";
            this.total_bayar.Name = "total_bayar";
            this.total_bayar.ReadOnly = true;
            // 
            // ChartTransaksi
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartTransaksi.ChartAreas.Add(chartArea2);
            this.ChartTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.ChartTransaksi.Legends.Add(legend2);
            this.ChartTransaksi.Location = new System.Drawing.Point(6, 240);
            this.ChartTransaksi.Name = "ChartTransaksi";
            this.ChartTransaksi.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Omset";
            this.ChartTransaksi.Series.Add(series2);
            this.ChartTransaksi.Size = new System.Drawing.Size(921, 300);
            this.ChartTransaksi.TabIndex = 17;
            this.ChartTransaksi.Text = "ChartTransaksi";
            // 
            // ButtonGenerateChart
            // 
            this.ButtonGenerateChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonGenerateChart.AutoSize = true;
            this.ButtonGenerateChart.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonGenerateChart.FlatAppearance.BorderSize = 0;
            this.ButtonGenerateChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGenerateChart.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerateChart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonGenerateChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGenerateChart.Location = new System.Drawing.Point(817, 284);
            this.ButtonGenerateChart.Name = "ButtonGenerateChart";
            this.ButtonGenerateChart.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonGenerateChart.Size = new System.Drawing.Size(97, 33);
            this.ButtonGenerateChart.TabIndex = 35;
            this.ButtonGenerateChart.Text = "GENERATE";
            this.ButtonGenerateChart.UseVisualStyleBackColor = false;
            this.ButtonGenerateChart.Click += new System.EventHandler(this.ButtonGenerateChartClick);
            // 
            // KelolaLaporanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.ButtonGenerateChart);
            this.Controls.Add(this.ChartTransaksi);
            this.Controls.Add(this.TableTransaksi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KelolaLaporanForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "LogActivityForm";
            this.Load += new System.EventHandler(this.KelolaLaporanFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DateTimePicker InputTanggalStart;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker InputTanggalEnd;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.DataGridView TableTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_bayar;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTransaksi;
        private System.Windows.Forms.Button ButtonGenerateChart;
    }
}