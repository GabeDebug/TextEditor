using System;

namespace TextEditor
{
    class Program
    {
        static void Main()
        {
            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLie("Oq você deseja fazer? ");
            Console.WriteLie("1 - Abrir um arquivo ");
            Console.WriteLie("2 - Criar um novo arquivo ");
            Console.WriteLie("3 - Sair ");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
            }
        }
        
        
    }
}

