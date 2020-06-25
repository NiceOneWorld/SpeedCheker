using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedCheker
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            help1 help = new help1();
            help.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox1.Text)) || !(string.IsNullOrWhiteSpace(textBox2.Text))|| !(string.IsNullOrWhiteSpace(textBox3.Text)) || !(string.IsNullOrWhiteSpace(textBox7.Text)))
            {
                
                if (!(string.IsNullOrWhiteSpace(textBox1.Text)))
                { 
                var speed = int.Parse(textBox1.Text);
                textBox4.Text = $"<fInitialDriveMaxFlatVel value = \"{speed / 1.32:.000000}\" /> ";
                }
                else
                {
                    textBox1.Text = "";
                    textBox4.Text = "";
                    
                }
                if (!(string.IsNullOrWhiteSpace(textBox2.Text))) { 
                var gears = int.Parse(textBox2.Text);
                textBox5.Text = $"<nInitialDriveGears value=\"{gears:.}\" />";
                }
                else
                {
                    textBox2.Text = "";
                    textBox5.Text = "";
                }
                if (!(string.IsNullOrWhiteSpace(textBox3.Text)))
                {
                    var mass = int.Parse(textBox3.Text);
                    textBox6.Text = $"<fMass value=\"{mass:.000000}\" />";
                }
                else
                {
                    textBox3.Text = "";
                    textBox6.Text = "";
                }
                if (!(string.IsNullOrWhiteSpace(textBox7.Text)))
                {
                    double acceleration = Convert.ToDouble(textBox7.Text.Replace(".", ","));
                    textBox8.Text = $"<fInitialDriveForce value = \"{acceleration:.000000}\" />";
                    var text = textBox8.Text.Replace(",", ".");
                    textBox8.Text = text;
                }
                else 
                {
                    textBox7.Text = "";
                    textBox8.Text = "";
                }
                
            }
            else
            {
                MessageBox.Show($"Нет заполненых полей!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var speed = 0;
            if (!(string.IsNullOrWhiteSpace(textBox1.Text)))
            { 
                speed = int.Parse(textBox1.Text);
            }
            else
            {
                speed = 0;
            }
            if (speed >= 0 && speed <= 660)
            {

            }
            else
            {
                MessageBox.Show($"Значение должно быть больше 0 и меньше 660!");

            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            var gear = 0;
            if (!(string.IsNullOrWhiteSpace(textBox2.Text)))
            {
                gear = int.Parse(textBox2.Text);
            }
            else
            {
                gear = 0;
            }
            if (gear >= 0 && gear <= 16)
            {

            }
            else
            {
                MessageBox.Show($"Передач должно быть больше 1 и меньше 16!");

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var mass = 0;
            if (!(string.IsNullOrWhiteSpace(textBox3.Text)))
            { 
                mass = int.Parse(textBox3.Text);
            }
            else
            {
                mass = 0;
            }
            if (mass >= 0 && mass <= 10000)
            {
                
            }
            else
            {
                MessageBox.Show($"Масса не должна быть больше 0 и меньше 10000!");
               
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // поле значения скорости
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            // поле колл передач
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            // поле значения массы
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox6.Text)))
            {
                Clipboard.SetText(textBox6.Text);
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox8.Text)))
            {
                Clipboard.SetText(textBox8.Text);
            }
            else
            {
                textBox8.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox5.Text)))
            {
                Clipboard.SetText(textBox5.Text);
            }
            else
            {
                textBox5.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox6.Text)))
            {
                Clipboard.SetText(textBox6.Text);
            }
            else
            {
                textBox6.Text = "";
            }
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            //double acceleration = 0;
            //if (!(string.IsNullOrWhiteSpace(textBox7.Text)))
            //{
            //    acceleration = double.Parse(textBox7.Text);
            //}
            //else
            //{
            //    acceleration = 0;
            //}

            //if (acceleration >= 0.01 && acceleration <= 2)
            //{

            //}
            //else
            //{
            //    MessageBox.Show($"Значение должно быть больше 0.1 и меньше 2!");

            //}
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
           // значение ускорения
        }
    }
}
