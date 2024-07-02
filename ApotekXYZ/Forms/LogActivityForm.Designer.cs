namespace apotek_xyz_wf.Forms
{
    partial class LogActivityForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.InputTanggal = new System.Windows.Forms.DateTimePicker();
            this.ButtonLoad = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.TableLogs = new System.Windows.Forms.DataGridView();
            this.id_log = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableLogs)).BeginInit();
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
            this.label1.Text = "Log Activity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ButtonLoad);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.InputTanggal);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 56);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 12);
            this.panel1.Size = new System.Drawing.Size(921, 54);
            this.panel1.TabIndex = 14;
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
            this.label3.Text = "Tampilkan per";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(84, 12);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 30);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // InputTanggal
            // 
            this.InputTanggal.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputTanggal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputTanggal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InputTanggal.Location = new System.Drawing.Point(96, 12);
            this.InputTanggal.Name = "InputTanggal";
            this.InputTanggal.Size = new System.Drawing.Size(200, 29);
            this.InputTanggal.TabIndex = 24;
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
            this.ButtonLoad.Location = new System.Drawing.Point(308, 12);
            this.ButtonLoad.Name = "ButtonLoad";
            this.ButtonLoad.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonLoad.Size = new System.Drawing.Size(120, 30);
            this.ButtonLoad.TabIndex = 25;
            this.ButtonLoad.Text = "LOAD";
            this.ButtonLoad.UseVisualStyleBackColor = false;
            this.ButtonLoad.Click += new System.EventHandler(this.ButtonLoadClick);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(296, 12);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(12, 30);
            this.splitter2.TabIndex = 26;
            this.splitter2.TabStop = false;
            // 
            // TableLogs
            // 
            this.TableLogs.AllowUserToAddRows = false;
            this.TableLogs.AllowUserToDeleteRows = false;
            this.TableLogs.AllowUserToResizeRows = false;
            this.TableLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableLogs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TableLogs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TableLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_log,
            this.username,
            this.waktu,
            this.aktivitas});
            this.TableLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.TableLogs.Location = new System.Drawing.Point(6, 110);
            this.TableLogs.MultiSelect = false;
            this.TableLogs.Name = "TableLogs";
            this.TableLogs.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableLogs.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.TableLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableLogs.Size = new System.Drawing.Size(921, 300);
            this.TableLogs.TabIndex = 15;
            // 
            // id_log
            // 
            this.id_log.HeaderText = "ID log";
            this.id_log.Name = "id_log";
            this.id_log.ReadOnly = true;
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
            // LogActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.TableLogs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogActivityForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "LogActivityForm";
            this.Load += new System.EventHandler(this.LogActivityFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonLoad;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DateTimePicker InputTanggal;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TableLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_log;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivitas;
    }
}