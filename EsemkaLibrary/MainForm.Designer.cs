namespace EsemkaLibrary
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.InpSearchMember = new System.Windows.Forms.TextBox();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TblBorrowing = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnNewBorrow = new System.Windows.Forms.Button();
            this.LblDatetime = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrow_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overdue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TblBorrowing)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESEMKA Library Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(24, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(16, 3, 16, 3);
            this.groupBox1.Size = new System.Drawing.Size(656, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member Data";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.60365F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.39635F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.InpSearchMember, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnSearchMember, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InpSearchMember
            // 
            this.InpSearchMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InpSearchMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InpSearchMember.Location = new System.Drawing.Point(70, 3);
            this.InpSearchMember.MaxLength = 200;
            this.InpSearchMember.Name = "InpSearchMember";
            this.InpSearchMember.Size = new System.Drawing.Size(464, 29);
            this.InpSearchMember.TabIndex = 1;
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSearchMember.Location = new System.Drawing.Point(540, 3);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(81, 29);
            this.BtnSearchMember.TabIndex = 2;
            this.BtnSearchMember.Text = "Search";
            this.BtnSearchMember.UseVisualStyleBackColor = true;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMemberClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TblBorrowing);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(24, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(656, 140);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrowing Data";
            // 
            // TblBorrowing
            // 
            this.TblBorrowing.AllowUserToAddRows = false;
            this.TblBorrowing.AllowUserToDeleteRows = false;
            this.TblBorrowing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TblBorrowing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TblBorrowing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title,
            this.borrow_date,
            this.due_date,
            this.overdue,
            this.action});
            this.TblBorrowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TblBorrowing.Location = new System.Drawing.Point(3, 21);
            this.TblBorrowing.MultiSelect = false;
            this.TblBorrowing.Name = "TblBorrowing";
            this.TblBorrowing.ReadOnly = true;
            this.TblBorrowing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TblBorrowing.Size = new System.Drawing.Size(650, 116);
            this.TblBorrowing.TabIndex = 0;
            this.TblBorrowing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TblBorrowingCellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblDatetime);
            this.panel1.Controls.Add(this.BtnNewBorrow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(24, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 29);
            this.panel1.TabIndex = 3;
            // 
            // BtnNewBorrow
            // 
            this.BtnNewBorrow.AutoSize = true;
            this.BtnNewBorrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnNewBorrow.Enabled = false;
            this.BtnNewBorrow.Location = new System.Drawing.Point(0, 0);
            this.BtnNewBorrow.Name = "BtnNewBorrow";
            this.BtnNewBorrow.Size = new System.Drawing.Size(108, 29);
            this.BtnNewBorrow.TabIndex = 0;
            this.BtnNewBorrow.Text = "New Borrowing";
            this.BtnNewBorrow.UseVisualStyleBackColor = true;
            this.BtnNewBorrow.Click += new System.EventHandler(this.BtnNewBorrowClick);
            // 
            // LblDatetime
            // 
            this.LblDatetime.Dock = System.Windows.Forms.DockStyle.Right;
            this.LblDatetime.Location = new System.Drawing.Point(270, 0);
            this.LblDatetime.Name = "LblDatetime";
            this.LblDatetime.Size = new System.Drawing.Size(386, 29);
            this.LblDatetime.TabIndex = 1;
            this.LblDatetime.Text = "No date";
            this.LblDatetime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // borrow_date
            // 
            this.borrow_date.HeaderText = "Borrow Date";
            this.borrow_date.Name = "borrow_date";
            this.borrow_date.ReadOnly = true;
            // 
            // due_date
            // 
            this.due_date.HeaderText = "Due Date";
            this.due_date.Name = "due_date";
            this.due_date.ReadOnly = true;
            // 
            // overdue
            // 
            this.overdue.HeaderText = "Overdue Day(s)";
            this.overdue.Name = "overdue";
            this.overdue.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Text = "Return";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(720, 360);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(24, 0, 24, 24);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESEMKA Library";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TblBorrowing)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InpSearchMember;
        private System.Windows.Forms.Button BtnSearchMember;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView TblBorrowing;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnNewBorrow;
        private System.Windows.Forms.Label LblDatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrow_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn overdue;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}

