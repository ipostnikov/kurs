using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KursovoiProject
{
    class Find_D
    {
        public string get_result(out int D, ref int[,] matrix, ref int n, ref string[] row_name, ref string delete_vertex)
        {
            //Исходная матрица
            string res = "Исходная матрица :\r\n" + Print.print_matrix(matrix, n, row_name,row_name);
            if (n == 1)
                D = 0;
            else
            {
                matrix = removal_of_pendant_vertices(matrix, ref n, ref row_name, ref delete_vertex);
                res += "\r\n\r\nМатрица после удаления висячих вершин:\r\n" + Print.print_matrix(matrix, n, row_name, row_name);
                matrix = matrix_distance(matrix, n);
                res += "\r\n\r\nМатрица расстояний:\r\n" + Print.print_matrix(matrix, n, row_name, row_name);
                D = get_diametr(matrix, n);
            }
            res += "\r\nДиаметр графа : " + D;
            return res;
        }

        private int[,] matrix_distance(int[,] matrix,int n)
        {
            int[,] m_mult = new int[n, n];
            int i = 0, k = 0;

            //Перепись матриц
            for (i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    m_mult[i, j] = matrix[i, j];

            int step = 2;
            string pass_v = "", need_pass_v="";
            i = 0;
            while (true)
            {
                int count_v = 0;//Количество пройденыйх вершин
                //Просматриваем пути с i-той вершины
                for (int j = 0; j < n; j++)
                {
                    //если путь существует и мы его не проходили тогда путь из k-й вершины в j-ю равен step
                    if (m_mult[i, j] == 1 && !pass_v.Contains(j + "") && !need_pass_v.Contains(j + ""))
                    {
                        need_pass_v += j + " ";
                        if (m_mult[k, j] == 0)
                            m_mult[k, j] = step;
                        count_v++;
                    }
                    //Увеличение шага
                    if (j == n - 1 & count_v > 0)
                        need_pass_v += "+ ";
                }
                pass_v += i.ToString() + " ";

                //Увеличение шага
                if (need_pass_v != "")
                    if (need_pass_v.Substring(0, need_pass_v.IndexOf(" ")) == "+")
                    {
                        step++;
                        need_pass_v = need_pass_v.Remove(0, need_pass_v.IndexOf(" ") + 1);
                    }
                    //переход на следующую вершину
                    if (need_pass_v.Length > 0)
                    {
                        i = int.Parse(need_pass_v.Substring(0, need_pass_v.IndexOf(" ")));
                        need_pass_v = need_pass_v.Remove(0, need_pass_v.IndexOf(" ") + 1);
                    }
                //обнуление переменных для следующей итерации
                if (need_pass_v.Length == 0)
                {
                    int sum = 0;
                    for (int j = 0; j < n; j++)
                        sum += m_mult[j, k];
                    if (sum != 0)
                        m_mult[k, k] = 2;
                    i = ++k;
                    step = 2;
                    pass_v = "";
                }
                if (k==n)
                    break;
            }
            return m_mult;
        }

        private int[,] removal_of_pendant_vertices(int[,] matrix, ref int n, ref string[] row_name, ref string compression_v)
        {
            int k = 0, l = 0;
            compression_v = "";

            for (int i = 0; i < n; i++)
            {
                int sum_r = 0, sum_c = 0;
                for (int j = 0; j < n; j++)
                    //Если вершина не была удалена - переписываем матрицу в новую
                    if (!compression_v.Contains(j + "@"))
                    {
                        sum_r += matrix[i, j];
                        sum_c += matrix[j, i];
                    }
                if (sum_r == 1 & sum_c == 1)
                    compression_v += i + "@";
            }
            //Изменяем размерность матрицы
            n -= compression_v.ToCharArray().Where(c => c == '@').Count();
            //Удалённые вершины
            if (compression_v != "")
            {
                string[] vert = compression_v.Remove(compression_v.Length - 1).Split('@');
                string d_vert = "";
                for (int i = 0; i < vert.Length; i++)
                    d_vert += row_name[int.Parse(vert[i])] + "  ";
                //Удаляем из массива названия вершин те вершины, которые были сжаты
                string[] new_row_name = new string[n];
                for (int i = 0; i < row_name.Length; i++)
                    if (!compression_v.Contains(i + "@"))
                        new_row_name[l++] = row_name[i];
                Array.Resize(ref row_name, n);
                row_name = new_row_name;

                l = 0;
                //Удаляем вершину
                int[,] MS = new int[n, n];
                for (int i = 0; i < n + compression_v.ToCharArray().Where(c => c == '@').Count(); i++)
                    if (!compression_v.Contains(i + "@"))
                    {
                        for (int j = 0; j < n + compression_v.ToCharArray().Where(c => c == '@').Count(); j++)
                            if (!compression_v.Contains(j + "@"))
                                MS[k, l++] = matrix[i, j];
                        k++; l = 0;
                    }
                compression_v = d_vert;
                return MS;
            }
            else return matrix;
        }

        private int get_diametr(int[,] matrix, int n)
        {
            int d = int.MinValue;
            //Поиск максимального значений из максимальных по строкам
            for (int i = 0; i < n; i++)
            {
                int max = matrix[i, 0];
                for (int j = 1; j < n; j++)
                    if (max < matrix[i, j])
                        max = matrix[i, j];
                if (max > d)
                    d = max;
            }
            return d;
        }
    }
}
