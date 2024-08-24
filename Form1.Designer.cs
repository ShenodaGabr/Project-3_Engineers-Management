namespace EngineersProject
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox1_Usar = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TextBox2_Passwrd = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // TextBox1_Usar
            // 
            this.TextBox1_Usar.Animated = true;
            this.TextBox1_Usar.AutoRoundedCorners = true;
            this.TextBox1_Usar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TextBox1_Usar.BorderRadius = 21;
            this.TextBox1_Usar.BorderThickness = 2;
            this.TextBox1_Usar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox1_Usar.DefaultText = "";
            this.TextBox1_Usar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox1_Usar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox1_Usar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1_Usar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox1_Usar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.TextBox1_Usar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.TextBox1_Usar, "TextBox1_Usar");
            this.TextBox1_Usar.ForeColor = System.Drawing.Color.Black;
            this.TextBox1_Usar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox1_Usar.IconLeftSize = new System.Drawing.Size(30, 25);
            this.TextBox1_Usar.IconRightSize = new System.Drawing.Size(30, 25);
            this.TextBox1_Usar.Name = "TextBox1_Usar";
            this.TextBox1_Usar.PasswordChar = '\0';
            this.TextBox1_Usar.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TextBox1_Usar.PlaceholderText = "Username";
            this.TextBox1_Usar.SelectedText = "";
            this.TextBox1_Usar.Tag = "SS";
            this.TextBox1_Usar.TextChanged += new System.EventHandler(this.TextBox1_User_TextChanged);
            this.TextBox1_Usar.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox1_User_Validating);
            // 
            // Login
            // 
            this.Login.Animated = true;
            this.Login.AutoRoundedCorners = true;
            this.Login.BorderColor = System.Drawing.Color.White;
            this.Login.BorderRadius = 17;
            this.Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Login.FillColor = System.Drawing.Color.Purple;
            this.Login.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.Login, "Login");
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Name = "Login";
            this.Login.Tag = "111";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // TextBox2_Passwrd
            // 
            this.TextBox2_Passwrd.Animated = true;
            this.TextBox2_Passwrd.AutoRoundedCorners = true;
            this.TextBox2_Passwrd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TextBox2_Passwrd.BorderRadius = 21;
            this.TextBox2_Passwrd.BorderThickness = 2;
            this.TextBox2_Passwrd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox2_Passwrd.DefaultText = "";
            this.TextBox2_Passwrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox2_Passwrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox2_Passwrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2_Passwrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox2_Passwrd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.TextBox2_Passwrd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.TextBox2_Passwrd, "TextBox2_Passwrd");
            this.TextBox2_Passwrd.ForeColor = System.Drawing.Color.Black;
            this.TextBox2_Passwrd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextBox2_Passwrd.IconLeftSize = new System.Drawing.Size(30, 25);
            this.TextBox2_Passwrd.IconRightSize = new System.Drawing.Size(30, 25);
            this.TextBox2_Passwrd.Name = "TextBox2_Passwrd";
            this.TextBox2_Passwrd.PasswordChar = '\0';
            this.TextBox2_Passwrd.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.TextBox2_Passwrd.PlaceholderText = "Passward";
            this.TextBox2_Passwrd.SelectedText = "";
            this.TextBox2_Passwrd.Tag = "111";
            this.TextBox2_Passwrd.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox2_Passwrd_Validating);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton1.Image = global::EngineersProject.Properties.Resources.Lock;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.IndicateFocus = true;
            resources.ApplyResources(this.guna2ImageButton1, "guna2ImageButton1");
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabStop = false;
            this.guna2ImageButton1.Tag = "eye";
            this.guna2ImageButton1.UseTransparentBackground = true;
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton2.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.Image = global::EngineersProject.Properties.Resources.Eye11111;
            this.guna2ImageButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton2.ImageRotate = 0F;
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(30, 30);
            resources.ApplyResources(this.guna2ImageButton2, "guna2ImageButton2");
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.TabStop = false;
            this.guna2ImageButton2.Tag = "eye";
            this.guna2ImageButton2.UseTransparentBackground = true;
            this.guna2ImageButton2.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.Image = global::EngineersProject.Properties.Resources.codioful_formerly_gradienta_EOeKdkusGZ4_unsplash;
            this.guna2PictureBox1.ImageRotate = 0F;
            resources.ApplyResources(this.guna2PictureBox1, "guna2PictureBox1");
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2ImageButton3.Image = global::EngineersProject.Properties.Resources.Male_User_circle_2;
            this.guna2ImageButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton3.ImageRotate = 0F;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.IndicateFocus = true;
            resources.ApplyResources(this.guna2ImageButton3, "guna2ImageButton3");
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton3.TabStop = false;
            this.guna2ImageButton3.Tag = "eye";
            this.guna2ImageButton3.UseTransparentBackground = true;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2ImageButton2);
            this.Controls.Add(this.TextBox2_Passwrd);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2ImageButton3);
            this.Controls.Add(this.TextBox1_Usar);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label1);
            this.Name = "FrmLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2TextBox TextBox2_Passwrd;
        private Guna.UI2.WinForms.Guna2TextBox TextBox1_Usar;
        private Guna.UI2.WinForms.Guna2GradientButton Login;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

