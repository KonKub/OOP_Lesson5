using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson5
{

//1. Создать класс рациональных чисел.
//   В классе два поля – числитель и знаменатель.
//   Предусмотреть конструктор.
//   Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, – , ++, --.
//   Переопределить метод ToString() для вывода дроби.
//   Определить операторы преобразования типов между типом дробь, float, int.
//   Определить операторы *, /, %.
//2. (*) На перегрузку операторов.
//   Описать класс комплексных чисел.
//   Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух комплексных чисел.
//   Переопределить метод ToString() для комплексного числа.
//   Протестировать на простом примере.

    class Program
    {

        static void Main(string[] args)
        {
            void TestRationalNumbers(RationalNumber rn1, RationalNumber rn2)
            {
                bool resultBool;
                RationalNumber result = new RationalNumber();

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Дробь1: {rn1.ToString()}.    Дробь2: {rn2.ToString()}");
                Console.WriteLine();

                if (rn1 == rn2) resultBool = true; else resultBool = false;
                Console.WriteLine($"(Дробь1 = Дробь2) - {resultBool}");

                if (rn1 != rn2) resultBool = true; else resultBool = false;
                Console.WriteLine($"(Дробь1 != Дробь2) - {resultBool}");

                if (rn1 < rn2) resultBool = true; else resultBool = false;
                Console.WriteLine($"(Дробь1 < Дробь2) - {resultBool}");

                if (rn1 > rn2) resultBool = true; else resultBool = false;
                Console.WriteLine($"(Дробь1 > Дробь2) - {resultBool}");

                if (rn1 <= rn2) resultBool = true; else resultBool = false;
                Console.WriteLine($"(Дробь1 <= Дробь2) - {resultBool}");

                if (rn1 >= rn2) resultBool = true; else resultBool = false;
                Console.WriteLine($"(Дробь1 >= Дробь2) - {resultBool}");

                Console.WriteLine();

                result = rn1 + rn2;
                Console.WriteLine($"Дробь1 + Дробь2 = {result.ToString()}");
                result = rn1 - rn2;
                Console.WriteLine($"Дробь1 - Дробь2 = {result.ToString()}");
                result = rn1++;
                Console.WriteLine($"Дробь1++ = {result.ToString()}");
                result = rn1--;
                Console.WriteLine($"Дробь1-- = {result.ToString()}");

                Console.WriteLine();

                result = rn1 * rn2;
                Console.WriteLine($"Дробь1 * Дробь2 = {result.ToString()}");
                result = rn1 / rn2;
                Console.WriteLine($"Дробь1 / Дробь2 = {result.ToString()}");
                int Res = rn1 % rn2;
                Console.WriteLine($"Дробь1 % Дробь2 = {Res}");
            }

            void TestComplexNumbers(ComplexNumber cn1, ComplexNumber cn2)
            {
                bool resultBool;
                ComplexNumber result = new ComplexNumber();

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Число1: {cn1.ToString()}.    Число2: {cn2.ToString()}");
                Console.WriteLine();

                if (cn1 == cn2) resultBool = true; else resultBool = false;
                Console.WriteLine($"(Число1 = Число2) - {resultBool}");

                if (cn1 != cn2) resultBool = true; else resultBool = false;
                Console.WriteLine($"(Число1 != Число2) - {resultBool}");

                Console.WriteLine();

                result = cn1 + cn2;
                Console.WriteLine($"Число1 + Число2 = {result.ToString()}");
                result = cn1 - cn2;
                Console.WriteLine($"Число1 - Число2 = {result.ToString()}");
                result = cn1 * cn2;
                Console.WriteLine($"Число1 * Число2 = {result.ToString()}");

                Console.WriteLine();
            }

            RationalNumber rnum1 = new RationalNumber();
            RationalNumber rnum2 = new RationalNumber();

            Console.WriteLine("Проверка класса рациональных чисел.");
            Console.WriteLine("===============================================");
            Console.WriteLine();

            rnum1.Numerator = 1;
            rnum1.Denominator = 2;
            rnum2.Numerator = 3;
            rnum2.Denominator = 5;

            TestRationalNumbers(rnum1,rnum2);

            rnum1.Numerator = 4;
            rnum1.Denominator = 17;
            rnum2.Numerator = 4;
            rnum2.Denominator = 17;

            TestRationalNumbers(rnum1, rnum2);

            ComplexNumber cnum1 = new ComplexNumber();
            ComplexNumber cnum2 = new ComplexNumber();

            Console.WriteLine();
            Console.WriteLine("Проверка класса комплексных чисел.");
            Console.WriteLine("===============================================");
            Console.WriteLine();

            cnum1.RealVal = 5;
            cnum1.ImaginaryVal = 17;
            cnum2.RealVal = 22;
            cnum2.ImaginaryVal = 100;

            TestComplexNumbers(cnum1, cnum2);

            cnum1.RealVal = 1;
            cnum1.ImaginaryVal = 2;
            cnum2.RealVal = 1;
            cnum2.ImaginaryVal = 2;

            TestComplexNumbers(cnum1, cnum2);


            Console.ReadKey();
        }
    }
}
