﻿namespace muscle
{
    partial class game
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picProgress = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.dumbbell = new System.Windows.Forms.Button();
            this.pushup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(139, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 299);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picProgress
            // 
            this.picProgress.Location = new System.Drawing.Point(33, 30);
            this.picProgress.Name = "picProgress";
            this.picProgress.Size = new System.Drawing.Size(100, 23);
            this.picProgress.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "줄넘기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dumbbell
            // 
            this.dumbbell.Location = new System.Drawing.Point(501, 414);
            this.dumbbell.Name = "dumbbell";
            this.dumbbell.Size = new System.Drawing.Size(75, 23);
            this.dumbbell.TabIndex = 3;
            this.dumbbell.Text = "아령";
            this.dumbbell.UseVisualStyleBackColor = true;
            this.dumbbell.Click += new System.EventHandler(this.dumbbell_Click);
            // 
            // pushup
            // 
            this.pushup.Location = new System.Drawing.Point(587, 414);
            this.pushup.Name = "pushup";
            this.pushup.Size = new System.Drawing.Size(75, 23);
            this.pushup.TabIndex = 4;
            this.pushup.Text = "팔굽혀펴기";
            this.pushup.UseVisualStyleBackColor = true;
            this.pushup.Click += new System.EventHandler(this.pushup_Click);
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pushup);
            this.Controls.Add(this.dumbbell);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picProgress);
            this.Controls.Add(this.pictureBox1);
            this.Name = "game";
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.picProgress_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar picProgress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dumbbell;
        private System.Windows.Forms.Button pushup;
    }
}