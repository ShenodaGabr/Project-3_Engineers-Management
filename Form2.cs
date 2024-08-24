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
    public partial class FrmMinManu : Form
    {
        public FrmMinManu()
        {
            InitializeComponent();
        }

 
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = DateTime.Now.ToLongTimeString();
            label7.Text = DateTime.Now.ToShortDateString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void FindEng_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmSearchID();
            frm1.ShowDialog();
        }

        private void AddEng_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmAddEngineer();
            frm1.ShowDialog();
        }

        private void ListEng_Click(object sender, EventArgs e)
        {
            Form frm1 = new Form6();
            frm1.ShowDialog();
        }

        private void DeleteEng_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmSearchID();
            frm1.ShowDialog();
        }

        private void UpdateEng_Click(object sender, EventArgs e)
        {
            Form frm1 = new FrmSearchID2();
            frm1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
