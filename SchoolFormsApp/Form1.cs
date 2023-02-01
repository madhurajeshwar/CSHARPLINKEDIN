using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ClickToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.name = TextName.Text;
            testSchool.state = TextState.Text;
            testSchool.address = TextAddress.Text;
            testSchool.city = TextCity.Text;
            testSchool.phoneNumber = TextPhone.Text;
            try
            {
                testSchool.twitterUserName = TextTwitter.Text;
                MessageBox.Show(testSchool.ToString());
                Console.WriteLine(testSchool.twitterUserName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(testSchool.twitterUserName);
                MessageBox.Show(ex.Message);
            }
           var student b = new Student();

        }
    }
}
