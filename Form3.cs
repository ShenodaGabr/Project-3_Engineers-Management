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
    public partial class FrmSearchID : Form
    {
        public FrmSearchID()
        {
            InitializeComponent();
        }
        private void buSearch_Click(object sender, EventArgs e)
        {
            string filePath = "engineers.txt"; // تعديل المسار حسب مكان ملف النص
            string searchId = TxtSearchIDD.Text.Trim(); // إزالة المسافات الزائدة

            bool engineerFound = false;
            string[] engineerData = null;

            // قراءة جميع الأسطر في الملف
            var lines = File.ReadAllLines(filePath);

            // البحث عن الـ ID في الملف
            foreach (var line in lines)
            {
                var data = line.Split(','); // افتراض أن البيانات مفصولة بفواصل

                if (data[0].Trim().Equals(searchId, StringComparison.OrdinalIgnoreCase)) // مقارنة الـ ID بشكل غير حساس لحالة الأحرف
                {
                    engineerFound = true;
                    engineerData = data;
                    break;
                }
            }

            if (engineerFound)
            {
                // إذا تم العثور على المهندس، فتح Form5 وعرض البيانات
                FrmEngineerDetails form5 = new FrmEngineerDetails(engineerData);
                form5.Show();
            }
            else
            {
                MessageBox.Show("ID not found!");
            }
        }

        private void bucancla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
