// Строки
using System;

namespace String
{
    class Program
    {
        public static void Main()
        {
            // Строка - это последовательность символов. 
            string myString = "Hello world";

            // "+" - это символ приписывания, одной строки к другой. 
            string s = "Hello " + " " + " world";

            // Так-же, можно обращаться к отдельным символам
            char c = myString[1]; // 'e' - нумирация символов с нуля. 
            char myChar = 'e'; // Одинарные ковычки используются для символов. Двойные для строк. 


        }
    }
}