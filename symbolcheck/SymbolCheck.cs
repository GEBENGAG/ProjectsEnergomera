using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbolcheck
{
    public class SymbolCheck
    {
        public static void Check(string symbols)
        {
            int round = 0;
            int roundback = 0;
            int square = 0;
            int squareback = 0;

            int figure = 0;
            int figureback = 0;

            if (symbols.Contains("(") || symbols.Contains(")") || symbols.Contains("[") || symbols.Contains("]") || symbols.Contains("{") || symbols.Contains("}"))
            {
                for (int i= 0; i < symbols.Count();i++ )
                {
                    if (symbols[i] == '(') round++;
                    if (symbols[i] == ')') roundback++;
                    if (symbols[i] == '[') square++;
                    if (symbols[i] == ']') squareback++;
                    if (symbols[i] == '{') figure++;
                    if (symbols[i] == '}') figureback++;
                  
                    
                }
                if (round == roundback && square == squareback && figure == figureback)
                {
                    Console.WriteLine("true");

                    Choose();
                    
                }
                else
                {
                    Console.WriteLine("false");
                    Choose();

                }

            }
            else
            {
                Console.WriteLine("Wrong String");
                Console.ReadKey();
                Program.Input();
            }


        }
        public static void Choose()
        {
            Console.WriteLine("press q to quit or r to restart\n");
            char deal = Console.ReadKey().KeyChar;
            if (deal == 'q' || deal == 'Q')
            {


            }
            else if (deal == 'r' || deal == 'R')
            {
                Console.WriteLine("\n");

                Program.Input();
            }
        }
    }
}
