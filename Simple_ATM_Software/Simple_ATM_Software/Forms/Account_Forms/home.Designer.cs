
namespace WindowsFormsApp1
{
    partial class home
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
            this.minimize = new System.Windows.Forms.Button();
            this.window_size = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.home_deposit = new Simple_ATM_Software.Resources.Custom_Button();
            this.home_account = new Simple_ATM_Software.Resources.Custom_Button();
            this.home_withdraw = new Simple_ATM_Software.Resources.Custom_Button();
            this.home_payments = new Simple_ATM_Software.Resources.Custom_Button();
            this.custom_Button1 = new Simple_ATM_Software.Resources.Custom_Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.window_size);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 102);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.max1;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(710, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 8;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // window_size
            // 
            this.window_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.window_size.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.window2;
            this.window_size.FlatAppearance.BorderSize = 0;
            this.window_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.window_size.Location = new System.Drawing.Point(740, 0);
            this.window_size.Name = "window_size";
            this.window_size.Size = new System.Drawing.Size(25, 25);
            this.window_size.TabIndex = 7;
            this.window_size.UseVisualStyleBackColor = true;
            this.window_size.Click += new System.EventHandler(this.window_size_Click);
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
            this.Exit.Location = new System.Drawing.Point(770, 0);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(187, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Welcome to Simple_ATM_Software";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(252, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a transaction";
            // 
            // home_deposit
            // 
            this.home_deposit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.home_deposit.FlatAppearance.BorderSize = 0;
            this.home_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_deposit.ForeColor = System.Drawing.Color.White;
            this.home_deposit.Location = new System.Drawing.Point(180, 175);
            this.home_deposit.Name = "home_deposit";
            this.home_deposit.Size = new System.Drawing.Size(170, 50);
            this.home_deposit.TabIndex = 2;
            this.home_deposit.Text = "DEPOSIT";
            this.home_deposit.UseVisualStyleBackColor = false;
            // 
            // home_account
            // 
            this.home_account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.home_account.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.home_account.FlatAppearance.BorderSize = 0;
            this.home_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_account.ForeColor = System.Drawing.Color.White;
            this.home_account.Location = new System.Drawing.Point(180, 300);
            this.home_account.Name = "home_account";
            this.home_account.Size = new System.Drawing.Size(170, 50);
            this.home_account.TabIndex = 4;
            this.home_account.Text = "ACCOUNT SETTINGS";
            this.home_account.UseVisualStyleBackColor = false;
            this.home_account.Click += new System.EventHandler(this.home_account_Click);
            // 
            // home_withdraw
            // 
            this.home_withdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.home_withdraw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.home_withdraw.FlatAppearance.BorderSize = 0;
            this.home_withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_withdraw.ForeColor = System.Drawing.Color.White;
            this.home_withdraw.Location = new System.Drawing.Point(450, 175);
            this.home_withdraw.Name = "home_withdraw";
            this.home_withdraw.Size = new System.Drawing.Size(170, 50);
            this.home_withdraw.TabIndex = 5;
            this.home_withdraw.Text = "WITHDRAW";
            this.home_withdraw.UseVisualStyleBackColor = false;
            // 
            // home_payments
            // 
            this.home_payments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.home_payments.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.home_payments.FlatAppearance.BorderSize = 0;
            this.home_payments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_payments.ForeColor = System.Drawing.Color.White;
            this.home_payments.Location = new System.Drawing.Point(450, 300);
            this.home_payments.Name = "home_payments";
            this.home_payments.Size = new System.Drawing.Size(170, 50);
            this.home_payments.TabIndex = 7;
            this.home_payments.Text = "PAYEMNTS";
            this.home_payments.UseVisualStyleBackColor = false;
            // 
            // custom_Button1
            // 
            this.custom_Button1.BackColor = System.Drawing.Color.Transparent;
            this.custom_Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.custom_Button1.FlatAppearance.BorderSize = 0;
            this.custom_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_Button1.Font = new System.Drawing.Font("Romantic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.custom_Button1.ForeColor = System.Drawing.Color.Maroon;
            this.custom_Button1.Location = new System.Drawing.Point(315, 373);
            this.custom_Button1.Name = "custom_Button1";
            this.custom_Button1.Size = new System.Drawing.Size(170, 50);
            this.custom_Button1.TabIndex = 38;
            this.custom_Button1.Text = "LOGOUT";
            this.custom_Button1.UseVisualStyleBackColor = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.custom_Button1);
            this.Controls.Add(this.home_payments);
            this.Controls.Add(this.home_withdraw);
            this.Controls.Add(this.home_account);
            this.Controls.Add(this.home_deposit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Simple_ATM_Software.Resources.Custom_Button home_deposit;
        private Simple_ATM_Software.Resources.Custom_Button home_account;
        private Simple_ATM_Software.Resources.Custom_Button home_withdraw;
        private Simple_ATM_Software.Resources.Custom_Button home_payments;
        public System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button window_size;
        private System.Windows.Forms.Button minimize;
        private Simple_ATM_Software.Resources.Custom_Button custom_Button1;
    }
}