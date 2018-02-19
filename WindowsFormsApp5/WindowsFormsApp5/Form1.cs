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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class survey
        {
            public string question;
            public List<string> answers = new List<string>();
            public GroupBox g;
        }
        int i = 50;
        int v = 70;
        //suallari ve cavablari saxlayacaq
        List<survey> ga = new List<survey>();


        StreamReader re = new StreamReader("C: /Users/Sony/Desktop/surveyy.txt");
        private void button1_Click(object sender, EventArgs e)
        {
            
            while (!re.EndOfStream)
            {
                var yoxla = re.ReadLine();



                if (yoxla.Length > 0)
                {


                    if (yoxla.Contains("Sual"))
                    {

                        survey opros = new survey();
                        ga.Add(opros);
                        opros.question = yoxla;
                        for (var u = 0; u < 3;)
                        {
                            var yoxla2 = re.ReadLine();
                            //cavablarin arasinda bow yer olarsa diye yoxlayiram
                            if (yoxla2.Length > 0)
                            {
                                opros.answers.Add(yoxla2);
                                u++;
                            }


                        }
                    }

                }

            }
       
            foreach (var a in ga)
            {
                Label l = new Label();
                a.g = new GroupBox();

                a.g.Top = v;
                v += 127;
                this.Controls.Add(a.g);
                l.Top = i;
                i += 130;
                l.Text = a.question;
                l.Width = 400;
                this.Controls.Add(l);
                for (var w = 0; w < a.answers.Count; w++)
                {
                    int count = w * 20;
                    RadioButton btn = new RadioButton();
                    btn.Text = a.answers[w];

                    btn.Top = btn.Height + count;



                    a.g.Controls.Add(btn);
                }
            }
            re.Close();

        }
        int result = 0;
       
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var o in ga)
            {
                RadioButton btn = (RadioButton)o.g.Controls[0];
                if (btn.Checked)
                {
                    result += 1;
                }
            }
            label1.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.Show();

        }
    
    
    }
}
