using System;

namespace Dyachenko5
{
    class Program
    {
        public struct ComplexCal
        {
            private float real;
            private float imaginary;

            public ComplexCal(float real, float imaginary)
            {
                this.real = real;
                this.imaginary = imaginary;
            }

            public ComplexCal(float imaginary)
            {
                this.real = 0;
                this.imaginary = imaginary;
            }

            public static ComplexCal operator +(ComplexCal one, ComplexCal two)
            {
                return new ComplexCal(one.real + two.real, one.imaginary + two.imaginary);
            }

            public static ComplexCal operator +(ComplexCal one, float imaginary)
            {
                return new ComplexCal(one.real, one.imaginary + imaginary);
            }

            public static ComplexCal operator -(ComplexCal one, ComplexCal two)
            {
                return new ComplexCal(one.real - two.real, one.imaginary - two.imaginary);
            }
            public static ComplexCal operator -(ComplexCal one, float imaginary)
            {
                return new ComplexCal(one.real, one.imaginary - imaginary);
            }

            public static ComplexCal operator *(ComplexCal one, ComplexCal two)
            {
                return new ComplexCal(((one.real * two.real) - (one.imaginary * two.imaginary)), ((one.real * two.imaginary) + (two.real * one.imaginary)));
            }

            public static ComplexCal operator *(ComplexCal one, float imaginary)
            {
                return new ComplexCal((-one.imaginary * imaginary), (one.real * imaginary));
            }


            public static ComplexCal operator /(ComplexCal one, ComplexCal two)
            {
                if (two.real == 0 && two.imaginary == 0)
                {
                    Console.WriteLine("Ділення на нуль");
                    return new ComplexCal(0, 0);
                }
                else
                    return new ComplexCal((one.real * two.real + one.imaginary * two.imaginary) / (two.real * two.real + two.imaginary * two.imaginary),
                        (two.real * one.imaginary - one.real * two.imaginary) / (two.real * two.real + two.imaginary * two.imaginary));

            }

            public static ComplexCal operator /(ComplexCal one, float imaginary)
            {
                if (imaginary == 0)
                {
                    Console.WriteLine("Ділення на нуль");
                    return new ComplexCal(0, 0);
                }
                else
                    return new ComplexCal((one.imaginary * imaginary) / (imaginary * imaginary),
                        (-one.real * imaginary) / (imaginary * imaginary));
            }



            public static void Addition(ComplexCal one, ComplexCal two)
            {
                ComplexCal third = one + two;
                third.Show();
            }

            public static void Addition(ComplexCal one, ComplexCal two, ComplexCal third)
            {
                ComplexCal fourth = one + two + third;
                fourth.Show();
            }

            public static void Addition(ComplexCal one, float imaginary)
            {
                ComplexCal two = one + imaginary;
                two.Show();
            }

            public static void Subtraction(ComplexCal one, ComplexCal two)
            {
                ComplexCal third = one - two;
                third.Show();
            }

            public static void Subtraction(ComplexCal one, ComplexCal two, ComplexCal third)
            {
                ComplexCal fourth = one - two - third;
                fourth.Show();
            }

            public static void Subtraction(ComplexCal one, float imaginary)
            {
                ComplexCal two = one - imaginary;
                two.Show();
            }

            public static void Multiplication(ComplexCal one, ComplexCal two)
            {
                ComplexCal third = one * two;
                third.Show();
            }

            public static void Multiplication(ComplexCal one, ComplexCal two, ComplexCal third)
            {
                ComplexCal fourth = one * two * third;
                fourth.Show();
            }

            public static void Multiplication(ComplexCal one, float imaginary)
            {
                ComplexCal two = one * imaginary;
                two.Show();
            }

            public static void Division(ComplexCal one, ComplexCal two)
            {
                ComplexCal third = one / two;
                if (two.real != 0 && two.imaginary != 0)
                    third.Show();
            }

            public static void Division(ComplexCal one, ComplexCal two, ComplexCal third)
            {
                ComplexCal fourth = one / two / third;
                fourth.Show();
            }
            public static void Division(ComplexCal one, float imaginary)
            {
                ComplexCal two = one / imaginary;
                if (imaginary != 0)
                    two.Show();
            }
            public void Show()
            {
                Console.WriteLine($"{real}+{imaginary}i");
            }


        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Лабораторна робота №5" 
                + "\nВиконала: студентка 2-го курсу" 
                + "\nгрупи ОФ-01, ФМФ" 
                + "\nКаплаушенко Марія");

            Console.WriteLine();

            Console.WriteLine("Задані числа: ");

            ComplexCal val1 = new ComplexCal(4, 4);
            ComplexCal val2 = new ComplexCal(-2, -2);
            ComplexCal val3 = new ComplexCal(4, 3);
            float val4 = 2;
            ComplexCal val5 = new ComplexCal(0, 0);

            Console.WriteLine(" z1 = 4 + 4i" + 
                "\n z2 = -2 - 2i" + 
                "\n z3 = 4 + 3i" + 
                "\n z4 = 2" + 
                "\n z5 = 0"); 

            Console.WriteLine();

            Console.WriteLine("Дії з 2 - ма комплексними числами.");

            Console.Write(" z1 + z2: ");
            ComplexCal.Addition(val1, val2);

            Console.Write(" z1 - z2: ");
            ComplexCal.Subtraction(val1, val2);

            Console.Write(" z1 * z2: ");
            ComplexCal.Multiplication(val1, val2);

            Console.Write(" z1 / z2: ");
            ComplexCal.Division(val1, val2);

            Console.WriteLine();

            Console.WriteLine("Дії з 3 - ма комплексними числами.");

            Console.Write(" z1 + z2 + z3: ");
            ComplexCal.Addition(val1, val2, val3);

            Console.Write(" z1 - z2 - z3: ");
            ComplexCal.Subtraction(val1, val2, val3);

            Console.Write(" z1 * z2 * z3: ");
            ComplexCal.Multiplication(val1, val2, val3);

            Console.Write(" z1 / z2 / z3: ");
            ComplexCal.Division(val1, val2, val3);

            Console.WriteLine();

            Console.WriteLine("Дії з комплексними та натуральними числами.");

            Console.Write(" z2 + z4: ");
            ComplexCal.Addition(val2, val4);

            Console.Write(" z2 - z4: ");
            ComplexCal.Subtraction(val2, val4);

            Console.Write(" z2 * z4: ");
            ComplexCal.Multiplication(val2, val4);

            Console.Write(" z2 / z4: ");
            ComplexCal.Division(val2, val4);

            Console.WriteLine();

            Console.WriteLine("Дії з 0.");
            Console.Write(" z3 / z5 : ");
            ComplexCal.Division(val3, val5);

            Console.ReadKey();

        }
    }
}