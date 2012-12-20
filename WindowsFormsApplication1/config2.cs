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
    public partial class config2 : Form
    {
        static public main2 main2Instatn = null;
        //static int g_nStartId, g_nEndId;
        public config2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.startId.Text == "" ||
                this.endId.Text == "")
            {
                MessageBox.Show("请填写完整参数");
                return;
            }

            int nStartId = Convert.ToInt32(this.startId.Text);
            int nEndId = Convert.ToInt32(this.endId.Text);
            Form mainForm = new main2();
            ((main2)(mainForm)).InitTotalList(nStartId, nEndId);
            mainForm.ShowDialog();

            // main2Instatn = ((main2)(mainForm));

            this.Dispose();
        }
    }
}
