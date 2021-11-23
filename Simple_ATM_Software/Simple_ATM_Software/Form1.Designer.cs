
namespace Simple_ATM_Software
{
    partial class Lign
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.simple_atm_label = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.minimize = new System.Windows.Forms.Button();
            this.window_size = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // simple_atm_label
            // 
            this.simple_atm_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simple_atm_label.AutoSize = true;
            this.simple_atm_label.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.simple_atm_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.simple_atm_label.Location = new System.Drawing.Point(285, 29);
            this.simple_atm_label.Name = "simple_atm_label";
            this.simple_atm_label.Size = new System.Drawing.Size(211, 41);
            this.simple_atm_label.TabIndex = 2;
            this.simple_atm_label.Text = "Simple_ATM";
            this.simple_atm_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.simple_atm_label.Click += new System.EventHandler(this.label1_Click);
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
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Exit.ForeColor = System.Drawing.Color.Transparent;
            this.Exit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Exit.Location = new System.Drawing.Point(775, 0);
            this.Exit.Name = "Exit";
            this.Exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Exit.Size = new System.Drawing.Size(25, 25);
            this.Exit.TabIndex = 3;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.max1;
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Location = new System.Drawing.Point(713, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 5;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // window_size
            // 
            this.window_size.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.window_size.BackgroundImage = global::Simple_ATM_Software.Properties.Resources.window2;
            this.window_size.FlatAppearance.BorderSize = 0;
            this.window_size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.window_size.Location = new System.Drawing.Point(744, 0);
            this.window_size.Name = "window_size";
            this.window_size.Size = new System.Drawing.Size(25, 25);
            this.window_size.TabIndex = 6;
            this.window_size.UseVisualStyleBackColor = true;
            this.window_size.Click += new System.EventHandler(this.window_size_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-1, 436);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(801, 23);
            this.progressBar1.TabIndex = 7;
            // 
            // Lign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.window_size);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.simple_atm_label);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label simple_atm_label;
        public System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button minimize;
        private System.Windows.Forms.Button window_size;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

