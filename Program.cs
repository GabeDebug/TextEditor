using System;
using System.IO;

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
                case 1: Abrir();
                    break;
                case 2: Criar();
                    break;
                case 3: System.Environment.Exit(0);
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
            while (Console.ReadKey().Key != ConsoleKey.Escape); // Mantém o programa rodando até a Tecla ESC for pressionada

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar? ");

            var path = Console.ReadLine() // pegando o pegando o caminho de aonde vai ser colocado
            
            using (var file =  new StreamWriter(path)) // cria a "Ponte" de escrita para o camainho especifico
            {
                file.Write(text); // Grava o conteúdo do texto dentro do arquivo aberto 
            }

            Console.WriteLine($"Arquivo Salvo {path} com sucesso :)");
            Console.ReadLine();
            Menu();
        }
    }
}

