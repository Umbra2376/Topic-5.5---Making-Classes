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
        private static Random _generator;
        private ConsoleColor _color;
        public Die()
        {
            _sides = 6;
            _generator = new Random();
            _roll = _generator.Next(1, _sides + 1);
            _color = ConsoleColor.Gray;
        }

        //Accessor Properties
        public int Roll
        {
            get { return _roll; }
        }

        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
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
            ConsoleColor _currentForecolor = Console.ForegroundColor;
            Console.ForegroundColor = _color;
            if (_roll == 1)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| o |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
            }
            else if (_roll == 2)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }

            else if (_roll == 3)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o  |");
                Console.WriteLine("| o |");
                Console.WriteLine("|  o|");
                Console.WriteLine("-----");
            }
            else if (_roll == 4)
            {
                Console.WriteLine("-----");
                Console.WriteLine("|o o|");
                Console.WriteLine("|   |");
                Console.WriteLine("|o o|");
                Console.WriteLine("-----");
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
            Console.ForegroundColor = _currentForecolor;
        }
    }
}
