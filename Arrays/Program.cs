using System;

namespace Laboratorna3
{
    internal class Program
    {
        static void maxmin(float [] arr1, int size,   ref float minel, ref float maxel)
        {
            for (int i = 1; i < size; i++)
            {
                if (arr1[i] < minel)
                    minel = arr1[i];
                else if (arr1[i] > maxel)
                    maxel = arr1[i];

            }

        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Лабораторна #3, Каплаушенко М.В , ОФ-01, ФМФ");
            int size;
            float  minel, maxel;
            Console.WriteLine("Введіть розмір масиву:");
            size = Convert.ToInt32(Console.ReadLine());

            if (size == 0)
                return;

            float[] arr1 = new float[size];
            Console.WriteLine("Введіть елементи массиву:");
            for (int i = 0; i < size; i++)
                arr1[i] = float.Parse(Console.ReadLine());
            Console.WriteLine("Введений масив: ");
            foreach (int i in arr1)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            minel =  arr1[0];
            maxel = arr1[0];



            maxmin(arr1, size, ref maxel, ref minel);

            Console.Write("Мінімальний елемент масиву = ");
            Console.WriteLine(minel);

            Console.Write("Максимальний елемент массиву = ");
            Console.WriteLine(maxel);


            if (minel == maxel)
                return;


            //float ahe(float [] mas1)
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        if (arr1[i] == minel)
            //            arr1[i] = maxel;
            //        else if (arr1[i] == maxel)
            //            arr1[i] = minel;
            //    }
            //    return float[size];
            //}

            for(int i = 0; i < size; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            if (arr1[0] < arr1[1])
            {

                for (int i = 1; i < size; i++)
                {
                    float key = arr1[i];
                    int j = i - 1;
                    {
                        while (j >= 0 && arr1[j] > key)
                        {
                            arr1[j + 1] = arr1[j];
                            arr1[j] = key;
                            j--;
                        }

                    }
                }

                Console.WriteLine("\n");

                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr1[i] + " ");
                }
            }

            else
            {
                for (int i = 1; i < size; i++)
                {
                    float key = arr1[i];
                    int j = i - 1;
                    {
                        while (j >= 0 && arr1[j] < key)
                        {
                            arr1[j + 1] = arr1[j];
                            arr1[j] = key;
                            j--;
                        }

                    }
                }

                Console.WriteLine("\n");

                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr1[i] + " ");
                }
            }

            Console.ReadKey();


        }
    }
}
