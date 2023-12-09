// Дано число. Определите будет ли это число четным и кратным 10

using System;

class work_6_3
{
    static void Main()
    {
        Console.Write("Введите число: "); 
        float n = float.Parse(Console.ReadLine()); 

        if (n % 2 == 0 & n % 10 == 0)
        {
            Console.WriteLine($"Число {n} сотвецтвует условиям");  
        }
        else
        {
            Console.WriteLine($"Число {n} не сотвецтвует условиям"); 
        }
    }
}
