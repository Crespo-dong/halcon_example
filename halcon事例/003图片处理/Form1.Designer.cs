﻿namespace _003图片处理
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.hWindowControl1 = new HalconDotNet.HWindowControl();
            this.btnReadImage = new System.Windows.Forms.Button();
            this.btnImagePro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hWindowControl1
            // 
            this.hWindowControl1.BackColor = System.Drawing.Color.Black;
            this.hWindowControl1.BorderColor = System.Drawing.Color.Black;
            this.hWindowControl1.ImagePart = new System.Drawing.Rectangle(0, 0, 640, 480);
            this.hWindowControl1.Location = new System.Drawing.Point(176, 12);
            this.hWindowControl1.Name = "hWindowControl1";
            this.hWindowControl1.Size = new System.Drawing.Size(390, 295);
            this.hWindowControl1.TabIndex = 0;
            this.hWindowControl1.WindowSize = new System.Drawing.Size(390, 295);
            // 
            // btnReadImage
            // 
            this.btnReadImage.Location = new System.Drawing.Point(34, 64);
            this.btnReadImage.Name = "btnReadImage";
            this.btnReadImage.Size = new System.Drawing.Size(75, 47);
            this.btnReadImage.TabIndex = 1;
            this.btnReadImage.Text = "读图";
            this.btnReadImage.UseVisualStyleBackColor = true;
            // 
            // btnImagePro
            // 
            this.btnImagePro.Location = new System.Drawing.Point(34, 170);
            this.btnImagePro.Name = "btnImagePro";
            this.btnImagePro.Size = new System.Drawing.Size(75, 44);
            this.btnImagePro.TabIndex = 2;
            this.btnImagePro.Text = "处理";
            this.btnImagePro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 319);
            this.Controls.Add(this.btnImagePro);
            this.Controls.Add(this.btnReadImage);
            this.Controls.Add(this.hWindowControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private HalconDotNet.HWindowControl hWindowControl1;
        private System.Windows.Forms.Button btnReadImage;
        private System.Windows.Forms.Button btnImagePro;
    }
}

