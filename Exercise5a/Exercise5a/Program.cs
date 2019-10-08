using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print_a_to_z_v1();
           // Print_a_to_z_v2();
           // Print_z_to_a_v1();
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine(" " + Char2Code(c));
            Console.WriteLine(" " + IsUpper(c));
        }
        public static void Print_a_to_z_v1()
        {
            for (int i = 97; i <= 122; i++)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine();
        }
        public static void Print_a_to_z_v2()
        {
            for (char c = 'a'; c <= 'z'; c++ )
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
        }
        public static void Print_z_to_a_v1()
        {
            for (int i = 122; i > 97; i--)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine();
        }
        public static void Print_A_to_Z_v1()
        {
            for(int i = 65 ; i<=90 ; i++)
            {
                Console.WriteLine((char)i);
            }
            Console.WriteLine();
        }
        public static int Char2Code(char c)
        {
            return (int)c;

        }
        public static bool IsUpper(char c)
        {
            
            return false;
        }
        public static bool IsLower(char c)
        {
            return false;
        }
        public static char ToUpper(char c)
        {
            return (char)c;
        }
        public static char ToLower(char c)
        {
            return c;
        }
    }
}
