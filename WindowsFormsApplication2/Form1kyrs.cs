using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.GraphViewerGdi;
using Microsoft.Msagl.Drawing;
using System.IO;

namespace KursovoiProject
{
    public partial class Form1 : Form
    {
        string[] v = new string[2], e = new string[2];
        int[] d = new int[2];
        string[] del_v = new string[2];


        public Form1()
        {
            InitializeComponent();
            rb_manual.Checked = true;
            ofd.Filter = "Текстовые файлы |*.txt;*.doc";
        }

        private void find_result()
        {
                for (int j = 0; j < 2; j++)
                {
                    Input err = new Input();
                    string Error = err.error_check(v[j], e[j]);
                    if (Error == "")
                    {
                        //Формирование матрицы 
                        MFI x = new MFI(v[j], e[j]);
                        int[,] matrix = x.get_result();
                        int n = matrix.GetUpperBound(0) + 1;
                        //Формирование названия строк и столбцов
                        string[] row_name = new string[n], column_name = new string[n];
                        for (int i = 0; i < n; i++)
                            row_name[i] = (char)((int)'A' + i) + "";
                        //Поиск диаметра графа
                        Find_D D = new Find_D();
                        d[j] = 0;
                        if (j == 0)
                        {
                            rtb_res1.Text = D.get_result(out d[j], ref matrix, ref n, ref row_name, ref del_v[j]);
                            DrawGraph(matrix, n, row_name, GViever1);
                            tb_dv1.Text = del_v[j];
                            tb_d1.Text = d[j] + "";
                        }
                        else
                        {
                            rtb_res2.Text = D.get_result(out d[j], ref matrix, ref n, ref row_name, ref del_v[j]);
                            DrawGraph(matrix, n, row_name, GViever2);
                            tb_dv2.Text = del_v[j];
                            tb_d2.Text = d[j] + "";
                        }
                        if (j == 1)
                            if (d[0] == d[1])
                                MessageBox.Show("Графы эквивалентны");
                            else MessageBox.Show("Графы не эквивалентны");
                    }
                    else
                    {
                        MessageBox.Show("Граф №" + (j + 1) + ":" + Error);
                        clear();
                        break;
                    }
                }
        }

        int ToKey(int r, int c) { return r * 1000 + c; }
        private void DrawGraph(int[,] matrix, int n, string[] name, GViewer g)
        {
            Graph graph = new Graph();
            for (int i = 0; i < n; i++)
                graph.AddNode(name[i]);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (matrix[i, j] == 1)
                        graph.AddEdge(name[i] + "", name[j] + "");
            g.Graph = graph;
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rb_file_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_file.Checked == true)
            {
                tb_v1.Enabled = false;
                tb_v2.Enabled = false;
                tb_e1.Enabled = false;
                tb_e2.Enabled = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    StreamReader read_file = new StreamReader(@ofd.FileName);
                    try
                    {
                        tb_v1.Text = read_file.ReadLine();
                        tb_e1.Text = read_file.ReadLine();
                        tb_v2.Text = read_file.ReadLine();
                        tb_e2.Text = read_file.ReadLine();
                    }
                    catch (Exception exc) { MessageBox.Show("Неверное содержание файла"); }
                    read_file.Close();
                }
                else MessageBox.Show("Выберите поалуйста файл!");
                //FILE OPEN
            }
            else
            {
                tb_v1.Enabled = true;
                tb_v2.Enabled = true;
                tb_e1.Enabled = true;
                tb_e2.Enabled = true;
            }
        }

        private void clear(bool cl = false)
        {
            if (cl)
            {
                tb_v1.Text = "";
                tb_v2.Text = "";
                tb_e1.Text = "";
                tb_e2.Text = "";
            }
            rtb_res1.Text = "";
            rtb_res2.Text = "";
            tb_d1.Text = "";
            tb_dv1.Text = "";
            tb_d2.Text = "";
            tb_dv2.Text = "";
            v = new string[2];
            e = new string[2];
            d = new int[2];
            del_v = new string[2];
            GViever1.Graph = new Graph();
            GViever2.Graph = new Graph();
        }

        private void Resbutt_Click(object sender, EventArgs e)
        {
            clear();
            if (tb_v1.Text != "" &&  tb_v2.Text != "" || (tb_v1.Text == "0" && tb_e1.Text == "") || (tb_v2.Text == "0" && tb_e2.Text == ""))
            {
                v[0] = tb_v1.Text; v[1] = tb_v2.Text;
                this.e[0] = tb_e1.Text; this.e[1] = tb_e2.Text;
                find_result();
            }
            else MessageBox.Show("Введите сначала оба графа в MFI пред6ставлении");
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            clear(true);
        }
    }
}
