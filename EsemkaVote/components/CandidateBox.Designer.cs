namespace EsemkaVote.components
{
    partial class CandidateBox
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
            this.LabCandidateName = new System.Windows.Forms.Label();
            this.LabVoteCount = new System.Windows.Forms.Label();
            this.LabVotePercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabCandidateName
            // 
            this.LabCandidateName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabCandidateName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabCandidateName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LabCandidateName.Location = new System.Drawing.Point(16, 16);
            this.LabCandidateName.Name = "LabCandidateName";
            this.LabCandidateName.Size = new System.Drawing.Size(202, 28);
            this.LabCandidateName.TabIndex = 0;
            this.LabCandidateName.Text = "Name...";
            this.LabCandidateName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabVoteCount
            // 
            this.LabVoteCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabVoteCount.Location = new System.Drawing.Point(16, 165);
            this.LabVoteCount.Name = "LabVoteCount";
            this.LabVoteCount.Size = new System.Drawing.Size(202, 30);
            this.LabVoteCount.TabIndex = 1;
            this.LabVoteCount.Text = "Vote Count: 0";
            this.LabVoteCount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LabVotePercent
            // 
            this.LabVotePercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabVotePercent.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabVotePercent.Location = new System.Drawing.Point(16, 44);
            this.LabVotePercent.Name = "LabVotePercent";
            this.LabVotePercent.Size = new System.Drawing.Size(202, 121);
            this.LabVotePercent.TabIndex = 2;
            this.LabVotePercent.Text = "0%";
            this.LabVotePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CandidateBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.LabVotePercent);
            this.Controls.Add(this.LabVoteCount);
            this.Controls.Add(this.LabCandidateName);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CandidateBox";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "CandidateBox";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label LabVotePercent;
        public System.Windows.Forms.Label LabCandidateName;
        public System.Windows.Forms.Label LabVoteCount;
    }
}