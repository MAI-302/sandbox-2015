using System;

class parentheses
{
	public static void Main()
	{
		Console.Write("Введите выражение: ");
		string str = Console.ReadLine();
		
		int level = 0;
		foreach(char a in str)
		{
			if(a == '(')
			{
				++level;
			}
			else if(a == ')')
			{
				if(--level < 0)
				{
					Console.WriteLine("Ошибка: лишняя закрывающая скобка!");
					return;
				}
			}
		}
		if(level != 0)
		{
			Console.WriteLine("Ошибка: имеются незакрытые скобки!");
			return;
		}
		
		Console.WriteLine("Скобки расставлены верно.");	
	}
}
