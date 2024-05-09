namespace CurrencyConverter
{
    partial class CurrencyConverterForm
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
            this.SelPeriod = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabOriginCurr = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SelOriginCurr = new System.Windows.Forms.ComboBox();
            this.InpOriginAm = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.SelTargetCurr = new System.Windows.Forms.ComboBox();
            this.InpTargetAm = new System.Windows.Forms.TextBox();
            this.LabTargetCurr = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButSwap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Currency Converter (2023)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SelPeriod);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(24, 68);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 16, 0, 16);
            this.panel1.Size = new System.Drawing.Size(536, 55);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Period";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelPeriod
            // 
            this.SelPeriod.DisplayMember = "name";
            this.SelPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelPeriod.FormattingEnabled = true;
            this.SelPeriod.Location = new System.Drawing.Point(89, 16);
            this.SelPeriod.Name = "SelPeriod";
            this.SelPeriod.Size = new System.Drawing.Size(447, 25);
            this.SelPeriod.TabIndex = 1;
            this.SelPeriod.ValueMember = "id";
            this.SelPeriod.SelectedValueChanged += new System.EventHandler(this.SelPeriodValChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 123);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(536, 114);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.LabOriginCurr);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(16, 0, 16, 6);
            this.groupBox1.Size = new System.Drawing.Size(208, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origin Amount:";
            // 
            // LabOriginCurr
            // 
            this.LabOriginCurr.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabOriginCurr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabOriginCurr.Location = new System.Drawing.Point(16, 18);
            this.LabOriginCurr.Name = "LabOriginCurr";
            this.LabOriginCurr.Size = new System.Drawing.Size(176, 38);
            this.LabOriginCurr.TabIndex = 1;
            this.LabOriginCurr.Text = "Origin";
            this.LabOriginCurr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel2.Controls.Add(this.SelOriginCurr, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.InpOriginAm, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(176, 46);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // SelOriginCurr
            // 
            this.SelOriginCurr.DisplayMember = "abbreviation";
            this.SelOriginCurr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelOriginCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelOriginCurr.FormattingEnabled = true;
            this.SelOriginCurr.Location = new System.Drawing.Point(116, 3);
            this.SelOriginCurr.Name = "SelOriginCurr";
            this.SelOriginCurr.Size = new System.Drawing.Size(57, 25);
            this.SelOriginCurr.TabIndex = 0;
            this.SelOriginCurr.ValueMember = "id";
            this.SelOriginCurr.SelectedValueChanged += new System.EventHandler(this.SelOriginCurrValChanged);
            // 
            // InpOriginAm
            // 
            this.InpOriginAm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InpOriginAm.Location = new System.Drawing.Point(3, 3);
            this.InpOriginAm.Name = "InpOriginAm";
            this.InpOriginAm.Size = new System.Drawing.Size(107, 25);
            this.InpOriginAm.TabIndex = 1;
            this.InpOriginAm.TextChanged += new System.EventHandler(this.InpOriginAmTextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Controls.Add(this.LabTargetCurr);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(324, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(16, 0, 16, 6);
            this.groupBox2.Size = new System.Drawing.Size(209, 108);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Converted to:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
            this.tableLayoutPanel3.Controls.Add(this.SelTargetCurr, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.InpTargetAm, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 56);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(177, 46);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // SelTargetCurr
            // 
            this.SelTargetCurr.DisplayMember = "abbreviation";
            this.SelTargetCurr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelTargetCurr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelTargetCurr.FormattingEnabled = true;
            this.SelTargetCurr.Location = new System.Drawing.Point(116, 3);
            this.SelTargetCurr.Name = "SelTargetCurr";
            this.SelTargetCurr.Size = new System.Drawing.Size(58, 25);
            this.SelTargetCurr.TabIndex = 0;
            this.SelTargetCurr.ValueMember = "id";
            this.SelTargetCurr.SelectedValueChanged += new System.EventHandler(this.SelTargetCurrValChanged);
            // 
            // InpTargetAm
            // 
            this.InpTargetAm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InpTargetAm.Enabled = false;
            this.InpTargetAm.Location = new System.Drawing.Point(3, 3);
            this.InpTargetAm.Name = "InpTargetAm";
            this.InpTargetAm.Size = new System.Drawing.Size(107, 25);
            this.InpTargetAm.TabIndex = 1;
            // 
            // LabTargetCurr
            // 
            this.LabTargetCurr.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabTargetCurr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabTargetCurr.Location = new System.Drawing.Point(16, 18);
            this.LabTargetCurr.Name = "LabTargetCurr";
            this.LabTargetCurr.Size = new System.Drawing.Size(177, 38);
            this.LabTargetCurr.TabIndex = 1;
            this.LabTargetCurr.Text = "Target";
            this.LabTargetCurr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.ButSwap);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(217, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(24);
            this.panel2.Size = new System.Drawing.Size(101, 108);
            this.panel2.TabIndex = 2;
            // 
            // ButSwap
            // 
            this.ButSwap.BackgroundImage = global::CurrencyConverter.Properties.Resources.exchange;
            this.ButSwap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButSwap.Location = new System.Drawing.Point(24, 24);
            this.ButSwap.Name = "ButSwap";
            this.ButSwap.Size = new System.Drawing.Size(53, 60);
            this.ButSwap.TabIndex = 0;
            this.ButSwap.UseVisualStyleBackColor = true;
            this.ButSwap.Click += new System.EventHandler(this.ButSwapClick);
            // 
            // CurrencyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CurrencyConverterForm";
            this.Padding = new System.Windows.Forms.Padding(24);
            this.Text = "Currency Converter (2023)";
            this.Load += new System.EventHandler(this.CurrencyConverterFormLoad);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelPeriod;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabOriginCurr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox SelOriginCurr;
        private System.Windows.Forms.TextBox InpOriginAm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox SelTargetCurr;
        private System.Windows.Forms.TextBox InpTargetAm;
        private System.Windows.Forms.Label LabTargetCurr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ButSwap;
    }
}