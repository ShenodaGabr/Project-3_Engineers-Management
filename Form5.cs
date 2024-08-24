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
    public partial class FrmEngineerDetails : Form
    {
        public FrmEngineerDetails(string[] engineerData)
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

        private void butDeleteEngineer_Click_1(object sender, EventArgs e)
        {
            string idToDelete = txtID.Text; // تأكد من تعيين الـ ID الصحيح

            // عرض رسالة تأكيد قبل الحذف
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete engineer with ID: {idToDelete}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // قراءة جميع الأسطر من الملف النصي
                string[] allLines = File.ReadAllLines("engineers.txt");
                List<string> newLines = new List<string>();

                // المرور عبر جميع الأسطر واختيار الأسطر التي لا تحتوي على الـ ID المطلوب حذفه
                foreach (string line in allLines)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] != idToDelete)
                    {
                        newLines.Add(line); // احتفظ بالأسطر التي لا تحتوي على الـ ID المطلوب حذفه
                    }
                }

                // كتابة الأسطر الجديدة إلى الملف النصي
                File.WriteAllLines("engineers.txt", newLines);

                // عرض رسالة تأكيد بعد الحذف
                MessageBox.Show("Engineer deleted successfully.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // إغلاق نموذج Details Engineer بعد الحذف
                this.Close();
            }

        }

        private void bucancla_Click(object sender, EventArgs e)
        {
            this.Close();

        }

       
    }

}
