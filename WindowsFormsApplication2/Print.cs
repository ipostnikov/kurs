using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KursovoiProject
{
    class Print
    {
        public static string print_matrix(int[,] a, int n, string[] row_name, string[] column_name)
        {
            string print = "";
            int c = 0;
            for (int i = 0; i < row_name.Length; i++)
            {
                if (c < row_name[i].Length)
                    c = row_name[i].Length;
                if (c < column_name[i].Length)
                    c = column_name[i].Length;
            }
            c += 2;

            //ячейка с названием столбца и строк - имя таблицы
            for (int i = 0; i < c + 1; i++)
                print += " ";

            //Название стобцов
            for (int i = 0; i < n; i++)
            {
                print += row_name[i];

                for (int j = 0; j < c - row_name[i].Length; j++)
                    print += " ";
            }

            for (int i = 0; i < n; i++)
            {
                //Название строк
                print += "\r\n" + column_name[i];
                for (int l = 0; l < c - column_name[i].Length + 1; l++)
                    print += " ";
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] > 0)
                        print += a[i, j];
                    else print += " ";

                    for (int l = 0; l < c - a[i, j].ToString().Length; l++)
                        print += " ";
                }
            }
            print += "\r\n";
            return print;
        }
    }
}
