using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineersProject
{
    public partial class FrmUpdateEngineerData : Form
    {
        public FrmUpdateEngineerData(string[] engineerData)
        {
            InitializeComponent();

            // افتراض أن البيانات مرتبة كالتالي: ID, FirstName, LastName, Password, Phone, Salary
            txtID.Text = engineerData[0];
            txtFirstName.Text = engineerData[1];
            txtLastName.Text = engineerData[2];
            txtPassword.Text = engineerData[3];
            txtPhone.Text = engineerData[4];
            txtSalary.Text = engineerData[5];
            string imagePath = engineerData[6];

            // تحقق من وجود الصورة في المسار المحدد
            if (File.Exists("engineers.txt"))
            {
                pictureBoxEngineer.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("ملف الصورة غير موجود. يرجى التحقق من المسار.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void butSave2Engineer_Click(object sender, EventArgs e)
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

            // إنشاء السطر الجديد بالبيانات المحدثة
            string updatedData = $"{id},{firstName},{lastName},{password},{phone},{salary},{imagePath}";

            // قراءة جميع الأسطر من الملف النصي
            List<string> newLines = new List<string>();
            bool updated = false;

            // المرور عبر جميع الأسطر وإضافة البيانات المحدثة بدلاً من السطر القديم
            foreach (string line in File.ReadLines("engineers.txt"))
            {
                string[] parts = line.Split(',');
                if (parts[0] == id)
                {
                    newLines.Add(updatedData); // استبدال السطر القديم بالسطر الجديد
                    updated = true;
                }
                else
                {
                    newLines.Add(line); // الاحتفاظ بالسطر كما هو إذا لم يكن السطر القديم
                }
            }

            // إذا لم يتم تحديث السطر، أضف السطر الجديد
            if (!updated)
            {
                newLines.Add(updatedData);
            }

            // كتابة الأسطر الجديدة إلى الملف النصي، مما يضمن حذف السطر القديم
            File.WriteAllLines("engineers.txt", newLines);

            // عرض رسالة تأكيد بعد التحديث
            MessageBox.Show("Engineer data updated successfully.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // إغلاق نموذج Update Engineer بعد التحديث
            this.Close();
        }








        private void bucancla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSelectImages_Click(object sender, EventArgs e)
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

        private void txtID_Validating(object sender, CancelEventArgs e)
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
                txtID.Focus();
                errorProvider1.SetError(txtID, "UserName should have a value!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtID, "");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



