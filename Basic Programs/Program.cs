using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();//rani
                                             //0123
            int len = name.Length;
            for(int i=name.Length-1;i>=0;i--)
            {
                Console.Write(name[i]);
            }
            Console.ReadLine();
           
        }
        
    }
}
