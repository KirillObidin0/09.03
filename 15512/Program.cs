using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15512
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(task5("kazak", "kazak"));
        }
        public static void task1()
        {
            //1.Создать коллекцию List<int> .
            //    Вывести на экран позицию и значение элемента, 
            //являющегося вторым максимальным значением 
            //    в коллекции.Вывести на экран сумму элементов 
            //    на четных позициях.

            int n = Int32.Parse(Console.ReadLine());
            Random rnd = new Random();
            List<int> vs = new List<int>();
            for (int i = 0; i < n; i++)
            {
                vs.Add(rnd.Next(1,100));
                Console.WriteLine(vs[i]);
            }
            Console.WriteLine();
            vs.Sort();
            Console.WriteLine(vs[vs.Count-2]);
        }
        public static void task2()
        {
            //2.Удалить все нечетные элементы списка List<int>
            int n = Int32.Parse(Console.ReadLine());
            Random rnd = new Random();
            List<int> vs = new List<int>();
            for (int i = 0; i < n; i++)
            {
                vs.Add(rnd.Next(1, 100));
                Console.WriteLine(vs[i]);
            }
            for (int i = 0; i < vs.Count; i++)
            {
                while (vs[i] % 2 != 0)
                    vs.RemoveAt(i);
            }
            Console.WriteLine();
            foreach (var item in vs)
            {
                Console.WriteLine(item);
            }
        }
        public static void task3()
        {
            //3.Дана коллекция типа List<double>.
            //    Вывести на экран элементы списка, 
            //значение которых больше среднего 
            //    арифметического всех элементов коллекции.

            int n = Int32.Parse(Console.ReadLine());
            Random rnd = new Random();
            List<double> vs = new List<double>();
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                vs.Add(rnd.Next(1, 100));
                Console.WriteLine(vs[i]);
                sum += vs[i];
            }
            Console.WriteLine();
            double average = sum / vs.Count;
            Console.WriteLine(average);
            Console.WriteLine();
            foreach (double item in vs)
            {
                if(item>average)
                    Console.WriteLine(item);
            }
        }
        public static void task4(string path)
        {
            //4.Напечатать содержимое текстового файла t, 
            //    выписывая литеры каждой его строки в обратном порядке.
            string[] arrStr = File.ReadAllLines(path);
            for (int i = 0; i < arrStr.Length; i++)
            {
                Console.WriteLine(arrStr[i].Reverse());
            }
        }
        public static bool task5(string s1,string s2)
        {
            //5.Даны 2 строки s1 и s2. 
            //    Из каждой можно читать по 
            //    одному символу.Выяснить, 
            //является ли строка s2 обратной s1.

            if (s1.Length != s2.Length)
                return false;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[s1.Length - 1 - i])
                    return false;
            }
            return true;
        }
        public static void task6(string path)
        {
            //6.Дан текстовый файл. За один просмотр 
            //    файла напечатать элементы файла в следующем 
            //    порядке: сначала все слова, начинающиеся на 
            //    гласную букву, потом все слова, начинающиеся 
            //    на согласную букву, сохраняя исходный порядок 
            //    в каждой группе слов.

            string str = File.ReadAllText(path);
            for (int i = 0; i < str.Length; i++)
            {
                if ((i == 0 || str[i - 1] == ' ') &&
                    (str[i] == 65 || str[i] == 69 || str[i] == 73 ||
                    str[i] == 79 || str[i] == 85 || str[i] == 89 ||
                    str[i] == 97 || str[i] == 101 || str[i] == 105 ||
                    str[i] == 111 || str[i] == 117 || str[i] == 121))
                {
                    Console.Write(str.Substring(i, str.IndexOf(' ', i) - i));
                    Console.Write(' ');
                }

            }
            Console.WriteLine();
            for (int i = 0; i < str.Length; i++)
            {
                if ((i == 0 || str[i - 1] == ' ') && (str[i] > 64 && str[i] < 123) &&
                    !(str[i] == 65 || str[i] == 69 || str[i] == 73 ||
                    str[i] == 79 || str[i] == 85 || str[i] == 89 ||
                    str[i] == 97 || str[i] == 101 || str[i] == 105 ||
                    str[i] == 111 || str[i] == 117 || str[i] == 121))
                {
                    Console.Write(str.Substring(i, str.IndexOf(' ', i) - i));
                    Console.Write(' ');
                }
            }

        } 
        public static void task7(string path)
        {
            //7.Дан файл, содержащий числа. 
            //    За один просмотр файла напечатать 
            //    элементы файла в следующем порядке: 
            //сначала все положительные числа, потом 
            //    все отрицательные числа, сохраняя 
            //    исходный порядок в каждой группе чисел.

            string str = File.ReadAllText(path);
            List<char> str2 = str.ToList();
            List<int> arr = new List<int>();
            foreach (char item in str2)
            {
                arr.Add(Int32.Parse(item.ToString()));
            }
            foreach (int item in arr)
            {
                if (item >= 0)
                {
                    Console.Write(item);
                    Console.Write(' ');
                }
                
            }
            Console.WriteLine();
            foreach (int item in arr)
            {
                if (item < 0)
                {
                    Console.Write(item);
                    Console.Write(' ');
                }
            }
        }  
    }
}
