using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pr03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            m1:
            // Даны три целых ненулевых числа. Найти среднее из этих чисел (т. е. число, расположенное между наименьшим и наибольшим числом).
            try
            {
                Console.Write("Введите первое целое ненулевое число: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.Write("Введите второе целое ненулевое число: ");
                int number2 = int.Parse(Console.ReadLine());

                Console.Write("Введите третье целое ненулевое число: ");
                int number3 = int.Parse(Console.ReadLine());
                int minNumber = Math.Min(number1, Math.Min(number2, number3));
                int maxNumber = Math.Max(number1, Math.Max(number2, number3));
                int averageNumber = number1 + number2 + number3 - minNumber - maxNumber;

                Console.WriteLine("Среднее из введенных чисел: " + averageNumber);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                goto m1;
            }
            Console.ReadKey();
            // Дано целое число N (N > 0). Вывести произведение 1*2*3*...*N. Чтобы избежать целочисленного переполнения, вычислять это произведение с помощью вещественной переменной и выводить его на экран как вещественное число. Пример для числа 5 - 1*2*3*4*5=120.
            m2:           
            try
            {
                Console.Write("Введите целое число N (N > 0): ");
                int N = int.Parse(Console.ReadLine());

                if (N <= 0)
                {
                    Console.WriteLine("N должно быть больше 0.");
                }
                else
                {
                    double product = 1.0; 

                    for (int i = 1; i <= N; i++)
                    {
                        product *= i;
                    }

                    Console.WriteLine("Произведение от 1 до " + N + " = " + product);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                goto m2;
            }
            Console.ReadKey();
            // В вещественном массиве хранятся сведения о количестве осадков, выпавших за каждый день месяца N (в месяце должно быть 30 дней). Определить общее количество осадков, выпавших за каждую декаду этого месяца (декада состоит из 10 дней). Предоставить возможность пользователю реализовать заполнение элементов массива случайными (рандомными) числами.
            m3:            
            try {
                const int DaysInMonth = 30;
                const int DaysInDecade = 10;

                double[] rainfallData = new double[DaysInMonth];

                Console.WriteLine("Выберите способ заполнения массива:");
                Console.WriteLine("1. Вручную");
                Console.WriteLine("2. Автоматически случайными числами");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    for (int i = 0; i < DaysInMonth; i++)
                    {
                        Console.Write($"Введите количество осадков для {i + 1}-го дня: ");
                        rainfallData[i] = double.Parse(Console.ReadLine());
                    }
                }
                else if (choice == 2)
                {
                    Random random = new Random();
                    for (int i = 0; i < DaysInMonth; i++)
                    {
                        rainfallData[i] = random.NextDouble() * 10;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный выбор.");
                    return;
                }
                for (int decade = 0; decade < DaysInMonth / DaysInDecade; decade++)
                {
                    double decadeTotal = 0;
                    for (int day = decade * DaysInDecade; day < (decade + 1) * DaysInDecade; day++)
                    {
                        decadeTotal += rainfallData[day];
                    }

                    Console.WriteLine($"Общее количество осадков за {decade + 1}-ю декаду: {decadeTotal}");
                }
            }
            catch(FormatException e) 
            {
                Console.WriteLine(e.Message);
                goto m3;
            }
            Console.ReadKey();
            // Дан целочисленный массив, состоящий из N элементов (N > 0, N может быть четным или нечетным числом). Поменять порядок следования его элементов на обратный. Вычислить и вывести сумму и произведение всех его элементов.
            m4:
            try
            {
                Console.Write("Введите количество элементов в массиве (N > 0): ");
                int N = int.Parse(Console.ReadLine());

                if (N <= 0)
                {
                    Console.WriteLine("N должно быть больше 0.");
                    return;
                }

                int[] array = new int[N];

                Console.WriteLine("Введите элементы массива:");

                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Array.Reverse(array);

                Console.WriteLine("Массив с обратным порядком элементов:");
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                int sum = 0;
                int product = 1;

                foreach (int element in array)
                {
                    sum += element;
                    product *= element;
                }

                Console.WriteLine("\nСумма элементов массива: " + sum);
                Console.WriteLine("Произведение элементов массива: " + product);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                goto m4;
            }
            Console.ReadKey();
            // Дан целочисленный массив, состоящий из N элементов (N > 0). Найти сумму и произведение всех четных чисел из данного массива.
            m5:
            try
            {
                Console.Write("Введите количество элементов в массиве (N > 0): ");
                int N = int.Parse(Console.ReadLine());

                if (N <= 0)
                {
                    Console.WriteLine("N должно быть больше 0.");
                    return;
                }

                int[] array = new int[N];

                Console.WriteLine("Введите элементы массива:");

                for (int i = 0; i < N; i++)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    array[i] = int.Parse(Console.ReadLine());
                }

                int sumOfEven = 0;
                int productOfEven = 1;

                foreach (int element in array)
                {
                    if (element % 2 == 0) 
                    {
                        sumOfEven += element;
                        productOfEven *= element; 
                    }
                }

                Console.WriteLine("Сумма четных элементов массива: " + sumOfEven);
                Console.WriteLine("Произведение четных элементов массива: " + productOfEven);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                goto m5;
            }
            Console.ReadKey();
        }
    }
}
