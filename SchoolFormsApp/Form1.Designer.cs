﻿namespace SchoolFormsApp
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
            this.TextName = new System.Windows.Forms.Label();
            this.TextAddress = new System.Windows.Forms.Label();
            this.TextCity = new System.Windows.Forms.Label();
            this.TextState = new System.Windows.Forms.Label();
            this.TextZip = new System.Windows.Forms.Label();
            this.TextPhone = new System.Windows.Forms.Label();
            this.TextTwitter = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ClickToTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextName
            // 
            this.TextName.AutoSize = true;
            this.TextName.Location = new System.Drawing.Point(85, 27);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(33, 13);
            this.TextName.TabIndex = 0;
            this.TextName.Text = "name";
            this.TextName.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextAddress
            // 
            this.TextAddress.AutoSize = true;
            this.TextAddress.Location = new System.Drawing.Point(85, 64);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(44, 13);
            this.TextAddress.TabIndex = 1;
            this.TextAddress.Text = "address";
            // 
            // TextCity
            // 
            this.TextCity.AutoSize = true;
            this.TextCity.Location = new System.Drawing.Point(85, 106);
            this.TextCity.Name = "TextCity";
            this.TextCity.Size = new System.Drawing.Size(23, 13);
            this.TextCity.TabIndex = 2;
            this.TextCity.Text = "city";
            // 
            // TextState
            // 
            this.TextState.AutoSize = true;
            this.TextState.Location = new System.Drawing.Point(85, 149);
            this.TextState.Name = "TextState";
            this.TextState.Size = new System.Drawing.Size(32, 13);
            this.TextState.TabIndex = 3;
            this.TextState.Text = "State";
            // 
            // TextZip
            // 
            this.TextZip.AutoSize = true;
            this.TextZip.Location = new System.Drawing.Point(85, 182);
            this.TextZip.Name = "TextZip";
            this.TextZip.Size = new System.Drawing.Size(22, 13);
            this.TextZip.TabIndex = 4;
            this.TextZip.Text = "Zip";
            this.TextZip.Click += new System.EventHandler(this.label5_Click);
            // 
            // TextPhone
            // 
            this.TextPhone.AutoSize = true;
            this.TextPhone.Location = new System.Drawing.Point(85, 238);
            this.TextPhone.Name = "TextPhone";
            this.TextPhone.Size = new System.Drawing.Size(37, 13);
            this.TextPhone.TabIndex = 5;
            this.TextPhone.Text = "phone";
            // 
            // TextTwitter
            // 
            this.TextTwitter.AutoSize = true;
            this.TextTwitter.Location = new System.Drawing.Point(85, 274);
            this.TextTwitter.Name = "TextTwitter";
            this.TextTwitter.Size = new System.Drawing.Size(39, 13);
            this.TextTwitter.TabIndex = 6;
            this.TextTwitter.Text = "Twitter";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 61);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(126, 182);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(126, 231);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(126, 271);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 14;
            // 
            // ClickToTest
            // 
            this.ClickToTest.Location = new System.Drawing.Point(126, 324);
            this.ClickToTest.Name = "ClickToTest";
            this.ClickToTest.Size = new System.Drawing.Size(75, 23);
            this.ClickToTest.TabIndex = 15;
            this.ClickToTest.Text = "Click to Test";
            this.ClickToTest.UseVisualStyleBackColor = true;
            this.ClickToTest.Click += new System.EventHandler(this.ClickToTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 454);
            this.Controls.Add(this.ClickToTest);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextTwitter);
            this.Controls.Add(this.TextPhone);
            this.Controls.Add(this.TextZip);
            this.Controls.Add(this.TextState);
            this.Controls.Add(this.TextCity);
            this.Controls.Add(this.TextAddress);
            this.Controls.Add(this.TextName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextName;
        private System.Windows.Forms.Label TextAddress;
        private System.Windows.Forms.Label TextCity;
        private System.Windows.Forms.Label TextState;
        private System.Windows.Forms.Label TextZip;
        private System.Windows.Forms.Label TextPhone;
        private System.Windows.Forms.Label TextTwitter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button ClickToTest;
    }
}

