namespace EsemkaVote
{
    partial class ReportForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabHeadDesc = new System.Windows.Forms.Label();
            this.LabHeadName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelVoteEvent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabCandidateName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabVoteResult = new System.Windows.Forms.Label();
            this.PicCand = new System.Windows.Forms.PictureBox();
            this.PanReasons = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TabDivisions = new System.Windows.Forms.DataGridView();
            this.division_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vote_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabDivisions)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.45098F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.54902F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(852, 285);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabHeadDesc);
            this.panel1.Controls.Add(this.LabHeadName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(170, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 78);
            this.panel1.TabIndex = 0;
            // 
            // LabHeadDesc
            // 
            this.LabHeadDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabHeadDesc.Location = new System.Drawing.Point(0, 37);
            this.LabHeadDesc.Name = "LabHeadDesc";
            this.LabHeadDesc.Size = new System.Drawing.Size(511, 41);
            this.LabHeadDesc.TabIndex = 1;
            this.LabHeadDesc.Text = "Welcome to the Employee of the Year 2022 voting! Celebrate outstanding dedication" +
    " and achievement by casting your vote for the most deserving nominee.";
            this.LabHeadDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabHeadName
            // 
            this.LabHeadName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabHeadName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabHeadName.Location = new System.Drawing.Point(0, 0);
            this.LabHeadName.Name = "LabHeadName";
            this.LabHeadName.Size = new System.Drawing.Size(511, 37);
            this.LabHeadName.TabIndex = 0;
            this.LabHeadName.Text = "Best Employee XXXX";
            this.LabHeadName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SelVoteEvent);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 78);
            this.panel2.TabIndex = 1;
            // 
            // SelVoteEvent
            // 
            this.SelVoteEvent.DisplayMember = "name";
            this.SelVoteEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.SelVoteEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelVoteEvent.FormattingEnabled = true;
            this.SelVoteEvent.Location = new System.Drawing.Point(0, 25);
            this.SelVoteEvent.Name = "SelVoteEvent";
            this.SelVoteEvent.Size = new System.Drawing.Size(170, 25);
            this.SelVoteEvent.TabIndex = 1;
            this.SelVoteEvent.ValueMember = "id";
            this.SelVoteEvent.SelectedValueChanged += new System.EventHandler(this.SelVoteEventValueChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Vote Event";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LabCandidateName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.LabVoteResult);
            this.panel3.Controls.Add(this.PicCand);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(170, 78);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(511, 207);
            this.panel3.TabIndex = 2;
            // 
            // LabCandidateName
            // 
            this.LabCandidateName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabCandidateName.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCandidateName.Location = new System.Drawing.Point(0, 124);
            this.LabCandidateName.Name = "LabCandidateName";
            this.LabCandidateName.Size = new System.Drawing.Size(511, 30);
            this.LabCandidateName.TabIndex = 3;
            this.LabCandidateName.Text = "John Doe";
            this.LabCandidateName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "With";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabVoteResult
            // 
            this.LabVoteResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabVoteResult.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabVoteResult.Location = new System.Drawing.Point(0, 171);
            this.LabVoteResult.Name = "LabVoteResult";
            this.LabVoteResult.Size = new System.Drawing.Size(511, 36);
            this.LabVoteResult.TabIndex = 1;
            this.LabVoteResult.Text = "62% (31/50)";
            this.LabVoteResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PicCand
            // 
            this.PicCand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PicCand.Image = global::EsemkaVote.Properties.Resources.Benjamin;
            this.PicCand.Location = new System.Drawing.Point(216, 3);
            this.PicCand.Name = "PicCand";
            this.PicCand.Size = new System.Drawing.Size(80, 120);
            this.PicCand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCand.TabIndex = 0;
            this.PicCand.TabStop = false;
            // 
            // PanReasons
            // 
            this.PanReasons.AutoScroll = true;
            this.PanReasons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanReasons.Location = new System.Drawing.Point(16, 440);
            this.PanReasons.Name = "PanReasons";
            this.PanReasons.Size = new System.Drawing.Size(852, 105);
            this.PanReasons.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 413);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.label3.Size = new System.Drawing.Size(852, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reason";
            // 
            // TabDivisions
            // 
            this.TabDivisions.AllowUserToAddRows = false;
            this.TabDivisions.AllowUserToDeleteRows = false;
            this.TabDivisions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabDivisions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabDivisions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.division_name,
            this.vote_count,
            this.percentage,
            this.action});
            this.TabDivisions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabDivisions.Location = new System.Drawing.Point(16, 301);
            this.TabDivisions.MultiSelect = false;
            this.TabDivisions.Name = "TabDivisions";
            this.TabDivisions.ReadOnly = true;
            this.TabDivisions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TabDivisions.Size = new System.Drawing.Size(852, 112);
            this.TabDivisions.TabIndex = 4;
            this.TabDivisions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabDivisionsCellClick);
            // 
            // division_name
            // 
            this.division_name.HeaderText = "Division Name";
            this.division_name.Name = "division_name";
            this.division_name.ReadOnly = true;
            // 
            // vote_count
            // 
            this.vote_count.HeaderText = "Vote Count";
            this.vote_count.Name = "vote_count";
            this.vote_count.ReadOnly = true;
            // 
            // percentage
            // 
            this.percentage.HeaderText = "Percentage";
            this.percentage.Name = "percentage";
            this.percentage.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.TabDivisions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PanReasons);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "ReportForm";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.ReportFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicCand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabDivisions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanReasons;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LabHeadName;
        private System.Windows.Forms.Label LabHeadDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelVoteEvent;
        private System.Windows.Forms.PictureBox PicCand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabVoteResult;
        private System.Windows.Forms.Label LabCandidateName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TabDivisions;
        private System.Windows.Forms.DataGridViewTextBoxColumn division_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vote_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn percentage;
        private System.Windows.Forms.DataGridViewLinkColumn action;
    }
}

