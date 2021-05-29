// Арифметические операции

using System;

namespace ArithmeticOperation
{
    class Program
    {
        public static void Main()
        {
            // БИНАРНЫЕ АРИФМЕТИЧЕСКИЕ ОПЕРАЦИИ

            // ОПЕРАЦИЯ СЛОЖЕНИЯ ДВУХ ЧИСЕЛ
            int x = 10;
            int z = x + 15; // Результат равен: 25

            // ОПЕРАЦИЯ ВЫЧИТАНИЯ ДВУХ ЧИСЕЛ
            int x = 30;
            int z = x - 20; // Результат равен: 10
            
            // ОПЕРАЦИЯ УМНОЖЕНИЯ ДВУХ ЧИСЕЛ
            int x = 30;
            int z = x * 50; // Резульат равен: 1500

            // ОПЕРАЦИЯ ДЕЛЕНИЯ ДВУХ ЧИСЕЛ
            int x = 60;
            int z = x / 20; // Результат равен: 3

            double a = 10;
            double b = 3;
            double c = a / b; // Результат равен: 3.33333333

            // Если оба операнда при делении предстовляют целые числа - стоит учитывать, что при делении они будут округляться до целого числа
            double z = 10 / 4; // Результат равен: 2

            // В итоге результат операции помещенную в переменную "double", позволяет сохранить дробную часть
            // Но в самой операции участвуют два литерала: по умолчанию расматриваются как объекты "int"
            // Следовательно, результат будет целочисленным

            // Для этого, нужно определять литералы или переменные как "double" или "float"
            double z = 10.0 / 4.0; // Результат равен: 2.5

            // Операция получения остатка от целочисленного деления двух чисел
            double x = 10.0;
            double z = x % 4.0; // Результат равен: 2

            // УНАРНЫЕ ОПЕРАЦИИ

            // Операция инкремента
            // Инкремент бывает префиксным: значение переменной увеличивается на 1, потом ее значение возврощается в качестве результата операции
            int x1 = 5;
            int z1 = ++x1; // z1 = 6, x1 = 6
            Console.WriteLine($"{x1} - {z1}");

            // Существует постфиксный инкремент: значение переменной возврощается в качестве результата операции, затем к нему прибовляется 1
            int x2 = 5;
            int z2 = x2++; // z2 = 5, x2 = 6
            Console.WriteLine($"{x2} - {z2}");

            // Операция декремента. Уменьшение занчения на еденицу. 
            // Декремент, как-же имеет префиксную и постфиксную форму. 
            int x1 = 5;
            int z1 = --x1; // z1 = 4, x1 = 4
            Console.WriteLine($"{x1} - {z1}");

            // Постфиксная форма
            int x2 = 5;
            int z2 = x2--; // z2 = 5, x2 = 4
            Console.WriteLine($"{x2} - {z2}");
            
            // Если выполняется несколько арифметических операций, нужно учитывать порядок их выполнения
            // Приоритет операций: от высшего к низшему
            
            // Инкремент, дикремент
            // Умножение, деление, получение остатка
            // Сложение, вычитание

            // Для изменения следования порядка операции - используются скобки
            // Пример: набор операций
            int a = 3;
            int b = 5;
            int c = 40;
            int d = c ---b * a; // a = 3, b = 5, c = 39, d = 25
            Console.WriteLine($"a = {a} b = {b} c = {c} d = {d}");
            

            





        }
    }   
}