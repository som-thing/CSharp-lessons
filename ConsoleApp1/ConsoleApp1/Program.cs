using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            String source = "1234561";
            int prevnumber = source[1];
            bool res = true;
            for (int i = 1; i <= source.Length-1; i++) {
                int currnumber = source[i];
                if (currnumber - prevnumber != -1 && currnumber - prevnumber != 1 && currnumber - prevnumber != 0)
                {
                    res = false;
                    break;
                }
                prevnumber = currnumber;
            }
            if (res)
            {
                Console.WriteLine("It is");
            } 
            else
            {
                 Console.WriteLine("It isn't");
            }
            Console.ReadLine();
        }
    }
}
