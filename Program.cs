using System;

namespace TextEditor
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Oq você deseja fazer? ");
            Console.WriteLine("1 - Abrir um arquivo ");
            Console.WriteLine("2 - Criar um novo arquivo ");
            Console.WriteLine("3 - Sair ");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0);
                    break;
                case 1: Abrir();
                    break;
                case 2: Criar();
                    break;
                default: Menu();
                    break;

            }
        }

        static void Abrir()
        {
            
        }

        static void Criar()
        {
            Console.Clear();
            Console.WriteLine("Digite o Seu texto abaixo (Digite ESC para sair)");
            Console.WriteLine("___________________");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine(text);
        }
    }
}

