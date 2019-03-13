using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolRecords
{
    public partial class Form1 : Form
    {
        private Display theForm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student(studentNameSet.Text, Convert.ToInt32(ageSet), );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Teacher t1 = new Teacher();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            theForm = new Display();
            theForm.Show();
        }
    }
}
