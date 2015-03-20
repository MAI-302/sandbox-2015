using System;
using System.Linq;

class anagram
{
    public static void Main()
    {
        Console.Write("Введите слово: ");
        string str = Console.ReadLine();
        
        int r = factorial(str.Length);
        str.GroupBy(s => s)
           .Select(g => g.Count())
           .ToList().ForEach(x => r /= factorial(x));
        
        Console.WriteLine("Количество анаграмм: {0}", r);
    }
    
    static int factorial(int a)
    {
        int f = 1;
        while(a > 1) f *= a--;
        return f;
    }
}
