using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main()
    {
        Console.WriteLine("\r\n██╗░░░░░██╗░██████╗████████╗░█████╗░  ██████╗░███████╗\r\n██║░░░░░██║██╔════╝╚══██╔══╝██╔══██╗  ██╔══██╗██╔════╝\r\n██║░░░░░██║╚█████╗░░░░██║░░░███████║  ██║░░██║█████╗░░\r\n██║░░░░░██║░╚═══██╗░░░██║░░░██╔══██║  ██║░░██║██╔══╝░░\r\n███████╗██║██████╔╝░░░██║░░░██║░░██║  ██████╔╝███████╗\r\n╚══════╝╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝  ╚═════╝░╚══════╝\r\n\r\n████████╗░█████╗░██████╗░███████╗███████╗░█████╗░░██████╗██╗\r\n╚══██╔══╝██╔══██╗██╔══██╗██╔════╝██╔════╝██╔══██╗██╔════╝██║\r\n░░░██║░░░███████║██████╔╝█████╗░░█████╗░░███████║╚█████╗░██║\r\n░░░██║░░░██╔══██║██╔══██╗██╔══╝░░██╔══╝░░██╔══██║░╚═══██╗╚═╝\r\n░░░██║░░░██║░░██║██║░░██║███████╗██║░░░░░██║░░██║██████╔╝██╗\r\n░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░░╚═╝╚═════╝░╚═╝");

        bool isRunning = true;
        while (isRunning)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Ver tarefas");
            Console.WriteLine("3. Marcar tarefa como concluída");
            Console.WriteLine("4. Sair");

            Console.Write("\nOpção escolhida: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    MarkTaskAsCompleted();
                    break;
                case "4":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }

        Console.WriteLine("\nObrigado por usar a Lista de Tarefas. Até logo!");
    }

    static void AddTask()
    {
        Console.Write("Digite a tarefa: ");
        string task = Console.ReadLine();

        tasks.Add(task);

        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Não há tarefas na lista.");
        }
        else
        {
            Console.WriteLine("Lista de Tarefas:");

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    static void MarkTaskAsCompleted()
    {
        Console.Write("Digite o número da tarefa concluída: ");
        string taskNumberInput = Console.ReadLine();
        int taskNumber;

        if (int.TryParse(taskNumberInput, out taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
        {
            string completedTask = tasks[taskNumber - 1];
            tasks.RemoveAt(taskNumber - 1);

            Console.WriteLine($"A tarefa '{completedTask}' foi marcada como concluída.");
        }
        else
        {
            Console.WriteLine("Número de tarefa inválido. Tente novamente.");
        }
    }
}
