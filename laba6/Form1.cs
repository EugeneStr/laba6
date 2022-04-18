using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 cl = new Class1();

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists("Calc.ini"))
                {
                    throw new FileNotFoundException();
                }
                cl.main(file_listBox, trackBar1, listBox_res);
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Файл с исходными данными не найден", "ERROR");
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void XYButton_Click(object sender, EventArgs e)
        {
            if (file_listBox.SelectedItems.Count != 0)
            {
                cl.Read_File(file_listBox.SelectedItem.ToString(), listBox_x, listBox_y);
            }
            else
            {
                MessageBox.Show("Необходимо выбрать файл", "ERROR");
            }
            
        }

        private void ResButton_Click(object sender, EventArgs e)
        {
            if (file_listBox.SelectedItems.Count != 0 && listBox_x.SelectedItems.Count != 0 && listBox_y.SelectedItems.Count != 0)
            {
                cl.output_result(file_listBox.SelectedItem.ToString(), listBox_x, listBox_y, res_textbox);
            }
            else
            {
                MessageBox.Show("Необходимо выбрать все данные", "ERROR");
            }
            
        }
    }
}
