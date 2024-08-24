namespace EngineersProject
{
    partial class FrmMinManu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ListEng = new Guna.UI2.WinForms.Guna2GradientButton();
            this.FindEng = new Guna.UI2.WinForms.Guna2GradientButton();
            this.AddEng = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UpdateEng = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // ListEng
            // 
            this.ListEng.Animated = true;
            this.ListEng.AutoRoundedCorners = true;
            this.ListEng.BorderColor = System.Drawing.Color.Gray;
            this.ListEng.BorderRadius = 22;
            this.ListEng.BorderThickness = 3;
            this.ListEng.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ListEng.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ListEng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ListEng.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ListEng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ListEng.FillColor = System.Drawing.Color.Black;
            this.ListEng.FillColor2 = System.Drawing.Color.DimGray;
            this.ListEng.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.ListEng.ForeColor = System.Drawing.Color.White;
            this.ListEng.Location = new System.Drawing.Point(115, 187);
            this.ListEng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListEng.Name = "ListEng";
            this.ListEng.Size = new System.Drawing.Size(302, 47);
            this.ListEng.TabIndex = 0;
            this.ListEng.Tag = " ";
            this.ListEng.Text = "List Engineer ";
            this.ListEng.Click += new System.EventHandler(this.ListEng_Click);
            // 
            // FindEng
            // 
            this.FindEng.Animated = true;
            this.FindEng.AutoRoundedCorners = true;
            this.FindEng.BorderColor = System.Drawing.Color.Gray;
            this.FindEng.BorderRadius = 22;
            this.FindEng.BorderThickness = 3;
            this.FindEng.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.FindEng.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.FindEng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FindEng.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.FindEng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.FindEng.FillColor = System.Drawing.Color.Black;
            this.FindEng.FillColor2 = System.Drawing.Color.DimGray;
            this.FindEng.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.FindEng.ForeColor = System.Drawing.Color.White;
            this.FindEng.Location = new System.Drawing.Point(115, 295);
            this.FindEng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindEng.Name = "FindEng";
            this.FindEng.Size = new System.Drawing.Size(302, 47);
            this.FindEng.TabIndex = 1;
            this.FindEng.Tag = " ";
            this.FindEng.Text = "Find Engineer ";
            this.FindEng.Click += new System.EventHandler(this.FindEng_Click);
            // 
            // AddEng
            // 
            this.AddEng.Animated = true;
            this.AddEng.AutoRoundedCorners = true;
            this.AddEng.BorderColor = System.Drawing.Color.Gray;
            this.AddEng.BorderRadius = 22;
            this.AddEng.BorderThickness = 3;
            this.AddEng.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddEng.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddEng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddEng.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddEng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddEng.FillColor = System.Drawing.Color.Black;
            this.AddEng.FillColor2 = System.Drawing.Color.DimGray;
            this.AddEng.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.AddEng.ForeColor = System.Drawing.Color.White;
            this.AddEng.Location = new System.Drawing.Point(115, 406);
            this.AddEng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEng.Name = "AddEng";
            this.AddEng.Size = new System.Drawing.Size(302, 47);
            this.AddEng.TabIndex = 2;
            this.AddEng.Tag = " ";
            this.AddEng.Text = "Add New Engineer ";
            this.AddEng.Click += new System.EventHandler(this.AddEng_Click);
            // 
            // UpdateEng
            // 
            this.UpdateEng.Animated = true;
            this.UpdateEng.AutoRoundedCorners = true;
            this.UpdateEng.BorderColor = System.Drawing.Color.Gray;
            this.UpdateEng.BorderRadius = 22;
            this.UpdateEng.BorderThickness = 3;
            this.UpdateEng.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateEng.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateEng.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateEng.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateEng.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateEng.FillColor = System.Drawing.Color.Black;
            this.UpdateEng.FillColor2 = System.Drawing.Color.DimGray;
            this.UpdateEng.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.UpdateEng.ForeColor = System.Drawing.Color.White;
            this.UpdateEng.Location = new System.Drawing.Point(115, 518);
            this.UpdateEng.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateEng.Name = "UpdateEng";
            this.UpdateEng.Size = new System.Drawing.Size(302, 47);
            this.UpdateEng.TabIndex = 3;
            this.UpdateEng.Tag = "111";
            this.UpdateEng.Text = "Update Engineer Data";
            this.UpdateEng.Click += new System.EventHandler(this.UpdateEng_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(822, 651);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(683, 651);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Date :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(835, 652);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 23;
            this.label9.Text = "Tiam9";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(738, 651);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Date7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LawnGreen;
            this.label10.Location = new System.Drawing.Point(683, 625);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Usar : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(738, 625);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 19);
            this.label11.TabIndex = 27;
            this.label11.Text = "Shenoda Mohsen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(109, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 39);
            this.label1.TabIndex = 28;
            this.label1.Text = "Select The Operation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EngineersProject.Properties.Resources.Bak_2;
            this.pictureBox1.Location = new System.Drawing.Point(479, -14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 757);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmMinManu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1012, 696);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UpdateEng);
            this.Controls.Add(this.AddEng);
            this.Controls.Add(this.FindEng);
            this.Controls.Add(this.ListEng);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMinManu";
            this.Text = "Frm Min Manu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton ListEng;
        private Guna.UI2.WinForms.Guna2GradientButton FindEng;
        private Guna.UI2.WinForms.Guna2GradientButton AddEng;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateEng;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
    }
}