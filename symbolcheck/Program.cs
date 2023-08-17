using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbolcheck
{
    public class Program
    {
      public static void Main(string[] args)
        {
            Input();
        }
      public static void Input()
        {

            Console.WriteLine("Введите строку содержащую символы: (; ); {; }; [; ];");
            SymbolCheck.Check(Console.ReadLine());

        }

        

    }
}
