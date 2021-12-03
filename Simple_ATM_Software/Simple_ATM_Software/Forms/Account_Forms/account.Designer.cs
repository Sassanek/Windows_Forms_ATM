
namespace Simple_ATM_Software
{
    partial class account
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
            this.change_pin = new Simple_ATM_Software.Resources.Custom_Button();
            this.personal_data = new Simple_ATM_Software.Resources.Custom_Button();
            this.buttonx = new Simple_ATM_Software.Resources.Custom_Button();
            this.custom_Button1 = new Simple_ATM_Software.Resources.Custom_Button();
            this.back_home = new Simple_ATM_Software.Resources.Custom_Button();
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
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(200, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "ATM ACCOUNT SETTINGS";
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
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
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
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // change_pin
            // 
            this.change_pin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.change_pin.FlatAppearance.BorderSize = 0;
            this.change_pin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_pin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.change_pin.ForeColor = System.Drawing.Color.White;
            this.change_pin.Location = new System.Drawing.Point(166, 144);
            this.change_pin.Name = "change_pin";
            this.change_pin.Size = new System.Drawing.Size(170, 50);
            this.change_pin.TabIndex = 3;
            this.change_pin.Text = "CHANGE PING";
            this.change_pin.UseVisualStyleBackColor = false;
            // 
            // personal_data
            // 
            this.personal_data.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.personal_data.FlatAppearance.BorderSize = 0;
            this.personal_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personal_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.personal_data.ForeColor = System.Drawing.Color.White;
            this.personal_data.Location = new System.Drawing.Point(426, 144);
            this.personal_data.Name = "personal_data";
            this.personal_data.Size = new System.Drawing.Size(170, 50);
            this.personal_data.TabIndex = 4;
            this.personal_data.Text = "PERSONAL DATA";
            this.personal_data.UseVisualStyleBackColor = false;
            // 
            // buttonx
            // 
            this.buttonx.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonx.FlatAppearance.BorderSize = 0;
            this.buttonx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonx.ForeColor = System.Drawing.Color.White;
            this.buttonx.Location = new System.Drawing.Point(166, 257);
            this.buttonx.Name = "buttonx";
            this.buttonx.Size = new System.Drawing.Size(170, 50);
            this.buttonx.TabIndex = 5;
            this.buttonx.Text = "TO DO";
            this.buttonx.UseVisualStyleBackColor = false;
            // 
            // custom_Button1
            // 
            this.custom_Button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.custom_Button1.FlatAppearance.BorderSize = 0;
            this.custom_Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom_Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.custom_Button1.ForeColor = System.Drawing.Color.White;
            this.custom_Button1.Location = new System.Drawing.Point(426, 257);
            this.custom_Button1.Name = "custom_Button1";
            this.custom_Button1.Size = new System.Drawing.Size(170, 50);
            this.custom_Button1.TabIndex = 6;
            this.custom_Button1.Text = "TO DO";
            this.custom_Button1.UseVisualStyleBackColor = false;
            // 
            // back_home
            // 
            this.back_home.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.back_home.FlatAppearance.BorderSize = 0;
            this.back_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.back_home.ForeColor = System.Drawing.Color.White;
            this.back_home.Location = new System.Drawing.Point(302, 357);
            this.back_home.Name = "back_home";
            this.back_home.Size = new System.Drawing.Size(170, 50);
            this.back_home.TabIndex = 7;
            this.back_home.Text = "GO BACK";
            this.back_home.UseVisualStyleBackColor = false;
            this.back_home.Click += new System.EventHandler(this.back_home_Click);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_home);
            this.Controls.Add(this.custom_Button1);
            this.Controls.Add(this.buttonx);
            this.Controls.Add(this.personal_data);
            this.Controls.Add(this.change_pin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "account";
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button window_size;
        public System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private Resources.Custom_Button change_pin;
        private Resources.Custom_Button personal_data;
        private Resources.Custom_Button buttonx;
        private Resources.Custom_Button custom_Button1;
        private Resources.Custom_Button back_home;
    }
}