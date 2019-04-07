using System;

namespace calc
{
    class Program
    {
        public static double Sum(double first, double second)
        {
            double result;

            result = first + second;

            return result;
        }

        public static double Minus(double first, double second)
        {
            double result;

            result = first - second;

            return result;
        }

        public static double Mult(double first, double second)
        {
            double result;

            result = first * second;

            return result;
        }

        public static double Div(double first, double second)
        {
            double result;

            result = first / second;

            return result;
        }

        static void Diff(double first, double second)
        {
            if (first > second)
                Console.WriteLine("Число " + first + " больше числа " + second + ".");
            else if (first == second)
                Console.WriteLine("Числа равны");
            else
                Console.WriteLine("Число " + first + " меньше числа " + second + ".");
        }

        public static double Sqrt(double first)
        {
            double result;

            result = Math.Sqrt(first);

            return result;
        }

        public static double Step(double first, double second)
        {
            double result;

            result = Math.Pow(first, second);

            return result;
        }
        static void Main(string[] args)
        {
            
                double a;
                double b;
                double result;
                double result2;
                char operation;

                Console.WriteLine("Введите первое число:");
                a = Convert.ToDouble(Console.ReadLine());
            
                Console.WriteLine("Введите второе число:");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите действие:");
                operation = Convert.ToChar(Console.ReadLine());

            if (operation == '+')
            {
                result = Sum(a,b);
                Console.WriteLine("Cумма равна " + result + ".");
            }

            else if (operation == '-')
            {
                result = Minus(a,b);
                Console.WriteLine("Разность равна " + result + ".");
            }

            else if (operation == '*')
            {
               result = Mult(a,b);
                Console.WriteLine("Результат умножения равен " + result + ".");
            }

            else if (operation == '/')
            {
                result = Div(a,b);
                Console.WriteLine("Результат деления равен " + result + ".");
            }

            else if (operation == '^')
            {
                result = Step(a, b);
                Console.WriteLine("Результат возведения числа " + a + " в степень " + b + " равно " + result + ".");
            }


            else if (operation == 's')
            {
                result = Sqrt(a);
                result2 = Sqrt(b);

                Console.WriteLine("Корень квадратный первого числа " + result + ".");
                Console.WriteLine("Корень квадратный второго числа " + result2 + ".");
            }
            else if (operation == '>')
            {
                Diff(a,b);
            }
            else
            {
                Console.WriteLine("Неизвестное действие");
            }
            Console.ReadKey();
        }
    }
}
