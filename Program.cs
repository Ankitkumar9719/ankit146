using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class Project
    {
        static void Q1()
        {
            int[] arr = { 200, -150, 340, 500, -100 };

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine(sum);
        }


        static void Q2()
        {
            float[] arr = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
            float sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            float avg = sum / arr.Length;

            Console.WriteLine(avg);
        }

        static void Q3()
        {
            int[] arr = { 1500, 2300, 999, 3200, 1750 };
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine(max);
        }

        static void Q4()
        {
            int[] arr = { 102, 215, 324, 453, 536 };
            int mCount = 0;
            int fCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    mCount++;
                }
                else
                {
                    fCount++;
                }
            }
            Console.WriteLine("Male: " + mCount + " Female: " + fCount);
        }

        static void Q5()
        {
            int[] arr = { 101, 202, 303, 404, 505 };

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Q6()
        {
            int[] arr = { 2, 4, 6, 8 };
            int fact = 3;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * fact;
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void Q7()
        {
            int[] arr = { 101, 203, 304, 405, 506 };
            int value = 304;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void Q8()
        {
            int[] arr = { 56, 78, 89, 45, 67 };
            Array.Sort(arr);

            int min = arr[0];
            int min2 = -1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != min)
                {
                    min2 = arr[i];
                    break;
                }
            }

            Console.WriteLine(min2);
        }

        static void Q9()
        {
            int[] arr = { 102, 215, 102, 324, 215 };

            List<int> l = new List<int>();
            HashSet<int> seen = new HashSet<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!seen.Contains(arr[i]))
                {
                    seen.Add(arr[i]);
                    l.Add(arr[i]);
                }
            }

            foreach (int i in l)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void Q10()
        {
            int[] data1 = { 1, 2, 3, 4, 5 };
            int[] data2 = { 3, 4, 5, 6, 7 };

            for (int i = 0; i < data1.Length; i++)
            {

                for (int j = 0; j < data2.Length; j++)
                {
                    if (data1[i] == data2[j])
                    {
                        Console.Write(data1[i] + " ");
                        break;
                    }
                }
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Q1();
            Q2();
            Q3();
            Q4();
            Q5();
            Q6();
            Q7();
            Q8();
            Q9();
            Q10();
        }
    }
}