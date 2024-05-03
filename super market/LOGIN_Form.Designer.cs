namespace super_market
{
    partial class LOGIN_Form
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
            this.circle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox1_USER_NAME = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextBox2_PASSWORD = new Guna.UI2.WinForms.Guna2TextBox();
            this.Button_LOGIN = new Guna.UI2.WinForms.Guna2Button();
            this.label_Clear = new System.Windows.Forms.Label();
            this.label_Exit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // circle
            // 
            this.circle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.circle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.circle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.circle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.circle.FillColor = System.Drawing.Color.Firebrick;
            this.circle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.circle.ForeColor = System.Drawing.Color.White;
            this.circle.Location = new System.Drawing.Point(-195, -45);
            this.circle.Name = "circle";
            this.circle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circle.Size = new System.Drawing.Size(456, 463);
            this.circle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(283, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "USER-NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(283, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(357, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOGIN PAGE";
            // 
            // TextBox1_USER_NAME
            // 
            this.TextBox1_USER_NAME.BorderRadius = 16;
            this.TextBox1_USER_NAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1_USER_NAME.DefaultText = "";
            this.TextBox1_USER_NAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1_USER_NAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1_USER_NAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1_USER_NAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1_USER_NAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1_USER_NAME.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox1_USER_NAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1_USER_NAME.Location = new System.Drawing.Point(443, 165);
            this.TextBox1_USER_NAME.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox1_USER_NAME.Name = "TextBox1_USER_NAME";
            this.TextBox1_USER_NAME.PasswordChar = '\0';
            this.TextBox1_USER_NAME.PlaceholderText = "";
            this.TextBox1_USER_NAME.SelectedText = "";
            this.TextBox1_USER_NAME.Size = new System.Drawing.Size(170, 31);
            this.TextBox1_USER_NAME.TabIndex = 4;
            // 
            // TextBox2_PASSWORD
            // 
            this.TextBox2_PASSWORD.BorderRadius = 16;
            this.TextBox2_PASSWORD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox2_PASSWORD.DefaultText = "";
            this.TextBox2_PASSWORD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox2_PASSWORD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox2_PASSWORD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2_PASSWORD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2_PASSWORD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2_PASSWORD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBox2_PASSWORD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2_PASSWORD.Location = new System.Drawing.Point(443, 209);
            this.TextBox2_PASSWORD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox2_PASSWORD.Name = "TextBox2_PASSWORD";
            this.TextBox2_PASSWORD.PasswordChar = '●';
            this.TextBox2_PASSWORD.PlaceholderText = "";
            this.TextBox2_PASSWORD.SelectedText = "";
            this.TextBox2_PASSWORD.Size = new System.Drawing.Size(170, 31);
            this.TextBox2_PASSWORD.TabIndex = 5;
            this.TextBox2_PASSWORD.UseSystemPasswordChar = true;
            // 
            // Button_LOGIN
            // 
            this.Button_LOGIN.BorderRadius = 24;
            this.Button_LOGIN.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Button_LOGIN.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Button_LOGIN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Button_LOGIN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Button_LOGIN.FillColor = System.Drawing.Color.DarkRed;
            this.Button_LOGIN.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_LOGIN.ForeColor = System.Drawing.Color.White;
            this.Button_LOGIN.Location = new System.Drawing.Point(355, 266);
            this.Button_LOGIN.Name = "Button_LOGIN";
            this.Button_LOGIN.Size = new System.Drawing.Size(180, 45);
            this.Button_LOGIN.TabIndex = 6;
            this.Button_LOGIN.Text = "LOGIN";
            // 
            // label_Clear
            // 
            this.label_Clear.AutoSize = true;
            this.label_Clear.BackColor = System.Drawing.Color.MistyRose;
            this.label_Clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clear.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Clear.Location = new System.Drawing.Point(414, 324);
            this.label_Clear.Name = "label_Clear";
            this.label_Clear.Size = new System.Drawing.Size(60, 28);
            this.label_Clear.TabIndex = 7;
            this.label_Clear.Text = "Clear";
            this.label_Clear.Click += new System.EventHandler(this.label_Clear_Click);
            this.label_Clear.MouseEnter += new System.EventHandler(this.label_Clear_MouseEnter);
            this.label_Clear.MouseLeave += new System.EventHandler(this.label_Clear_MouseLeave);
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.BackColor = System.Drawing.Color.DarkRed;
            this.label_Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.Black;
            this.label_Exit.Location = new System.Drawing.Point(617, 0);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(34, 38);
            this.label_Exit.TabIndex = 8;
            this.label_Exit.Text = "X";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            this.label_Exit.MouseEnter += new System.EventHandler(this.label_Exit_MouseEnter);
            this.label_Exit.MouseLeave += new System.EventHandler(this.label_Exit_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(47, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 43);
            this.label4.TabIndex = 9;
            this.label4.Text = "Welcome";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Firebrick;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(12, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 43);
            this.label5.TabIndex = 10;
            this.label5.Text = "Super Market";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Firebrick;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(37, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 43);
            this.label6.TabIndex = 11;
            this.label6.Text = "Appliction";
            // 
            // comboBox_role
            // 
            this.comboBox_role.BackColor = System.Drawing.Color.White;
            this.comboBox_role.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_role.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.comboBox_role.Location = new System.Drawing.Point(443, 127);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(170, 31);
            this.comboBox_role.TabIndex = 12;
            this.comboBox_role.Text = "Select Role";
            // 
            // LOGIN_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.label_Clear);
            this.Controls.Add(this.Button_LOGIN);
            this.Controls.Add(this.TextBox2_PASSWORD);
            this.Controls.Add(this.TextBox1_USER_NAME);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LOGIN_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton circle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1_USER_NAME;
        private Guna.UI2.WinForms.Guna2TextBox TextBox2_PASSWORD;
        private Guna.UI2.WinForms.Guna2Button Button_LOGIN;
        private System.Windows.Forms.Label label_Clear;
        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_role;
    }
}

