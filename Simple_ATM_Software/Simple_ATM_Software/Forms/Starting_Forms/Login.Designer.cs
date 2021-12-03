
namespace Simple_ATM_Software
{
    partial class login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_exit = new System.Windows.Forms.Button();
            this.Login_window = new System.Windows.Forms.Button();
            this.Login_min = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.window_size = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login_signup = new Simple_ATM_Software.Resources.Custom_Button();
            this.login_confirm = new Simple_ATM_Software.Resources.Custom_Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.login_exit);
            this.panel1.Controls.Add(this.Login_window);
            this.panel1.Controls.Add(this.Login_min);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.window_size);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 99);
            this.panel1.TabIndex = 9;
            // 
            // login_exit
            // 
            this.login_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.login_exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.login_exit.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.X3;
            this.login_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_exit.CausesValidation = false;
            this.login_exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.login_exit.FlatAppearance.BorderSize = 5;
            this.login_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_exit.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.login_exit.ForeColor = System.Drawing.Color.Transparent;
            this.login_exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.login_exit.Location = new System.Drawing.Point(659, 0);
            this.login_exit.Name = "login_exit";
            this.login_exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.login_exit.Size = new System.Drawing.Size(25, 25);
            this.login_exit.TabIndex = 12;
            this.login_exit.UseVisualStyleBackColor = false;
            this.login_exit.Click += new System.EventHandler(this.loginExit_Click);
            // 
            // Login_window
            // 
            this.Login_window.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_window.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.window2;
            this.Login_window.FlatAppearance.BorderSize = 0;
            this.Login_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_window.Location = new System.Drawing.Point(628, 0);
            this.Login_window.Name = "Login_window";
            this.Login_window.Size = new System.Drawing.Size(25, 25);
            this.Login_window.TabIndex = 11;
            this.Login_window.UseVisualStyleBackColor = true;
            this.Login_window.Click += new System.EventHandler(this.loginWindow_Click);
            // 
            // Login_min
            // 
            this.Login_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_min.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.max1;
            this.Login_min.FlatAppearance.BorderSize = 0;
            this.Login_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_min.Location = new System.Drawing.Point(597, 0);
            this.Login_min.Name = "Login_min";
            this.Login_min.Size = new System.Drawing.Size(25, 25);
            this.Login_min.TabIndex = 10;
            this.Login_min.UseVisualStyleBackColor = true;
            this.Login_min.Click += new System.EventHandler(this.loginMin_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 110);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.max1;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(609, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 6;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.loginMin_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.X3;
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Exit.CausesValidation = false;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit.FlatAppearance.BorderSize = 5;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Exit.Location = new System.Drawing.Point(663, 0);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 8;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.loginExit_Click);
            // 
            // window_size
            // 
            this.window_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.window_size.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.window2;
            this.window_size.FlatAppearance.BorderSize = 0;
            this.window_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.window_size.Location = new System.Drawing.Point(636, 0);
            this.window_size.Name = "window_size";
            this.window_size.Size = new System.Drawing.Size(25, 25);
            this.window_size.TabIndex = 7;
            this.window_size.UseVisualStyleBackColor = true;
            this.window_size.Click += new System.EventHandler(this.loginWindow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(133, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "ACC NUM: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(237, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 47);
            this.label3.TabIndex = 11;
            this.label3.Text = "PIN: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.textBox1.Location = new System.Drawing.Point(338, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 34);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.textBox2.Location = new System.Drawing.Point(338, 214);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 34);
            this.textBox2.TabIndex = 13;
            // 
            // login_signup
            // 
            this.login_signup.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.login_signup.BackColor = System.Drawing.SystemColors.Control;
            this.login_signup.FlatAppearance.BorderSize = 0;
            this.login_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_signup.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.login_signup.Location = new System.Drawing.Point(338, 338);
            this.login_signup.Name = "login_signup";
            this.login_signup.Size = new System.Drawing.Size(150, 40);
            this.login_signup.TabIndex = 15;
            this.login_signup.Text = "SIGNUP";
            this.login_signup.UseVisualStyleBackColor = false;
            // 
            // login_confirm
            // 
            this.login_confirm.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.login_confirm.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.login_confirm.FlatAppearance.BorderSize = 0;
            this.login_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.login_confirm.ForeColor = System.Drawing.Color.White;
            this.login_confirm.Location = new System.Drawing.Point(334, 275);
            this.login_confirm.Name = "login_confirm";
            this.login_confirm.Size = new System.Drawing.Size(150, 40);
            this.login_confirm.TabIndex = 14;
            this.login_confirm.Text = "LOGIN";
            this.login_confirm.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.login_signup);
            this.Controls.Add(this.login_confirm);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button window_size;
        public System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Resources.Custom_Button login_confirm;
        private Resources.Custom_Button login_signup;
        private System.Windows.Forms.Button Login_min;
        private System.Windows.Forms.Button Login_window;
        public System.Windows.Forms.Button login_exit;
    }
}