namespace EsemkaVote.components
{
    partial class ReasonBox
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
            this.TexContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TexContent
            // 
            this.TexContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TexContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TexContent.Location = new System.Drawing.Point(3, 3);
            this.TexContent.Multiline = true;
            this.TexContent.Name = "TexContent";
            this.TexContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TexContent.Size = new System.Drawing.Size(194, 94);
            this.TexContent.TabIndex = 0;
            this.TexContent.Text = "The reason is...";
            // 
            // ReasonBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(200, 100);
            this.Controls.Add(this.TexContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReasonBox";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "ReasonBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TexContent;
    }
}