
namespace Simple_ATM_Software
{
    partial class withdraw
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
            this.minimize = new System.Windows.Forms.Button();
            this.window_size = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.home_logout = new Simple_ATM_Software.Resources.Custom_Button();
            this.depoist = new Simple_ATM_Software.Resources.Custom_Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.window_size);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 110);
            this.panel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(250, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "ATM MANAGMENT";
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.max1;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(710, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 8;
            this.minimize.UseVisualStyleBackColor = true;
            // 
            // window_size
            // 
            this.window_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.window_size.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.window2;
            this.window_size.FlatAppearance.BorderSize = 0;
            this.window_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.window_size.Location = new System.Drawing.Point(740, 3);
            this.window_size.Name = "window_size";
            this.window_size.Size = new System.Drawing.Size(25, 25);
            this.window_size.TabIndex = 7;
            this.window_size.UseVisualStyleBackColor = true;
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
            this.Exit.Location = new System.Drawing.Point(770, 3);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 4;
            this.Exit.UseVisualStyleBackColor = false;
            // 
            // home_logout
            // 
            this.home_logout.BackColor = System.Drawing.Color.Transparent;
            this.home_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.home_logout.FlatAppearance.BorderSize = 0;
            this.home_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_logout.Font = new System.Drawing.Font("Romantic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.home_logout.ForeColor = System.Drawing.Color.Maroon;
            this.home_logout.Location = new System.Drawing.Point(300, 388);
            this.home_logout.Name = "home_logout";
            this.home_logout.Size = new System.Drawing.Size(170, 50);
            this.home_logout.TabIndex = 42;
            this.home_logout.Text = "LOGOUT";
            this.home_logout.UseVisualStyleBackColor = false;
            // 
            // depoist
            // 
            this.depoist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.depoist.FlatAppearance.BorderSize = 0;
            this.depoist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depoist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.depoist.ForeColor = System.Drawing.Color.White;
            this.depoist.Location = new System.Drawing.Point(300, 300);
            this.depoist.Name = "depoist";
            this.depoist.Size = new System.Drawing.Size(170, 50);
            this.depoist.TabIndex = 41;
            this.depoist.Text = "CONFIRM";
            this.depoist.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(396, 220);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(250, 44);
            this.textBox5.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(124, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 40);
            this.label6.TabIndex = 39;
            this.label6.Text = "WITHDRAW";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(200, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 40);
            this.label2.TabIndex = 43;
            this.label2.Text = "CURRENT BALANCE:";
            // 
            // balance
            // 
            this.balance.BackColor = System.Drawing.SystemColors.Control;
            this.balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.balance.Location = new System.Drawing.Point(256, 177);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(250, 37);
            this.balance.TabIndex = 44;
            // 
            // withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.home_logout);
            this.Controls.Add(this.depoist);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "withdraw";
            this.Text = "withdraw";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button window_size;
        public System.Windows.Forms.Button Exit;
        private Resources.Custom_Button home_logout;
        private Resources.Custom_Button depoist;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox balance;
    }
}