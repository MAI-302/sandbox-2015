using System;
using System.Linq;
using System.Collections.Generic;

class charcount
{
	public static void Main()
	{
		Console.Write("Введите строку: ");
		string str = Console.ReadLine();
		var list = str.GroupBy(s => s)
					  .Select(g => new KeyValuePair<char,int>(g.First(), g.Count()))
					  .ToList();
		foreach(var x in list)
		{
			Console.WriteLine("Символ '{0}' появляется {1} раз(а)", x.Key, x.Value);
		}
	}
}
