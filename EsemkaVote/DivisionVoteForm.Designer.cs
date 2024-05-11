namespace EsemkaVote
{
    partial class DivisionVoteForm
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
            this.LabHeadTitle = new System.Windows.Forms.Label();
            this.LabHeadVotes = new System.Windows.Forms.Label();
            this.PanCandidates = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LabHeadTitle
            // 
            this.LabHeadTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabHeadTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabHeadTitle.Location = new System.Drawing.Point(16, 16);
            this.LabHeadTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabHeadTitle.Name = "LabHeadTitle";
            this.LabHeadTitle.Size = new System.Drawing.Size(672, 30);
            this.LabHeadTitle.TabIndex = 0;
            this.LabHeadTitle.Text = "Division Detail";
            this.LabHeadTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LabHeadVotes
            // 
            this.LabHeadVotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabHeadVotes.Location = new System.Drawing.Point(16, 46);
            this.LabHeadVotes.Name = "LabHeadVotes";
            this.LabHeadVotes.Size = new System.Drawing.Size(672, 37);
            this.LabHeadVotes.TabIndex = 1;
            this.LabHeadVotes.Text = "Total Vote: 0";
            this.LabHeadVotes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanCandidates
            // 
            this.PanCandidates.AutoScroll = true;
            this.PanCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanCandidates.Location = new System.Drawing.Point(16, 83);
            this.PanCandidates.Name = "PanCandidates";
            this.PanCandidates.Size = new System.Drawing.Size(672, 222);
            this.PanCandidates.TabIndex = 2;
            // 
            // DivisionVoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 321);
            this.Controls.Add(this.PanCandidates);
            this.Controls.Add(this.LabHeadVotes);
            this.Controls.Add(this.LabHeadTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DivisionVoteForm";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Text = "Division Vote Detail";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabHeadTitle;
        private System.Windows.Forms.Label LabHeadVotes;
        private System.Windows.Forms.Panel PanCandidates;
    }
}