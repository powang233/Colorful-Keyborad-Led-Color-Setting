﻿namespace ColorfulLedKeyboardSet
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.speedBar = new System.Windows.Forms.TrackBar();
            this.CustomRGB_B = new System.Windows.Forms.Button();
            this.GetSource_L = new System.Windows.Forms.LinkLabel();
            this.information_B = new System.Windows.Forms.Button();
            this.ColorTestLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "RGB循环";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // speedBar
            // 
            this.speedBar.LargeChange = 7;
            this.speedBar.Location = new System.Drawing.Point(148, 4);
            this.speedBar.Margin = new System.Windows.Forms.Padding(2);
            this.speedBar.Maximum = 7;
            this.speedBar.Minimum = 1;
            this.speedBar.Name = "speedBar";
            this.speedBar.Size = new System.Drawing.Size(85, 45);
            this.speedBar.TabIndex = 1;
            this.speedBar.Value = 1;
            // 
            // CustomRGB_B
            // 
            this.CustomRGB_B.Location = new System.Drawing.Point(9, 54);
            this.CustomRGB_B.Margin = new System.Windows.Forms.Padding(2);
            this.CustomRGB_B.Name = "CustomRGB_B";
            this.CustomRGB_B.Size = new System.Drawing.Size(73, 27);
            this.CustomRGB_B.TabIndex = 2;
            this.CustomRGB_B.Text = "自定义RGB";
            this.CustomRGB_B.UseVisualStyleBackColor = true;
            this.CustomRGB_B.Click += new System.EventHandler(this.CustomRGB_B_Click);
            // 
            // GetSource_L
            // 
            this.GetSource_L.AutoSize = true;
            this.GetSource_L.Location = new System.Drawing.Point(238, 62);
            this.GetSource_L.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GetSource_L.Name = "GetSource_L";
            this.GetSource_L.Size = new System.Drawing.Size(77, 12);
            this.GetSource_L.TabIndex = 3;
            this.GetSource_L.TabStop = true;
            this.GetSource_L.Text = "获取程序源码";
            this.GetSource_L.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GetSource_L_LinkClicked);
            // 
            // information_B
            // 
            this.information_B.Location = new System.Drawing.Point(148, 54);
            this.information_B.Margin = new System.Windows.Forms.Padding(2);
            this.information_B.Name = "information_B";
            this.information_B.Size = new System.Drawing.Size(73, 27);
            this.information_B.TabIndex = 4;
            this.information_B.Text = "关于程序";
            this.information_B.UseVisualStyleBackColor = true;
            this.information_B.Click += new System.EventHandler(this.information_B_Click);
            // 
            // ColorTestLabel
            // 
            this.ColorTestLabel.AutoSize = true;
            this.ColorTestLabel.Location = new System.Drawing.Point(238, 18);
            this.ColorTestLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ColorTestLabel.Name = "ColorTestLabel";
            this.ColorTestLabel.Size = new System.Drawing.Size(77, 12);
            this.ColorTestLabel.TabIndex = 5;
            this.ColorTestLabel.Text = "您的键盘颜色";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(82, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "停止循环";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "托盘";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 91);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ColorTestLabel);
            this.Controls.Add(this.information_B);
            this.Controls.Add(this.GetSource_L);
            this.Controls.Add(this.CustomRGB_B);
            this.Controls.Add(this.speedBar);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用-作者墨水";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speedBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TrackBar speedBar;
        private System.Windows.Forms.Button CustomRGB_B;
        private System.Windows.Forms.LinkLabel GetSource_L;
        private System.Windows.Forms.Button information_B;
        private System.Windows.Forms.Label ColorTestLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button3;
    }
}

