namespace _6th_homework
{
    partial class Form1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.coloredLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.RandArrLB = new System.Windows.Forms.Label();
            this.NextRandBt = new System.Windows.Forms.Button();
            this.simon1PL = new System.Windows.Forms.Panel();
            this.simon3PL = new System.Windows.Forms.Panel();
            this.simon2PL = new System.Windows.Forms.Panel();
            this.simon4PL = new System.Windows.Forms.Panel();
            this.simonpointsLB = new System.Windows.Forms.Label();
            this.simonhightscore = new System.Windows.Forms.Label();
            this.SimonStartBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // coloredLabel
            // 
            this.coloredLabel.AutoSize = true;
            this.coloredLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coloredLabel.Location = new System.Drawing.Point(13, 13);
            this.coloredLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.coloredLabel.Name = "coloredLabel";
            this.coloredLabel.Size = new System.Drawing.Size(137, 25);
            this.coloredLabel.TabIndex = 0;
            this.coloredLabel.Text = "see the good";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(18, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 22);
            this.panel1.TabIndex = 1;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Location = new System.Drawing.Point(45, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 22);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel2_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Location = new System.Drawing.Point(72, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 22);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.panel3_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(99, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 22);
            this.panel4.TabIndex = 2;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.Location = new System.Drawing.Point(126, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(21, 22);
            this.panel5.TabIndex = 2;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // RandArrLB
            // 
            this.RandArrLB.AutoSize = true;
            this.RandArrLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandArrLB.Location = new System.Drawing.Point(104, 106);
            this.RandArrLB.Name = "RandArrLB";
            this.RandArrLB.Size = new System.Drawing.Size(132, 20);
            this.RandArrLB.TabIndex = 3;
            this.RandArrLB.Text = "click the button";
            // 
            // NextRandBt
            // 
            this.NextRandBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextRandBt.Location = new System.Drawing.Point(12, 103);
            this.NextRandBt.Name = "NextRandBt";
            this.NextRandBt.Size = new System.Drawing.Size(75, 27);
            this.NextRandBt.TabIndex = 4;
            this.NextRandBt.Text = "Next";
            this.NextRandBt.UseVisualStyleBackColor = true;
            this.NextRandBt.Click += new System.EventHandler(this.NextRandBt_Click);
            // 
            // simon1PL
            // 
            this.simon1PL.Location = new System.Drawing.Point(18, 236);
            this.simon1PL.Name = "simon1PL";
            this.simon1PL.Size = new System.Drawing.Size(90, 68);
            this.simon1PL.TabIndex = 5;
            this.simon1PL.Click += new System.EventHandler(this.simon1PL_Click);
            // 
            // simon3PL
            // 
            this.simon3PL.Location = new System.Drawing.Point(146, 236);
            this.simon3PL.Name = "simon3PL";
            this.simon3PL.Size = new System.Drawing.Size(90, 68);
            this.simon3PL.TabIndex = 6;
            this.simon3PL.Click += new System.EventHandler(this.simon3PL_Click);
            // 
            // simon2PL
            // 
            this.simon2PL.Location = new System.Drawing.Point(18, 337);
            this.simon2PL.Name = "simon2PL";
            this.simon2PL.Size = new System.Drawing.Size(90, 68);
            this.simon2PL.TabIndex = 6;
            this.simon2PL.Click += new System.EventHandler(this.simon2PL_Click);
            // 
            // simon4PL
            // 
            this.simon4PL.Location = new System.Drawing.Point(146, 337);
            this.simon4PL.Name = "simon4PL";
            this.simon4PL.Size = new System.Drawing.Size(90, 68);
            this.simon4PL.TabIndex = 6;
            this.simon4PL.Click += new System.EventHandler(this.simon4PL_Click);
            // 
            // simonpointsLB
            // 
            this.simonpointsLB.AutoSize = true;
            this.simonpointsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simonpointsLB.Location = new System.Drawing.Point(18, 195);
            this.simonpointsLB.Name = "simonpointsLB";
            this.simonpointsLB.Size = new System.Drawing.Size(106, 18);
            this.simonpointsLB.TabIndex = 7;
            this.simonpointsLB.Text = "Simon Game";
            // 
            // simonhightscore
            // 
            this.simonhightscore.AutoSize = true;
            this.simonhightscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simonhightscore.Location = new System.Drawing.Point(179, 195);
            this.simonhightscore.Name = "simonhightscore";
            this.simonhightscore.Size = new System.Drawing.Size(53, 20);
            this.simonhightscore.TabIndex = 8;
            this.simonhightscore.Text = "score";
            // 
            // SimonStartBT
            // 
            this.SimonStartBT.Location = new System.Drawing.Point(88, 308);
            this.SimonStartBT.Name = "SimonStartBT";
            this.SimonStartBT.Size = new System.Drawing.Size(75, 23);
            this.SimonStartBT.TabIndex = 9;
            this.SimonStartBT.Text = "start";
            this.SimonStartBT.UseVisualStyleBackColor = true;
            this.SimonStartBT.Click += new System.EventHandler(this.SimonStartBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "hothaifa zoubi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "naura hazafon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(326, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "hothaifazoubi@gmail.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::_6th_homework.Properties.Resources._560980_3959364515241_812532472_n;
            this.pictureBox1.Image = global::_6th_homework.Properties.Resources.הורד;
            this.pictureBox1.InitialImage = global::_6th_homework.Properties.Resources._560980_3959364515241_812532472_n;
            this.pictureBox1.Location = new System.Drawing.Point(238, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 212);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SimonStartBT);
            this.Controls.Add(this.simonhightscore);
            this.Controls.Add(this.simonpointsLB);
            this.Controls.Add(this.simon4PL);
            this.Controls.Add(this.simon2PL);
            this.Controls.Add(this.simon3PL);
            this.Controls.Add(this.simon1PL);
            this.Controls.Add(this.NextRandBt);
            this.Controls.Add(this.RandArrLB);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.coloredLabel);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label coloredLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label RandArrLB;
        private System.Windows.Forms.Button NextRandBt;
        private System.Windows.Forms.Panel simon1PL;
        private System.Windows.Forms.Panel simon3PL;
        private System.Windows.Forms.Panel simon2PL;
        private System.Windows.Forms.Panel simon4PL;
        private System.Windows.Forms.Label simonpointsLB;
        private System.Windows.Forms.Label simonhightscore;
        private System.Windows.Forms.Button SimonStartBT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

