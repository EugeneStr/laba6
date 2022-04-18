using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace laba6
{
    class Class1
    {
        public double fun(double x, double y)
        {
            return y / (Math.Log2(x));
        }

        private double[] Data(double z0, double zk, double hz)
        {
            int Nz = Convert.ToInt32((zk - z0) / hz);
            double[] z = new double[Nz + 1];
            for (int i = 0; i <= Nz; i++)
            {
                z[i] = z0 + i * hz;
            }
            return z;
        }

        public void main(ListBox file_listBox, TrackBar trackBar1, ListBox listBox_res)
        {
            try
            {
                file_listBox.Items.Clear();
                double[,] InData = initial_data(trackBar1.Value);
                for (int k = 0; k < trackBar1.Value; k++)
                {
                    string filename = Path.Combine(Environment.CurrentDirectory, "G" + string.Format("{0:d4}", k + 1) + ".dat");
                    double x0 = InData[k, 0];
                    double xk = InData[k, 1];
                    double hx = InData[k, 2];
                    double y0 = InData[k, 3];
                    double yk = InData[k, 4];
                    double hy = InData[k, 5];
                    double[] x = Data(x0, xk, hx);
                    double[] y = Data(y0, yk, hy);
                    using (FileStream fstream = new FileStream(filename, FileMode.Create))
                    {
                        using (BinaryWriter writer = new BinaryWriter(fstream, Encoding.ASCII))
                        {
                            for (int i = 0; i < x.Length; i++)
                            {
                                for (int j = 0; j < y.Length; j++)
                                {
                                    writer.Write(x[i]);
                                    writer.Write(y[j]);
                                    writer.Write(fun(x[i], y[j]));
                                    listBox_res.Items.Add("G" + string.Format("{0:d4}", k + 1) + ".dat" + "(" + x[i] + ";" + y[j] + ") = " + fun(x[i], y[j]));
                                }
                            }
                        }

                    }
                    file_listBox.Items.Add(filename);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат исходных данных", "ERROR");
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Необходимо ввести все исходные данные в файл", "ERROR");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Необходимо ввести полные наборы исходных", "ERROR");
            }
        }

        public void Read_File(string filename, ListBox listBox_x, ListBox listBox_y)
        {
            HashSet<double> x_list = new HashSet<double>();
            HashSet<double> y_list = new HashSet<double>();
            double x;
            double y;
            listBox_x.Items.Clear();
            listBox_y.Items.Clear();
            using (FileStream fstream = new FileStream(filename, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fstream, Encoding.ASCII))
                {
                    while (reader.PeekChar() != -1)
                    {
                        x = reader.ReadDouble();
                        y = reader.ReadDouble();
                        if (!x_list.Contains(x))
                        {
                            x_list.Add(x);
                            listBox_x.Items.Add(x);
                        }
                        if (!y_list.Contains(y))
                        {
                            y_list.Add(y);
                            listBox_y.Items.Add(y);
                        }
                        if (reader.PeekChar() != -1)
                        {
                            reader.ReadDouble();
                        }
                    }
                }
            }
            int count = x_list.Count * y_list.Count * 3;
        }

        public void output_result(string filename, ListBox listBox_x, ListBox listBox_y, TextBox res_textbox)
        {
            int x = listBox_x.SelectedIndex + 1;
            int y = listBox_y.SelectedIndex + 1;
            using (FileStream fstream = new FileStream(filename, FileMode.Open))
            {
                using (BinaryReader reader = new BinaryReader(fstream, Encoding.ASCII))
                {
                    if (reader.PeekChar() != -1)
                    {
                        for (int i = 0; i < (((x - 1) * listBox_y.Items.Count * 3) + (3 * y)) - 1; i++)
                        {
                            reader.ReadDouble();
                        }
                        double res = reader.ReadDouble();
                        res_textbox.Text = res.ToString();
                    }
                }
            }
        }

        public double[,] initial_data(int k)
        {
            double[,] data_xy = new double[k, 6];
            string datafile = "Calc.ini";
            string[] line;
            for (int n = 0; n < k; n++)
            {
                string temp = File.ReadLines(datafile).Skip(n).First();
                line = temp.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < 6; i++)
                {
                    data_xy[n, i] = Convert.ToDouble(line[i]);
                }
            }
            return data_xy;
        } 
    }
}
