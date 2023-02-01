namespace SchoolFormsApp
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
            this.TextN1 = new System.Windows.Forms.Label();
            this.TextA1 = new System.Windows.Forms.Label();
            this.TextC1 = new System.Windows.Forms.Label();
            this.TextSt1 = new System.Windows.Forms.Label();
            this.TextZ1 = new System.Windows.Forms.Label();
            this.TextP1 = new System.Windows.Forms.Label();
            this.TextT1 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextState = new System.Windows.Forms.TextBox();
            this.TextCity = new System.Windows.Forms.TextBox();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.TextZip = new System.Windows.Forms.TextBox();
            this.TextPhone = new System.Windows.Forms.TextBox();
            this.TextTwitter = new System.Windows.Forms.TextBox();
            this.ClickToTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextN1
            // 
            this.TextN1.AutoSize = true;
            this.TextN1.Location = new System.Drawing.Point(85, 27);
            this.TextN1.Name = "TextN1";
            this.TextN1.Size = new System.Drawing.Size(33, 13);
            this.TextN1.TabIndex = 0;
            this.TextN1.Text = "name";
            this.TextN1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextA1
            // 
            this.TextA1.AutoSize = true;
            this.TextA1.Location = new System.Drawing.Point(85, 64);
            this.TextA1.Name = "TextA1";
            this.TextA1.Size = new System.Drawing.Size(44, 13);
            this.TextA1.TabIndex = 1;
            this.TextA1.Text = "address";
            // 
            // TextC1
            // 
            this.TextC1.AutoSize = true;
            this.TextC1.Location = new System.Drawing.Point(85, 106);
            this.TextC1.Name = "TextC1";
            this.TextC1.Size = new System.Drawing.Size(23, 13);
            this.TextC1.TabIndex = 2;
            this.TextC1.Text = "city";
            // 
            // TextSt1
            // 
            this.TextSt1.AutoSize = true;
            this.TextSt1.Location = new System.Drawing.Point(85, 149);
            this.TextSt1.Name = "TextSt1";
            this.TextSt1.Size = new System.Drawing.Size(30, 13);
            this.TextSt1.TabIndex = 3;
            this.TextSt1.Text = "state";
            // 
            // TextZ1
            // 
            this.TextZ1.AutoSize = true;
            this.TextZ1.Location = new System.Drawing.Point(85, 182);
            this.TextZ1.Name = "TextZ1";
            this.TextZ1.Size = new System.Drawing.Size(22, 13);
            this.TextZ1.TabIndex = 4;
            this.TextZ1.Text = "Zip";
            this.TextZ1.Click += new System.EventHandler(this.label5_Click);
            // 
            // TextP1
            // 
            this.TextP1.AutoSize = true;
            this.TextP1.Location = new System.Drawing.Point(85, 238);
            this.TextP1.Name = "TextP1";
            this.TextP1.Size = new System.Drawing.Size(37, 13);
            this.TextP1.TabIndex = 5;
            this.TextP1.Text = "phone";
            // 
            // TextT1
            // 
            this.TextT1.AutoSize = true;
            this.TextT1.Location = new System.Drawing.Point(85, 274);
            this.TextT1.Name = "TextT1";
            this.TextT1.Size = new System.Drawing.Size(39, 13);
            this.TextT1.TabIndex = 6;
            this.TextT1.Text = "Twitter";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(126, 24);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(100, 20);
            this.TextName.TabIndex = 8;
            // 
            // TextState
            // 
            this.TextState.Location = new System.Drawing.Point(126, 142);
            this.TextState.Name = "TextState";
            this.TextState.Size = new System.Drawing.Size(100, 20);
            this.TextState.TabIndex = 9;
            // 
            // TextCity
            // 
            this.TextCity.Location = new System.Drawing.Point(126, 99);
            this.TextCity.Name = "TextCity";
            this.TextCity.Size = new System.Drawing.Size(100, 20);
            this.TextCity.TabIndex = 10;
            // 
            // TextAddress
            // 
            this.TextAddress.Location = new System.Drawing.Point(126, 61);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(100, 20);
            this.TextAddress.TabIndex = 11;
            // 
            // TextZip
            // 
            this.TextZip.Location = new System.Drawing.Point(126, 182);
            this.TextZip.Name = "TextZip";
            this.TextZip.Size = new System.Drawing.Size(100, 20);
            this.TextZip.TabIndex = 12;
            // 
            // TextPhone
            // 
            this.TextPhone.Location = new System.Drawing.Point(126, 231);
            this.TextPhone.Name = "TextPhone";
            this.TextPhone.Size = new System.Drawing.Size(100, 20);
            this.TextPhone.TabIndex = 13;
            // 
            // TextTwitter
            // 
            this.TextTwitter.Location = new System.Drawing.Point(126, 271);
            this.TextTwitter.Name = "TextTwitter";
            this.TextTwitter.Size = new System.Drawing.Size(100, 20);
            this.TextTwitter.TabIndex = 14;
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
            this.Controls.Add(this.TextTwitter);
            this.Controls.Add(this.TextPhone);
            this.Controls.Add(this.TextZip);
            this.Controls.Add(this.TextAddress);
            this.Controls.Add(this.TextCity);
            this.Controls.Add(this.TextState);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.TextT1);
            this.Controls.Add(this.TextP1);
            this.Controls.Add(this.TextZ1);
            this.Controls.Add(this.TextSt1);
            this.Controls.Add(this.TextC1);
            this.Controls.Add(this.TextA1);
            this.Controls.Add(this.TextN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextN1;
        private System.Windows.Forms.Label TextA1;
        private System.Windows.Forms.Label TextC1;
        private System.Windows.Forms.Label TextSt1;
        private System.Windows.Forms.Label TextZ1;
        private System.Windows.Forms.Label TextP1;
        private System.Windows.Forms.Label TextT1;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextState;
        private System.Windows.Forms.TextBox TextCity;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.TextBox TextZip;
        private System.Windows.Forms.TextBox TextPhone;
        private System.Windows.Forms.TextBox TextTwitter;
        private System.Windows.Forms.Button ClickToTest;
    }
}

