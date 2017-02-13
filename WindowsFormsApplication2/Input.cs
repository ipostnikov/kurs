using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace KursovoiProject
{

    class Input
    {
        private bool f_exists(string path)
        {
            FileInfo fi = new FileInfo(path);
            if (fi.Exists)
                return false;
            else return true;
        }
        /// <summa
        /// test comment
        /// </summary>
        /// <param name="path"> path to file </param>
        /// <param name="v"> vertex </param>
        /// <param name="e"> edge </param>
        public void file_input(string path, out string v, out string e)
        {
            StreamReader read = new StreamReader(path);
            v = read.ReadLine();
            e = read.ReadLine();
            read.Close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"> vertex </param>
        /// <param name="e"> edge </param>
        /// <returns> if error find return error_message, else return empty message</returns>
        public string error_check(string v, string e)
        {
            string err = "";
            if (v.Length > 150)
                err = "Количество вершин превышает 50";
            else if (e.Length > 50)
                err = "Количество рёбер превышает 20";
            string[] vert = v.Split(' ');
            string[] edge = e.Split(' ');
            if (err=="")
            for (int i = 0; i < vert.Length; i++)
                if (vert[i] == "")
                    err = "Обнаружен некорректный символ";
                else if ((int)vert[i][0]<(int)'0' || (int)vert[i][0]>(int)'9')
                    err = "Обнаружен некорректный символ";
            if (err=="")
            for (int i = 0; i < edge.Length; i++)
                if (edge[i] == "")
                    err = "Обнаружен некорректный символ";
                else if ((int)edge[i][0] < (int)'0' || (int)edge[i][0] > (int)'9')
                    err = "Обнаружен некорректный символ";
            if (err == "")
            {
                if (e.ToCharArray().Where(l => l == '0').Count() > 0
                    && e.ToCharArray().Where(l => l == ' ').Count() < v.ToCharArray().Where(l => l == ' ').Count())
                    err = "Обнаружены лишние вершины";
                if (e.ToCharArray().Where(l => l == '0').Count() > 0
                    && v.ToCharArray().Where(l => l == ' ').Count() < e.ToCharArray().Where(l => l == ' ').Count())
                    err = "Обнаружены лишние рёбра";
            }
            if (err == "")
                if (e.ToCharArray().Where(l => l == '0').Count() == 0 && int.Parse(edge[edge.Length - 1]) != v.ToCharArray().Where(l => l == ' ').Count() + 1)
                    err = "Введите граф правильно" ;
            //else if (n > max_v)
            //    err = "Обнаруженa лишняя вершина " + e_arr[e_arr.Length - 1];
            return err;
        }
    }
}
