using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace EngineersProject
{
    public partial class FrmAddEngineer : Form
    {
        public FrmAddEngineer()
        {
            InitializeComponent();
        }
       
        private void TextID_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                e.Cancel = true;
                txtID.Focus();
                errorProvider1.SetError(txtID, "UserName should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtID, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                txtPassword.Focus();
                errorProvider1.SetError(txtPassword, "UserName should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, "");
            }
        }

        private void bucancla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectImages_Click_1(object sender, EventArgs e)
        {
            // إنشاء نافذة لاختيار الصورة
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // تحديد أنواع الملفات اللي ممكن المستخدم يختارها (صور فقط)
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                // فتح نافذة اختيار الملف
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                     pictureBoxEngineer.Image = System.Drawing.Image.FromFile(ofd.FileName);
                    pictureBoxEngineer.Tag = ofd.FileName; // تخزين مسار الصورة
                }
            }
        }
 
        private void buSave_Click(object sender, EventArgs e)
        {
            // التحقق من صحة المدخلات
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtSalary.Text) ||
                pictureBoxEngineer.Tag == null)
            {
                MessageBox.Show("Please fill in all fields and select an image.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string id = txtID.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string password = txtPassword.Text;
            string phone = txtPhone.Text;
            string salary = txtSalary.Text;
            string imagePath = pictureBoxEngineer.Tag.ToString(); // مسار الصورة

            // التحقق من أن رقم الهاتف يتكون من أرقام فقط
            if (!long.TryParse(phone, out _))
            {
                MessageBox.Show("Phone number must contain only digits.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // تشفير كلمة المرور
            //string encryptedPassword = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password));

            // حفظ البيانات في ملف نصي
            string engineerData = $"{id},{firstName},{lastName},{password},{phone},{salary},{imagePath}";

            // التأكد من وجود الملف أو إنشائه إذا كان غير موجود
            if (!File.Exists("engineers.txt"))
            {
                File.Create("engineers.txt").Close();
            }

            File.AppendAllText("engineers.txt", engineerData + Environment.NewLine);

            MessageBox.Show("Engineer data saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void FrmAddEngineer_Load(object sender, EventArgs e)
        {

        }
    }
}



 