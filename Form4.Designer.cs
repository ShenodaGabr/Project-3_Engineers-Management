﻿namespace EngineersProject
{
    partial class FrmAddEngineer
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
            this.txtID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label8 = new System.Windows.Forms.Label();
            this.bucancla = new Guna.UI2.WinForms.Guna2GradientButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSelectImages = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBoxEngineer = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngineer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Animated = true;
            this.txtID.AutoRoundedCorners = true;
            this.txtID.BorderColor = System.Drawing.Color.Silver;
            this.txtID.BorderRadius = 14;
            this.txtID.BorderThickness = 2;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.DefaultText = "";
            this.txtID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID.FillColor = System.Drawing.Color.Gray;
            this.txtID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtID.ForeColor = System.Drawing.Color.White;
            this.txtID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID.IconLeftSize = new System.Drawing.Size(30, 25);
            this.txtID.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtID.Location = new System.Drawing.Point(202, 128);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtID.PlaceholderText = " ";
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(204, 30);
            this.txtID.TabIndex = 0;
            this.txtID.Tag = "SS";
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.TextID_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(95, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add New Engineer ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Animated = true;
            this.txtFirstName.AutoRoundedCorners = true;
            this.txtFirstName.BorderColor = System.Drawing.Color.Silver;
            this.txtFirstName.BorderRadius = 14;
            this.txtFirstName.BorderThickness = 2;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.FillColor = System.Drawing.Color.Gray;
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFirstName.IconLeftSize = new System.Drawing.Size(30, 25);
            this.txtFirstName.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtFirstName.Location = new System.Drawing.Point(202, 181);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtFirstName.PlaceholderText = " ";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.Size = new System.Drawing.Size(204, 30);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Tag = "SS";
            // 
            // txtLastName
            // 
            this.txtLastName.Animated = true;
            this.txtLastName.AutoRoundedCorners = true;
            this.txtLastName.BorderColor = System.Drawing.Color.Silver;
            this.txtLastName.BorderRadius = 14;
            this.txtLastName.BorderThickness = 2;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.FillColor = System.Drawing.Color.Gray;
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLastName.IconLeftSize = new System.Drawing.Size(30, 25);
            this.txtLastName.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtLastName.Location = new System.Drawing.Point(202, 234);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtLastName.PlaceholderText = " ";
            this.txtLastName.SelectedText = "";
            this.txtLastName.Size = new System.Drawing.Size(204, 30);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.Tag = "SS";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.AutoRoundedCorners = true;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 14;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.Gray;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconLeftSize = new System.Drawing.Size(30, 25);
            this.txtPassword.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtPassword.Location = new System.Drawing.Point(202, 290);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPassword.PlaceholderText = " ";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(204, 30);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Tag = "SS";
            // 
            // txtPhone
            // 
            this.txtPhone.Animated = true;
            this.txtPhone.AutoRoundedCorners = true;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.BorderRadius = 14;
            this.txtPhone.BorderThickness = 2;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FillColor = System.Drawing.Color.Gray;
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.IconLeftSize = new System.Drawing.Size(30, 25);
            this.txtPhone.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtPhone.Location = new System.Drawing.Point(202, 346);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPhone.PlaceholderText = " ";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(204, 30);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Tag = "SS";
            // 
            // txtSalary
            // 
            this.txtSalary.Animated = true;
            this.txtSalary.AutoRoundedCorners = true;
            this.txtSalary.BorderColor = System.Drawing.Color.Silver;
            this.txtSalary.BorderRadius = 14;
            this.txtSalary.BorderThickness = 2;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FillColor = System.Drawing.Color.Gray;
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSalary.ForeColor = System.Drawing.Color.White;
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.IconLeftSize = new System.Drawing.Size(30, 25);
            this.txtSalary.IconRightSize = new System.Drawing.Size(30, 25);
            this.txtSalary.Location = new System.Drawing.Point(202, 404);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSalary.PlaceholderText = " ";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(204, 30);
            this.txtSalary.TabIndex = 5;
            this.txtSalary.Tag = "SS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enter ID ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Enter a First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter a Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Enter a Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(34, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Enter a Phone ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(34, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Enter a Salary";
            // 
            // buSave
            // 
            this.buSave.Animated = true;
            this.buSave.AutoRoundedCorners = true;
            this.buSave.BorderColor = System.Drawing.Color.Gray;
            this.buSave.BorderRadius = 17;
            this.buSave.BorderThickness = 3;
            this.buSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buSave.FillColor = System.Drawing.Color.Black;
            this.buSave.FillColor2 = System.Drawing.Color.DimGray;
            this.buSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buSave.ForeColor = System.Drawing.Color.White;
            this.buSave.Location = new System.Drawing.Point(671, 430);
            this.buSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buSave.Name = "buSave";
            this.buSave.Size = new System.Drawing.Size(88, 37);
            this.buSave.TabIndex = 7;
            this.buSave.Tag = " ";
            this.buSave.Text = "Save";
            this.buSave.Click += new System.EventHandler(this.buSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(668, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Save Changes";
            // 
            // bucancla
            // 
            this.bucancla.Animated = true;
            this.bucancla.AutoRoundedCorners = true;
            this.bucancla.BorderColor = System.Drawing.Color.Gray;
            this.bucancla.BorderRadius = 17;
            this.bucancla.BorderThickness = 3;
            this.bucancla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bucancla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bucancla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bucancla.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bucancla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bucancla.FillColor = System.Drawing.Color.Black;
            this.bucancla.FillColor2 = System.Drawing.Color.DimGray;
            this.bucancla.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bucancla.ForeColor = System.Drawing.Color.White;
            this.bucancla.Location = new System.Drawing.Point(785, 430);
            this.bucancla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bucancla.Name = "bucancla";
            this.bucancla.Size = new System.Drawing.Size(88, 37);
            this.bucancla.TabIndex = 8;
            this.bucancla.Tag = " ";
            this.bucancla.Text = "Cancla";
            this.bucancla.Click += new System.EventHandler(this.bucancla_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Animated = true;
            this.btnSelectImages.AutoRoundedCorners = true;
            this.btnSelectImages.BorderColor = System.Drawing.Color.Gray;
            this.btnSelectImages.BorderRadius = 19;
            this.btnSelectImages.BorderThickness = 3;
            this.btnSelectImages.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectImages.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelectImages.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectImages.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelectImages.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelectImages.FillColor = System.Drawing.Color.Black;
            this.btnSelectImages.FillColor2 = System.Drawing.Color.DimGray;
            this.btnSelectImages.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectImages.ForeColor = System.Drawing.Color.White;
            this.btnSelectImages.Location = new System.Drawing.Point(695, 290);
            this.btnSelectImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(136, 41);
            this.btnSelectImages.TabIndex = 6;
            this.btnSelectImages.Tag = " ";
            this.btnSelectImages.Text = "Select Images";
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click_1);
            // 
            // pictureBoxEngineer
            // 
            this.pictureBoxEngineer.ImageRotate = 0F;
            this.pictureBoxEngineer.Location = new System.Drawing.Point(671, 35);
            this.pictureBoxEngineer.Name = "pictureBoxEngineer";
            this.pictureBoxEngineer.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxEngineer.Size = new System.Drawing.Size(188, 199);
            this.pictureBoxEngineer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEngineer.TabIndex = 29;
            this.pictureBoxEngineer.TabStop = false;
            // 
            // FrmAddEngineer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(936, 519);
            this.Controls.Add(this.pictureBoxEngineer);
            this.Controls.Add(this.btnSelectImages);
            this.Controls.Add(this.bucancla);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Name = "FrmAddEngineer";
            this.Text = "Frm Add Engineer ";
            this.Load += new System.EventHandler(this.FrmAddEngineer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEngineer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtID;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2GradientButton buSave;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2GradientButton bucancla;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSelectImages;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxEngineer;
    }
}