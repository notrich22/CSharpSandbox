using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            List<int> arr = new List<int>(size);
            Random r = new Random();
            for (int i = 0; i < size; i++)
            {
                arr.Add(r.Next(0, 10));
            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine($"arr{i} == {arr[i]}");
            }
            Console.WriteLine("/////////////////////////////////");
            for(int i = 0; i < arr.Count-1; i++)
            {
                if(arr[i] == 0)
                {
                    arr.RemoveAt(i);
                    arr.Add(-1);
                    i--;
                }
            }
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine($"arr{i} = {arr[i]}");
            }
            Console.WriteLine("/////////////////////////////////");
            int k = -1;
            while (k > 9 || k < 1){
            Console.Write("Введите число(0-9): ");
            k = Convert.ToInt32(Console.ReadLine()); 
            }
            int count = 0;
            for(int i = 0; i < arr.Count-1; i++)
            {
                if (arr[i] == k)
                    count++;
            }
            Console.WriteLine($"Число \"{k}\" встретилось {count} раз!");
            Console.WriteLine("/////////////////////////////////");
            int[,] Matrix = new int[size,size];
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Matrix[i,j] = i+j;
                    Console.Write($"{ Matrix[i, j]} \t") ;
                }
                Console.WriteLine();
            }
            Console.WriteLine("/////////////////////////////////");
            int row1 = -5, row2 = -5;
            while (row1 > size || row1 < 0 || row2 > size || row2 < 0)
            {
                Console.WriteLine("Введите индексы столбцов, которые хотите поменять местами (1-10): ");
                Console.Write("Row1:");
                row1 = Convert.ToInt32(Console.ReadLine())-1;
                Console.Write("Row2:");
                row2 = Convert.ToInt32(Console.ReadLine())-1;
            }
            int temp = 0;
            for(int i = 0; i < size; i++)
            {
                temp = Matrix[i, row1];
                Matrix[i, row1] = Matrix[i, row2];
                Matrix[i, row2] = temp;
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{ Matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
