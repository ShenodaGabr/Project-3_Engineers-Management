using EngineersProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineersProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            if (TextBox1_Usar.Text == "Shenoda Mohsen" && TextBox2_Passwrd.Text == "2233") 
            {
                Form frm1 = new FrmMinManu();
                frm1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username and Password are Wrong :-( ");
                TextBox2_Passwrd.Text= string.Empty;
                TextBox1_Usar.Text = string.Empty;

            }

        }

        private void TextBox1_User_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox1_Usar.Text))
            {
                e.Cancel = true;
                TextBox1_Usar.Focus();
                errorProvider1.SetError(TextBox1_Usar, "UserName should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TextBox1_Usar, "");
            }
        }

        private void TextBox2_Passwrd_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox2_Passwrd.Text))
            {
                e.Cancel = true;
                TextBox2_Passwrd.Focus();
                errorProvider1.SetError(TextBox2_Passwrd, "UserName should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TextBox2_Passwrd, "");
            }
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            if (guna2ImageButton2.Tag.ToString() == "eye")
            {
                guna2ImageButton2.Tag = "blind";

                guna2ImageButton2.Image = Resources.Blind11111;
                TextBox2_Passwrd.PasswordChar = '*';
           
            }
            else
            {
                guna2ImageButton2.Tag = "eye";
                guna2ImageButton2.Image = Resources.Eye11111;
                TextBox2_Passwrd.PasswordChar = '\0';

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label5.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void TextBox1_User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
