using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace KursovoiProject
{
    class MFI
    {
        private string verticles { get; set; }
        private string edge { get; set; }
        private int n;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vert">Все вершины</param>
        /// <param name="ed">Все рёбра</param>
        public MFI(string vert, string ed)
        {
            verticles = vert;//"2 6 7 5 7 4 3 5 6 3 2 5";
            edge = ed;//"2 4 7 8 10 11 12";
            n = edge.ToCharArray().Where(l => l == ' ').Count() + 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>В результате выполнения возвращает матрицу смежности.</returns>
        public int[,] get_result()
        {
            int[,] matrix = new int[n, n];
            //Формирование матрицы с МФО представления
            //if (verticles != "0" && edge != "")
                form_matrix(matrix);
            return matrix;
        }

        private void form_matrix(int[,] matrix)
        {
            int count_edge = 0;
            int step = 0; int i = -1;
            if (edge.ToCharArray().Where(l => l == '0').Count() != n)
            {
                while (verticles != "")
                {
                    i++;
                    if (edge.IndexOf(' ') > 0)
                    {
                        step = int.Parse(edge.Remove(edge.IndexOf(' '))) - count_edge;
                        edge = edge.Remove(0, edge.IndexOf(' ') + 1);
                    }
                    else
                    {
                        step = int.Parse(edge) - count_edge;
                        edge = "";
                    }
                    count_edge += step;
                    while (step != 0)
                    {
                        if (verticles.IndexOf(' ') > 0)
                        {
                            matrix[int.Parse(verticles.Remove(verticles.IndexOf(' '))) - 1, i] = 1;
                            verticles = verticles.Remove(0, verticles.IndexOf(' ') + 1);
                        }
                        else
                        {
                            matrix[int.Parse(verticles) - 1, i] = 1;
                            verticles = "";
                        }
                        step--;
                    }
                }
            }

        }
    }
}
