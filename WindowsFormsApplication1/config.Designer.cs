namespace WindowsFormsApplication1
{
    partial class config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startId = new System.Windows.Forms.TextBox();
            this.firstCount = new System.Windows.Forms.TextBox();
            this.secondCount = new System.Windows.Forms.TextBox();
            this.threeCount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.endId = new System.Windows.Forms.TextBox();
            this.fourCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fiveCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sixCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "一等奖人数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "二等奖人数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "三等奖人数";
            // 
            // startId
            // 
            this.startId.Location = new System.Drawing.Point(119, 22);
            this.startId.Name = "startId";
            this.startId.Size = new System.Drawing.Size(59, 21);
            this.startId.TabIndex = 6;
            this.startId.TextChanged += new System.EventHandler(this.startId_TextChanged);
            // 
            // firstCount
            // 
            this.firstCount.Location = new System.Drawing.Point(160, 67);
            this.firstCount.Name = "firstCount";
            this.firstCount.Size = new System.Drawing.Size(100, 21);
            this.firstCount.TabIndex = 7;
            // 
            // secondCount
            // 
            this.secondCount.Location = new System.Drawing.Point(160, 114);
            this.secondCount.Name = "secondCount";
            this.secondCount.Size = new System.Drawing.Size(100, 21);
            this.secondCount.TabIndex = 8;
            // 
            // threeCount
            // 
            this.threeCount.Location = new System.Drawing.Point(160, 162);
            this.threeCount.Name = "threeCount";
            this.threeCount.Size = new System.Drawing.Size(100, 21);
            this.threeCount.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "确认设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "起始号码";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "终止号码";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // endId
            // 
            this.endId.Location = new System.Drawing.Point(259, 22);
            this.endId.Name = "endId";
            this.endId.Size = new System.Drawing.Size(59, 21);
            this.endId.TabIndex = 12;
            this.endId.TextChanged += new System.EventHandler(this.endId_TextChanged);
            // 
            // fourCount
            // 
            this.fourCount.Location = new System.Drawing.Point(160, 213);
            this.fourCount.Name = "fourCount";
            this.fourCount.Size = new System.Drawing.Size(100, 21);
            this.fourCount.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "四等奖人数";
            // 
            // fiveCount
            // 
            this.fiveCount.Location = new System.Drawing.Point(160, 261);
            this.fiveCount.Name = "fiveCount";
            this.fiveCount.Size = new System.Drawing.Size(100, 21);
            this.fiveCount.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "五等奖人数";
            // 
            // sixCount
            // 
            this.sixCount.Location = new System.Drawing.Point(160, 309);
            this.sixCount.Name = "sixCount";
            this.sixCount.Size = new System.Drawing.Size(100, 21);
            this.sixCount.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "六等奖人数";
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 395);
            this.Controls.Add(this.sixCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fiveCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.fourCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.threeCount);
            this.Controls.Add(this.secondCount);
            this.Controls.Add(this.firstCount);
            this.Controls.Add(this.startId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startId;
        private System.Windows.Forms.TextBox firstCount;
        private System.Windows.Forms.TextBox secondCount;
        private System.Windows.Forms.TextBox threeCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endId;
        private System.Windows.Forms.TextBox fourCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fiveCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sixCount;
        private System.Windows.Forms.Label label8;
    }
}