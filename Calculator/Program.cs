using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double numberOne, numberTwo, Result;
            int enterAction;


            do
            {

                Console.Clear();
                Console.WriteLine("Выберите действие\n1.Сложение\n2.Вычитание\n3.Умножение\n4.Деление\n5.Степень\n6.Найти квадрат числа\n7.Найти 1% от числа\n8.Найти факториал\n9.Выход с Программы");
                enterAction = Convert.ToInt32(Console.ReadLine());

                switch (enterAction)
                {
                    case 1:

                        numberOne = Convert.ToDouble(Console.ReadLine());
                        numberTwo = Convert.ToDouble(Console.ReadLine());
                        Result = numberOne + numberTwo;
                        Console.WriteLine("Ваш ответ = " + Result);
                        System.Threading.Thread.Sleep(600);

                        break;

                    case 2:

                        numberOne = Convert.ToDouble(Console.ReadLine());
                        numberTwo = Convert.ToDouble(Console.ReadLine());
                        Result = numberOne - numberTwo;
                        Console.WriteLine("Ваш ответ = " + Result);
                        System.Threading.Thread.Sleep(600);

                        break;



                    case 3:

                        numberOne = Convert.ToDouble(Console.ReadLine());
                        numberTwo = Convert.ToDouble(Console.ReadLine());
                        Result = numberOne * numberTwo;
                        Console.WriteLine("Ваш ответ = " + Result);
                        System.Threading.Thread.Sleep(600);

                        break;

                    case 4:

                        numberOne = Convert.ToDouble(Console.ReadLine());
                        numberTwo = Convert.ToDouble(Console.ReadLine());
                        Result = numberOne / numberTwo;
                        Console.WriteLine("Ваш ответ = " + Result);
                        System.Threading.Thread.Sleep(600);

                        break;



                    case 5:

                        numberOne = Convert.ToDouble(Console.ReadLine());
                        numberTwo = Convert.ToDouble(Console.ReadLine());
                        Result = 1;
                        for (int i = 0; i < numberTwo; i++)
                        {
                            Result *= numberOne;
                        }

                        Console.WriteLine("Ваш ответ = " + Result);
                        System.Threading.Thread.Sleep(600);

                        break;



                    case 6:

                        numberOne = Convert.ToDouble(Console.ReadLine());
                        Result = Math.Sqrt(numberOne);
                        Console.WriteLine("Ваш ответ = " + Result);
                        System.Threading.Thread.Sleep(600);

                        break;


                    case 7:

                        numberOne = Convert.ToDouble(Console.ReadLine());
                        Result = numberOne / 100;
                        Console.WriteLine("Ваш ответ = " + Result);
                        System.Threading.Thread.Sleep(600);

                        break;


                    case 8:

                        numberOne = Convert.ToDouble(Console.ReadLine());
                        Result = 1;

                        for (int i = 1; i <= numberOne; i++)
                        {
                            Result *= i;
                        }

                        Console.WriteLine("Ваш ответ = " + Result);
                        System.Threading.Thread.Sleep(600);

                        break;

                    case 9:
                        break;
                }




            } while (enterAction != 9);




        }
    }
}
