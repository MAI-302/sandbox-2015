// Своего рода лаунчер для всех задач
// Выводит меню для запуска любой из них
// Использует чоткую™ консольную псевдографику
using System;

class small_tasks
{
    static task[] tasks = new task[]
    {
        new task("Anagram", global::anagram.Main, new[]{
            "С клавиатуры вводится слово. Найти количество анаграмм"
        }),
        new task("Parentheses", global::parentheses.Main, new[]{
            "С клавиатуры вводится выражение. Проверить, все ли скобки",
            "расставлены верно"
        }),
        new task("IdentProd", global::identprod.Main, new[]{
            "Дана квадратная матрица. Определить, является ли она",
            "произведением числа и единичной матрицы"
        }),
        new task("CharCount", global::charcount.Main, new[]{
            "Найти количество появлений каждого символа из имеющихся",
            "в строке"
        }),
        new task("Determinant", global::determinant.Main, new[]{
            "Дана квадратная матрица. Найти ее определитель."
        }),
        new task("Average", global::average.Main, new[]{
            "С клавиатуры вводится длина целочисленного массива.",
            "Элементы массива генерируются случайным образом. Создать",
            "на его основе массив из средних арифметических соседних",
            "элементов"
        }),
        new task("MinMax", global::minmax.Main, new[]{
            "Найти минимальный из максимальных элементов строк",
            "двумерного массива"
        })
    };
    
    struct task
    {
        public delegate void Main_t();
        
        public task(string name, Main_t mainfn, string[] desc)
        {
            this.name = name;
            this.mainfn = mainfn;
            this.desc = desc;
        }
        public string name;
        public Main_t mainfn;
        public string[] desc;
    }
    
    static void Main()
    {
        int selected = 0;
        while(true)
        {           
            Console.Clear();    //немного некрасивого кода рисования ascii-графики ;)
            Console.WriteLine();
            
            // Хедер:
            Console.WriteLine("  \x2554" + new string('\x2550', 59) + "\x2557");
            Console.WriteLine("  \x2551 {0,-57} \x2551", "");
            Console.WriteLine("  \x2551 {0,35}{1,24}", "Мелкие задачи", '\x2551');
            Console.WriteLine("  \x2551 {0,-57} \x2551", "");
            Console.WriteLine("  \x2560" + new string('\x2550', 59) + "\x2563");
            Console.WriteLine("  \x2551 {0,-57} \x2551", "");
            
            // Меню:
            for(int i = 0; i < tasks.Length; i++)
            {
                char ch = (i == selected) ? '\x25ba' : ' '; // 0x25ba - символ стрелки
                Console.WriteLine("  \x2551{0,22} {1}. {2,-33}\x2551", ch, i + 1, tasks[i].name);
            }
            Console.WriteLine("  \x2551 {0,-57} \x2551", "");
            
            // Блок описания - заголовок:
            Console.WriteLine("  \x255f" + new string('\x2500', 59) + "\x2562");
            Console.WriteLine("  \x2551 {0}. {1,-54} \x2551", selected + 1, tasks[selected].name);
            Console.WriteLine("  \x255f" + new string('\x2500', 59) + "\x2562");
            
            // Блок описания - описание:
            for(int i = 0; i < 4; i++)
            {
                string dstr = (i < tasks[selected].desc.Length) ? tasks[selected].desc[i] : "";
                Console.WriteLine("  \x2551 {0,-57} \x2551", dstr);
            }
            
            // Футер:
            Console.WriteLine("  \x2551 {0,-57} \x2551", "");
            Console.WriteLine("  \x255a" + new string('\x2550', 59) + "\x255d");
            
            // Хелп строка:
            Console.WriteLine("    {0,-20} {1,-20} {2,15}", "\x2191\x2193 - Выбор",
                    "Enter - Запуск", "Esc - Выход");
                    
            // Обработка нажатий
            switch(Console.ReadKey(true).Key)
            {
                case ConsoleKey.Escape:
                    Console.Clear();
                    return;
                case ConsoleKey.DownArrow:
                    if(selected < tasks.Length - 1) selected++;
                    break;
                case ConsoleKey.UpArrow:
                    if(selected > 0) selected--;
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.WriteLine("Запускаю {0}", tasks[selected].name);
                    Console.WriteLine("====================");
                    Console.WriteLine();
                    try
                    {
                        tasks[selected].mainfn();
                        Console.WriteLine();
                        Console.WriteLine("====================");
                        Console.WriteLine("{0} завершилась.", tasks[selected].name);
                    }
                    catch
                    {
                        Console.WriteLine();
                        Console.WriteLine("====================");
                        Console.WriteLine("{0} вылетела с ошибкой! Проверьте входные данные",
                                            tasks[selected].name);
                    }
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
            }
        }
    }
}