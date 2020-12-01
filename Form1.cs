using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratybos_nr4_Gunas
{
    public partial class Form1 : Form
    {
        int i = 0;
        double[] array = new double[10];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string txt_1 = textBox1.Text;
            
            if (tikrinimas(txt_1))
            {
                MessageBox.Show("Blogai įvesti duomenys, įveskite skaicių");
            }
            else
            {
                double nr;
                double.TryParse(txt_1, out nr);
                if (nr == 0)
                {
                    MessageBox.Show("Blogai įvesti duomenys, įveskite skaicių");
                }
                else if (i < 10)
                {
                    array[i] = nr;
                    i++;
                    richTextBox1.Clear();

                    richTextBox1.Text = "Iveskite " + (i + 1).ToString() + " skaičių.";

                }
                else if (i == 10)
                {
                    double suma = array.Sum();
                    richTextBox1.Clear();
                    richTextBox1.Text = "Atsakymas " + suma.ToString();
                }
                else
                {
                    if (i > 10)
                    {
                        i = 0;

                        array = new double[10];
                    }

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            string txt_2 = textBox2.Text;

            if (tikrinimas(txt_2))
            {
                MessageBox.Show("Blogai įvesti duomenys, įveskite skaicių");
            }
            else {

                int sakos;

                int.TryParse(txt_2, out sakos);

                if (sakos == 0) {
                    MessageBox.Show("Blogai įvesti duomenys, įveskite skaicių");

                }
                else {
                    
                    int zvaizdute = 1;
                    int sakytes = sakos;
                    for (int i = 0; i <= sakos ; i++)
                    {
                        for (int j = 0; j < sakytes; j++)
                        {
                        
                            richTextBox2.Text += " ";
                        }
                        for (int j = 0; j < zvaizdute; j++)
                        {
                           
                            richTextBox2.Text += "* ";
                        }
                       
                        richTextBox2.AppendText(Environment.NewLine);
                        zvaizdute++;
                        sakytes--;
                    }
                
                    }
            }
        }

        bool tikrinimas(string txt)
        {

            return String.IsNullOrWhiteSpace(txt); //Tikrinimas ar ivesti skaiciai
         
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
