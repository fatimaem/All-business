using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        { 
            StreamWriter write = new StreamWriter("C: /Users/Sony/Desktop/surveyy.txt",append:true);
            write.WriteLine("Sual "+textBox1.Text);
            write.WriteLine(textBox2.Text);
            write.WriteLine(textBox3.Text);
            write.WriteLine(textBox4.Text);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            
            MessageBox.Show("ur question has been successfully added");

            write.Close();

     
        }
    }
}
