
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.home_deposit = new Simple_ATM_Software.Resources.Custom_Button();
            this.home_acc_setting = new Simple_ATM_Software.Resources.Custom_Button();
            this.home_withdraw = new Simple_ATM_Software.Resources.Custom_Button();
            this.home_payments = new Simple_ATM_Software.Resources.Custom_Button();
            this.label4 = new System.Windows.Forms.Label();
            this.home_logout = new Simple_ATM_Software.Resources.Custom_Button();
            this.minimize = new System.Windows.Forms.Button();
            this.window_size = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.window_size);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 110);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(151, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a transaction";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 343);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Main Menu";
            // 
            // home_deposit
            // 
            this.home_deposit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.home_deposit.FlatAppearance.BorderSize = 0;
            this.home_deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_deposit.ForeColor = System.Drawing.Color.White;
            this.home_deposit.Location = new System.Drawing.Point(200, 155);
            this.home_deposit.Name = "home_deposit";
            this.home_deposit.Size = new System.Drawing.Size(150, 40);
            this.home_deposit.TabIndex = 2;
            this.home_deposit.Text = "DEPOSIT";
            this.home_deposit.UseVisualStyleBackColor = false;
            // 
            // home_acc_setting
            // 
            this.home_acc_setting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.home_acc_setting.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.home_acc_setting.FlatAppearance.BorderSize = 0;
            this.home_acc_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_acc_setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_acc_setting.ForeColor = System.Drawing.Color.White;
            this.home_acc_setting.Location = new System.Drawing.Point(200, 279);
            this.home_acc_setting.Name = "home_acc_setting";
            this.home_acc_setting.Size = new System.Drawing.Size(150, 40);
            this.home_acc_setting.TabIndex = 4;
            this.home_acc_setting.Text = "ACCOUNT SETTINGS";
            this.home_acc_setting.UseVisualStyleBackColor = false;
            // 
            // home_withdraw
            // 
            this.home_withdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.home_withdraw.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.home_withdraw.FlatAppearance.BorderSize = 0;
            this.home_withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.home_withdraw.ForeColor = System.Drawing.Color.White;
            this.home_withdraw.Location = new System.Drawing.Point(500, 150);
            this.home_withdraw.Name = "home_withdraw";
            this.home_withdraw.Size = new System.Drawing.Size(150, 40);
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
            this.home_payments.Location = new System.Drawing.Point(500, 279);
            this.home_payments.Name = "home_payments";
            this.home_payments.Size = new System.Drawing.Size(150, 40);
            this.home_payments.TabIndex = 7;
            this.home_payments.Text = "PAYEMNTS";
            this.home_payments.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(152, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Welcome to Simple_ATM_Software";
            // 
            // home_logout
            // 
            this.home_logout.BackColor = System.Drawing.SystemColors.Control;
            this.home_logout.FlatAppearance.BorderSize = 0;
            this.home_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_logout.Font = new System.Drawing.Font("Romantic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.home_logout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.home_logout.Location = new System.Drawing.Point(349, 385);
            this.home_logout.Name = "home_logout";
            this.home_logout.Size = new System.Drawing.Size(150, 40);
            this.home_logout.TabIndex = 8;
            this.home_logout.Text = "LOGOUT";
            this.home_logout.UseVisualStyleBackColor = false;
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
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.home_logout);
            this.Controls.Add(this.home_payments);
            this.Controls.Add(this.home_withdraw);
            this.Controls.Add(this.home_acc_setting);
            this.Controls.Add(this.home_deposit);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Simple_ATM_Software.Resources.Custom_Button home_deposit;
        private Simple_ATM_Software.Resources.Custom_Button home_acc_setting;
        private Simple_ATM_Software.Resources.Custom_Button home_withdraw;
        private Simple_ATM_Software.Resources.Custom_Button home_payments;
        private Simple_ATM_Software.Resources.Custom_Button home_logout;
        public System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button window_size;
        private System.Windows.Forms.Button minimize;
    }
}