// See https://aka.ms/new-console-template for more information

using System;

enum SportsGames
{
    football = 1,
    basketball = 2,
    tennis = 3,
    baseball = 4,
    hockey = 5
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Виберіть гру про яку хотіли б дізнатися цікаву інфу: ");
        Console.ResetColor();
        Console.WriteLine(" 1. футбол \n 2. баскетбол \n 3. теніс \n 4. бейсбол \n 5. хокей");
        Console.Write("Ваш вибір: ");
        
        int choice = Convert.ToInt16(Console.ReadLine());

        switch ((SportsGames)choice)
        {
            case SportsGames.football:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Футбол");
                Console.ResetColor();
                Console.WriteLine(" \n Правила: дві команди по 11 гравців намагаються забити м'яч у ворота суперника. \n Поле: розміри приблизно 100-110 м у довжину та 64-75 м у ширину. \n Матч: 90 хвилин (два тайми по 45 хвилин). \n Цікавий факт: найшвидший гол в історії футболу був забитий за 2,4 секунди після стартового свистка!");
                break;
            
            case SportsGames.basketball:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Баскетбол");
                Console.ResetColor();
                Console.WriteLine(" \n Правила: дві команди по 5 гравців намагаються закинути м'яч у кошик суперника. \n Поле: розміри 28*15 м. \n Матч: 40 хвилин (4 періоди по 10 хвилин). \n Цікавий факт: баскетбол придумав Джеймс Нейсміт у 1891 році, використовуючи кошики для персиків. ");
                break;
            
            case SportsGames.tennis:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Теніс");
                Console.ResetColor();
                Console.WriteLine(" \n Правила: грають один на один або парами, намагаючись відбити м'яч через сітку. \n Поле: розміри 23,77*8,23м (одиночний) або 23,77*10,97м (парний). \n Тривалість матчу: залежить від формату гри. \n Цікавий факт: найдовший матч тривав 11 годин і 5 хвилин!");
                break;
            
            case SportsGames.baseball:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Бейсбол");
                Console.ResetColor();
                Console.WriteLine(" \n Правила: дві команди по 9 гравців намагаються набрати очки, пробігаючи бази після удару по м'ячу. \n Поле: форма ромба, а бази розташовані на відстані 27,4м одна від одної. \n Матч: триває 9 інінгів. \n Цікавий факт: у бейсболі є правило \"ідеальної гри\", коли жоден гравець команди суперника не доходить до бази.");
                break;
            
            case SportsGames.hockey:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n Хокей");
                Console.ResetColor();
                Console.WriteLine(" \n Правила: дві команди по 6 гравців (включаючи воротаря) намагаються забити шайбу у ворота суперника. \n Льодове поле: розміри 60*30м. \n Матч: 60 хвилин (3 періоди по 20 хвилин). \n Цікавий факт: найшвидший удар шайби був зафіксований зі швидкістю 183 км/год!");
                break;
            
            default:
                Console.WriteLine("На жаль такого варіанту вибору немає :(");
                break;
        }
    }
}


/*
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Виберіть гру про яку хотіли б дізнатися цікаву інфу: ");
        Console.ResetColor();
        Console.WriteLine(" 1. футбол \n 2. баскетбол \n 3. теніс \n 4. бейсбол \n 5. хокей");
        Console.Write("Ваш вибір: ");
        
        int choice = Convert.ToInt16(Console.ReadLine());

        if (choice == 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Футбол");
            Console.ResetColor();
            Console.WriteLine(" \n Правила: дві команди по 11 гравців намагаються забити м'яч у ворота суперника. \n Поле: розміри приблизно 100-110 м у довжину та 64-75 м у ширину. \n Матч: 90 хвилин (два тайми по 45 хвилин). \n Цікавий факт: найшвидший гол в історії футболу був забитий за 2,4 секунди після стартового свистка!");
        }

       else if (choice == 2)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Баскетбол");
            Console.ResetColor();
            Console.WriteLine(" \n Правила: дві команди по 5 гравців намагаються закинути м'яч у кошик суперника. \n Поле: розміри 28*15 м. \n Матч: 40 хвилин (4 періоди по 10 хвилин). \n Цікавий факт: баскетбол придумав Джеймс Нейсміт у 1891 році, використовуючи кошики для персиків. ");
        }

        else if (choice == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Теніс");
            Console.ResetColor();
            Console.WriteLine(" \n Правила: грають один на один або парами, намагаючись відбити м'яч через сітку. \n Поле: розміри 23,77*8,23м (одиночний) або 23,77*10,97м (парний). \n Тривалість матчу: залежить від формату гри. \n Цікавий факт: найдовший матч тривав 11 годин і 5 хвилин!");
        }

        else if (choice == 4)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Бейсбол");
            Console.ResetColor();
            Console.WriteLine(" \n Правила: дві команди по 9 гравців намагаються набрати очки, пробігаючи бази після удару по м'ячу. \n Поле: форма ромба, а бази розташовані на відстані 27,4м одна від одної. \n Матч: триває 9 інінгів. \n Цікавий факт: у бейсболі є правило \"ідеальної гри\", коли жоден гравець команди суперника не доходить до бази.");
        }

        else if (choice == 5)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Хокей");
            Console.ResetColor();
            Console.WriteLine(" \n Правила: дві команди по 6 гравців (включаючи воротаря) намагаються забити шайбу у ворота суперника. \n Льодове поле: розміри 60*30м. \n Матч: 60 хвилин (3 періоди по 20 хвилин). \n Цікавий факт: найшвидший удар шайби був зафіксований зі швидкістю 183 км/год!");
        }

        else
        {
            Console.WriteLine("На жаль такого варіанту вибору немає :(");
        }
        
    }
}*/
