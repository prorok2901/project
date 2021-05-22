using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace крестики_нолики

{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int[,] arr1 = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = number;
                    number++;
                    Console.Write(arr1[i, j] + " ");
                }
            }

            Console.WriteLine();
            char[,] arr = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = '*';
                    Console.Write(arr[i, j] + " ");
                }
            }
            int r, term = 0;
            int proverka = 1;
            bool prob = true;
            Console.WriteLine("\n Начало игры:");
            while (prob == true)
            {
                Console.WriteLine("\n player1: (выберите место куда будете ставить Х)");
                while (proverka == 1)
                {

                    r = int.Parse(Console.ReadLine());

                    for (int i = 0; i < 3; i++)
                    {

                        for (int j = 0; j < 3; j++)
                        {
                            if (arr1[i, j] == r && arr[i, j] == '*')
                            {
                                arr[i, j] = 'X';
                                term++;
                                proverka = 0;
                            }

                        }
                    }
                    if (proverka == 1) Console.WriteLine("либо число не от 0 до 9, либо место занято");
                }

                proverka = 1;

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }
                if (arr[0, 2] == 'X' && arr[1, 1] == 'X' && arr[2, 0] == 'X')

                { Console.WriteLine("\n Игрок 1 выйграл"); break; }

                else if (arr[0, 0] == 'X' && arr[1, 0] == 'X' && arr[2, 0] == 'X')

                { Console.WriteLine("\n Игрок 1 выйграл"); break; }

                else if (arr[0, 2] == 'X' && arr[1, 2] == 'X' && arr[2, 2] == 'X')

                { Console.WriteLine("\n Игрок 1 выйграл"); break; }

                else if (arr[0, 0] == 'X' && arr[1, 1] == 'X' && arr[2, 2] == 'X')

                { Console.WriteLine("\n Игрок 1 выйграл"); break; }

                else if (arr[0, 0] == 'X' && arr[0, 1] == 'X' && arr[0, 2] == 'X')

                { Console.WriteLine("\n Игрок 1 выйграл"); break; }

                else if (arr[2, 0] == 'X' && arr[2, 1] == 'X' && arr[2, 2] == 'X')

                { Console.WriteLine("\n Игрок 1 выйграл"); break; }

                else if (arr[1, 0] == 'X' && arr[1, 1] == 'X' && arr[1, 2] == 'X')

                { Console.WriteLine("\n Игрок 1 выйграл"); break; }

                if (term == 9)
                {
                    break;
                }
                Console.WriteLine("\n player2: (выберите место куда будете ставить O)");
                while (proverka == 1)
                {


                    r = int.Parse(Console.ReadLine());

                    for (int i = 0; i < 3; i++)
                    {

                        for (int j = 0; j < 3; j++)
                        {
                            if (arr1[i, j] == r && arr[i, j] == '*')
                            {
                                arr[i, j] = 'O';
                                term++;
                                proverka = 0;
                            }
                        }
                    }
                    if (proverka == 1) Console.WriteLine("либо число не от 0 до 9, либо место занято");
                }

                proverka = 1;

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                }


                if (arr[0, 2] == 'O' && arr[1, 1] == 'O' && arr[2, 0] == 'O')

                { Console.WriteLine("\n Игрок 2 выйграл"); break; }

                else if (arr[0, 0] == 'O' && arr[1, 0] == 'O' && arr[2, 0] == 'O')

                { Console.WriteLine("\n Игрок 2 выйграл"); break; }

                else if (arr[0, 2] == 'O' && arr[1, 2] == 'O' && arr[2, 2] == 'O')

                { Console.WriteLine("\n Игрок 2 выйграл"); break; }

                else if (arr[0, 0] == 'O' && arr[1, 1] == 'O' && arr[2, 2] == 'O')

                { Console.WriteLine("\n Игрок 2 выйграл"); break; }

                else if (arr[0, 0] == 'O' && arr[0, 1] == 'O' && arr[0, 2] == 'O')

                { Console.WriteLine("\n Игрок 2 выйграл"); break; }

                else if (arr[2, 0] == 'O' && arr[2, 1] == 'O' && arr[2, 2] == 'O')

                { Console.WriteLine("\n Игрок 2 выйграл"); break; }

                else if (arr[1, 0] == 'X' && arr[1, 1] == 'X' && arr[1, 2] == 'X')

                { Console.WriteLine("\n Игрок 2 выйграл"); break; }
            }

            Console.ReadKey();


        }
    }

}
