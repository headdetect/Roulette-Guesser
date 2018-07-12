 using System;
using System.Collections.Generic;

namespace RouletteGuesser
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to roulette guesser!");
            Console.WriteLine("Enter in the numbers as they appear.");
            Console.WriteLine();
            Console.WriteLine("Press [Enter] to continue");

            Console.ReadLine();

            Console.Clear();

            BeginDrawing();
        }

        static void BeginDrawing()
        {
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                Console.Clear();

                DrawPrevious();
                DrawGuess();
                DrawInput();
            }
        }

        static void DrawPrevious()
        {
            var numberOfSpins = Console.BufferWidth / " .. ".Length;
            var previous = spins.ToArray();
            

            for (var i = Math.Min(previous.Length, numberOfSpins) - 1; i >= 0; i--)
            {
                var spin = previous[i];

                if (spin.Color == SpinColor.Green)
                    Console.BackgroundColor = ConsoleColor.Green;
                else if (spin.Color == SpinColor.Red)
                    Console.BackgroundColor = ConsoleColor.Red;
                else Console.BackgroundColor = ConsoleColor.Black;
                
                Console.Write(" " + spin.Value + " ");
            }

            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void DrawGuess()
        {

        }

        static void DrawInput()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write(" > ");
            var value = Console.ReadLine();

            if (int.TryParse(value, out int numValue))
            {
                if (numValue < 0 || numValue > 36)
                {
                    return;
                }

                var spin = new Spin(value);

                spins.Enqueue(spin);
            }
        }
    }
}
