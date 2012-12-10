using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class config : Form
    {
        static int g_nStartId, g_nEndId, g_nFirstCount, g_nSecondCount, g_ThreeCount;

        public config()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.startId.Text == "" ||
                this.endId.Text == "" ||
                this.firstCount.Text == "" ||
                this.secondCount.Text == "" ||
                this.threeCount.Text == ""||
                this.fourCount.Text == "" ||
                this.fiveCount.Text == "" ||
                this.sixCount.Text == "")
            {
                MessageBox.Show("请填写完整参数");
                return;
            }

            g_nStartId = Convert.ToInt32(this.startId.Text);
            g_nEndId = Convert.ToInt32(this.endId.Text);
            g_nFirstCount = Convert.ToInt32(this.firstCount.Text);
            g_nSecondCount = Convert.ToInt32(this.secondCount.Text);
            g_ThreeCount = Convert.ToInt32(this.threeCount.Text);

            Form mainForm = new main();
            mainForm.ShowDialog();

            this.Close();
        }

        private void startId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void endId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
