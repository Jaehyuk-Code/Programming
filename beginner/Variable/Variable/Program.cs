using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("나이 : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("키 : ");
            float height = float.Parse(Console.ReadLine());

            Console.Write(age);
            Console.WriteLine(name);
            Console.WriteLine(height);
        }
    }
}
