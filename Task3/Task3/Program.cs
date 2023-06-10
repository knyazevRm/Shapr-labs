/*
 * №12
 * Создать объект класса Простая дробь, используя класс Число.
 * Методы: вывод, сложение, вычитание, умножение, деление.
*/

using Task3;

namespace ConsoleApplication
{
    class OperationWithFraction
    {
        static void Main()
        {
            var a = new Fraction(10, 4); // 5 / 2
            var a_1 = new Fraction(10, -4); // 5 / 2
            var b = new Fraction(1, 2);
            Console.WriteLine(a_1);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(-a);   // output: -5 / 2
            Console.WriteLine(a + b);  // output: 3 / 1
            Console.WriteLine(a - b);  // output: 2 / 1
            Console.WriteLine(a * b);  // output: 5 / 4
            Console.WriteLine(a / b);  // output: 5 / 1
            b = new Fraction(20, 8);
            Console.WriteLine(a.Equals(b));
        }
    }
}