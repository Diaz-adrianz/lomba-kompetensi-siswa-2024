namespace apotek_xyz_wf.Forms
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CheckShowPassword = new System.Windows.Forms.CheckBox();
            this.InputPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::apotek_xyz_wf.Properties.Resources.lingian_logo_colored;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 206);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(6, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Apotek XYZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonReset
            // 
            this.ButtonReset.AutoSize = true;
            this.ButtonReset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ButtonReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonReset.FlatAppearance.BorderSize = 0;
            this.ButtonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReset.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonReset.Location = new System.Drawing.Point(169, 15);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonReset.Size = new System.Drawing.Size(160, 33);
            this.ButtonReset.TabIndex = 4;
            this.ButtonReset.Text = "RESET";
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonResetClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(6, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 0);
            this.panel1.TabIndex = 3;
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.AutoSize = true;
            this.ButtonLogin.BackColor = System.Drawing.Color.Green;
            this.ButtonLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonLogin.FlatAppearance.BorderSize = 0;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ButtonLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonLogin.Location = new System.Drawing.Point(3, 15);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Padding = new System.Windows.Forms.Padding(3);
            this.ButtonLogin.Size = new System.Drawing.Size(160, 33);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "LOGIN";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLoginClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonReset, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonLogin, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 424);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 51);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // CheckShowPassword
            // 
            this.CheckShowPassword.AutoSize = true;
            this.CheckShowPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CheckShowPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckShowPassword.Location = new System.Drawing.Point(6, 404);
            this.CheckShowPassword.Name = "CheckShowPassword";
            this.CheckShowPassword.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.CheckShowPassword.Size = new System.Drawing.Size(332, 20);
            this.CheckShowPassword.TabIndex = 2;
            this.CheckShowPassword.Text = "Tampilkan";
            this.CheckShowPassword.UseVisualStyleBackColor = true;
            this.CheckShowPassword.CheckedChanged += new System.EventHandler(this.CheckShowPasswordClick);
            // 
            // InputPassword
            // 
            this.InputPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputPassword.Location = new System.Drawing.Point(6, 375);
            this.InputPassword.MaxLength = 50;
            this.InputPassword.Name = "InputPassword";
            this.InputPassword.PasswordChar = '*';
            this.InputPassword.Size = new System.Drawing.Size(332, 29);
            this.InputPassword.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 347);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 3);
            this.label2.Size = new System.Drawing.Size(56, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // InputUsername
            // 
            this.InputUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InputUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputUsername.Location = new System.Drawing.Point(6, 318);
            this.InputUsername.MaxLength = 50;
            this.InputUsername.Name = "InputUsername";
            this.InputUsername.Size = new System.Drawing.Size(332, 29);
            this.InputUsername.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 302);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 481);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InputUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputPassword);
            this.Controls.Add(this.CheckShowPassword);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(360, 520);
            this.MinimumSize = new System.Drawing.Size(360, 520);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox CheckShowPassword;
        private System.Windows.Forms.TextBox InputPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputUsername;
        private System.Windows.Forms.Label label3;
    }
}