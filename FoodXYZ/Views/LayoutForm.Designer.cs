namespace FoodXYZ.Views
{
    partial class LayoutForm
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
            this.PanSidebar = new System.Windows.Forms.Panel();
            this.PanForm = new System.Windows.Forms.Panel();
            this.LabTipeUser = new System.Windows.Forms.Label();
            this.PicTipeUser = new System.Windows.Forms.PictureBox();
            this.PanSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTipeUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PanSidebar
            // 
            this.PanSidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanSidebar.Controls.Add(this.PicTipeUser);
            this.PanSidebar.Controls.Add(this.LabTipeUser);
            this.PanSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanSidebar.Location = new System.Drawing.Point(0, 0);
            this.PanSidebar.Name = "PanSidebar";
            this.PanSidebar.Padding = new System.Windows.Forms.Padding(16);
            this.PanSidebar.Size = new System.Drawing.Size(200, 441);
            this.PanSidebar.TabIndex = 0;
            // 
            // PanForm
            // 
            this.PanForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanForm.Location = new System.Drawing.Point(200, 0);
            this.PanForm.Name = "PanForm";
            this.PanForm.Padding = new System.Windows.Forms.Padding(16);
            this.PanForm.Size = new System.Drawing.Size(552, 441);
            this.PanForm.TabIndex = 1;
            // 
            // LabTipeUser
            // 
            this.LabTipeUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabTipeUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabTipeUser.Location = new System.Drawing.Point(16, 16);
            this.LabTipeUser.Name = "LabTipeUser";
            this.LabTipeUser.Size = new System.Drawing.Size(168, 42);
            this.LabTipeUser.TabIndex = 0;
            this.LabTipeUser.Text = "User";
            this.LabTipeUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PicTipeUser
            // 
            this.PicTipeUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicTipeUser.Image = global::FoodXYZ.Properties.Resources.market;
            this.PicTipeUser.Location = new System.Drawing.Point(16, 58);
            this.PicTipeUser.Name = "PicTipeUser";
            this.PicTipeUser.Size = new System.Drawing.Size(168, 100);
            this.PicTipeUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PicTipeUser.TabIndex = 1;
            this.PicTipeUser.TabStop = false;
            // 
            // LayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 441);
            this.Controls.Add(this.PanForm);
            this.Controls.Add(this.PanSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(768, 480);
            this.Name = "LayoutForm";
            this.Text = "Food XYZ";
            this.PanSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTipeUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanSidebar;
        private System.Windows.Forms.Panel PanForm;
        private System.Windows.Forms.Label LabTipeUser;
        private System.Windows.Forms.PictureBox PicTipeUser;
    }
}