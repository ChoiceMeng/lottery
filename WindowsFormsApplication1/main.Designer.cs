using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    partial class main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnFirst = new System.Windows.Forms.Button();
            this.btnSec = new System.Windows.Forms.Button();
            this.BtnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSingle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnFirst
            // 
            this.BtnFirst.Location = new System.Drawing.Point(54, 45);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(75, 23);
            this.BtnFirst.TabIndex = 0;
            this.BtnFirst.Text = "抽取一等奖";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(54, 116);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 23);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "抽取二等奖";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnThree
            // 
            this.BtnThree.Location = new System.Drawing.Point(54, 188);
            this.BtnThree.Name = "BtnThree";
            this.BtnThree.Size = new System.Drawing.Size(75, 23);
            this.BtnThree.TabIndex = 2;
            this.BtnThree.Text = "抽取三等奖";
            this.BtnThree.UseVisualStyleBackColor = true;
            this.BtnThree.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(252, 188);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(75, 23);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "抽取六等奖";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(252, 116);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(75, 23);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "抽取五等奖";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(252, 45);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(75, 23);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "抽取四等奖";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSingle
            // 
            this.btnSingle.Location = new System.Drawing.Point(148, 247);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(75, 23);
            this.btnSingle.TabIndex = 6;
            this.btnSingle.Text = "号码单抽";
            this.btnSingle.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(54, 294);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(273, 100);
            this.listBox1.TabIndex = 7;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 413);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSingle);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.BtnThree);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.BtnFirst);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "宜昌人在北京 年会摇奖程序";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnFirst;
        private Button btnSec;
        private Button BtnThree;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnSingle;
        private ListBox listBox1;
    }
}

