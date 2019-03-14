/*Name:Rajveer Kaur
topic=loops*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_r
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("displaying a table");
            //using for loop
            Console.WriteLine("N\t\tN*10\t\tN*100\t\tN*1000"); 
                
            for(int i= 1;i<=10;i++)
            {
                Console.WriteLine($"{i}\t\t{i * 10}\t\t{i * 100}\t\t{i * 1000}");
            }
            Console.ReadLine();
            
            
            //using while loop
            Console.WriteLine("N\t\tN*10\t\tN*100\t\tN*1000");

            int counter = 1;
             while( counter <=10)
            {
                Console.WriteLine($"{counter}\t\t{counter*10}\t\t{counter*100}\t\t{counter*1000}");
                counter++;
            }
            Console.ReadLine();

            //using do while
            counter = 4;
            do
            {
                Console.WriteLine($"{counter}\t\t{counter * 10}\t\t{counter * 100}\t\t{counter * 1000}");
                counter++;
            }
            while(counter <= 10);
            Console.ReadLine();

        }
    }
}
