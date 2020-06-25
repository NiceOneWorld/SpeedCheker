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

namespace SpeedCheker
{
    public partial class help1 : Form
    {

        public help1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {



            //string filePath = @"D:/repos/SpeedCheker/SpeedCheker/TextFile1.txt";
            //FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read);
            //Encoding enc = new UTF8Encoding(true, true);
            //// преобразуем строку в байты
            //byte[] array = new byte[fs.Length];

            //// считываем данные
            //fs.Read(array, 0, array.Length);
            //// декодируем байты в строку
            //string textFromFile =  enc.GetString(array);
            //// создаем буфер
            //var buf = textFromFile;
            //// закрываем поток 
            //fs.Close();
            //// выводим в бокс

            //textBox1.Text = textFromFile;
        }

        private void help1_Load(object sender, EventArgs e)
        {

        }
    }
}
