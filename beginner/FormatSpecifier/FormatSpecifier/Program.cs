using System;

namespace FormatSpecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:N2}", 1234.5678); //출력 1,234.57
            Console.WriteLine("{0:D8}", 12345);  //출력 00012345
            Console.WriteLine("{0:F3}", 1234.56); //출력 1234.560
            Console.WriteLine("{0:8}", 1234); // 출력 ____1234
            Console.WriteLine("{0,-8}", 1234); // 출력 1234____

            string s;
            s = string.Format("{0:N2}", 1234.5678);
            Console.WriteLine(s); //출력 1234.57
            s = string.Format("{0:D8}", 1234);
            Console.WriteLine(s); //출력 00001234
            s = string.Format("{0:F3}", 1234.56);
            Console.WriteLine(s); // 출력 1234.560

            Console.WriteLine(1234.5678.ToString("N2")); //출력 1,234.57
            Console.WriteLine(1234.ToString("D8"));  // 출력  00001234
            Console.WriteLine(1234.56.ToString("F3")); //출력 1234.560

            Console.WriteLine("{0:#.##}", 1234.5678); // 출력 1234.57
            Console.WriteLine("{0:0,0.00}", 1234.5678); // 출력 1,234.57
            Console.WriteLine("{0:#,#.##}", 1234.5678); // 출력 1,234.57
            Console.WriteLine("{0:000000.00}", 1234.5678); // 출력 001234.57
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 1234.5678); // 출력 1,234.57
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", -1234.5678); // 출력 (1,234.57)
            Console.WriteLine("{0:#,#.##;(#,#.##);zero}", 0); // 출력 zero





        }
    }
}
