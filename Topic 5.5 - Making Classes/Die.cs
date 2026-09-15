using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5._5___Making_Classes
{
    public class Die
    {
        private int _sides;
        private int _roll;
        private Random _generator;

        public Die()
        {
            _sides = 6;
            _generator = new Random();
            _roll = _generator.Next(1, _sides + 1);
        }

        //Accessor Properties
        public int Roll
        {
            get { return _roll; }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            _roll = _generator.Next(1, _sides + 1);
        }
        public void DrawRoll()
        {
            if (_roll == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }

            else if (_roll == 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 4)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 5)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("| o |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 6)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
            }
            else
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| ? |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
        }
    }
}
