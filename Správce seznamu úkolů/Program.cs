using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        Console.WriteLine("Vítejte v aplikaci Správce úkolů!");

        while (true)
        {
            Console.WriteLine("\nCo chcete udělat?");
            Console.WriteLine("1. Zobrazit seznam úkolů");
            Console.WriteLine("2. Přidat úkol");
            Console.WriteLine("3. Odstranit úkol");
            Console.WriteLine("4. Konec");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShowTasks();
                    break;
                case "2":
                    AddTask();
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "4":
                    Console.WriteLine("Děkujeme, že jste použili aplikaci Správce úkolů!");
                    return;
                default:
                    Console.WriteLine("Neplatná volba. Zkuste to znovu.");
                    break;
            }
        }
    }

    static void ShowTasks()
    {
        Console.WriteLine("\nSeznam úkolů:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Zadejte nový úkol:");
        string task = Console.ReadLine();
        tasks.Add(task);
        Console.WriteLine("Úkol byl úspěšně přidán!");
    }

    static void RemoveTask()
    {
        ShowTasks();
        Console.WriteLine("Zadejte číslo úkolu, který chcete odstranit:");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
        {
            string removedTask = tasks[taskNumber - 1];
            tasks.RemoveAt(taskNumber - 1);
            Console.WriteLine($"Úkol \"{removedTask}\" byl odstraněn.");
        }
        else
        {
            Console.WriteLine("Neplatný výběr úkolu. Zkuste to znovu.");
        }
    }
}