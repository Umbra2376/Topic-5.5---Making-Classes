using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Topic_5._5___Making_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();

            die1.RollDie();
            die1.DrawRoll();
            die2.RollDie();
            die2.DrawRoll();
            int sum = die1.Roll + die2.Roll;;

            if (die1.Roll == die2.Roll && die1.Roll != 1)
                Console.WriteLine("You rolled a double!");
            else if (die1.Roll == die2.Roll + 1 || die1.Roll == die2.Roll - 1)
                Console.WriteLine("You rolled subquential numbers!");
            else if (sum == 7)
                Console.WriteLine("You rolled a lucky number!");
            else if (die1.Roll == 1 && die2.Roll == 1)
                Console.WriteLine("You rolled snake eyes!");
            else if (sum % 2 == 0)
                Console.WriteLine("You rolled an even sum");
            if (die1.Roll > die2.Roll)
                Console.WriteLine("Die 1 is greater than Die 2");
            else if (die1.Roll < die2.Roll)
                Console.WriteLine("Die 2 is greater than Die 1");
        }
    }
}