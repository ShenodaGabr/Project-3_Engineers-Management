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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("engineers.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length > 0)
                {
                    string imagePath = parts[6]; // الصورة في آخر عنصر
                    Image image;
                    try
                    {
                        image = Image.FromFile(imagePath); // تحميل الصورة من المسار
                    }
                    catch
                    {
                        image = null; // في حال حدوث خطأ في تحميل الصورة
                    }

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);

                    // تعيين الصورة في العمود الأول
                    row.Cells[0].Value = image;

                    // إضافة باقي القيم من السطر إلى الأعمدة الأخرى
                    row.Cells[1].Value = parts[0]; // ID
                    row.Cells[2].Value = parts[1]; // FirstName
                    row.Cells[3].Value = parts[2]; // LastName
                    row.Cells[4].Value = parts[3]; // Password
                    row.Cells[6].Value = parts[4]; // Phone
                    row.Cells[5].Value = parts[5]; // Salary

                    dataGridView1.Rows.Add(row);


                   // / ضبط عرض عمود الصور
                     dataGridView1.Columns["Column_image"].Width = 30; // عرض العمود 100 بكسل

                    // ضبط ارتفاع الصفوف ليتناسب مع الصور
                    dataGridView1.RowTemplate.Height = 90; // ارتفاع الصفوف 100 بكسل

                    // ضبط طريقة عرض الصورة داخل الخلايا
                    foreach (DataGridViewRow row1 in dataGridView1.Rows)
                    {
                        DataGridViewImageCell imgCell = (DataGridViewImageCell)row.Cells["Column_image"];
                        imgCell.ImageLayout = DataGridViewImageCellLayout.Stretch; // لتمديد الصورة لتملأ الخلية بالكامل
                    }
                }
            }
        }
    }
}
