using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lab1Ex4
    /*Ex 4
Scrieti un program care va afisa semnul unui numar citit de la tastatura
• Daca numarul este pozitiv, va afisa “+”
• Daca numarul este negativ, va afisa “-”
• Daca numarul este 0, va afisa “0”
*/
{ 
    public class Program 
    { public static void Main(string[] args) 
        { int a;
          a = Convert.ToInt32(Console.ReadLine());
            if (a > 0) 
            {
                Console.WriteLine("Numarul este pozitiv + ");
            } 
            else if (a < 0) 
            { 
                Console.WriteLine("Numarul este negativ -");
            } 
            else 
            { 
                Console.WriteLine(" Numarul este 0");
            }
        }
    }
}