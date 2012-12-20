using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class RewardShow : Form
    {
        string szShow;
        public RewardShow()
        {
            InitializeComponent();

            this.label1.Parent = this.pictureBox1;
            this.label1.BackColor = Color.Transparent;
        }

        public void SetShowText(ArrayList list)
        {
            szShow = "";
            foreach(int id in list)
            {
                szShow += id + "号 ";
            }

            this.label1.Text = szShow;

            // main2.AddRecord(szShow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // config2.main2Instatn.AddRecord(szShow);
            this.Close();
        }
    }
}
