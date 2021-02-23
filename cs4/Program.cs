using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs4
{
    class Program
    {
        private static void Say()
        {
            Console.WriteLine("함수로 출력하였습니다.");
        }
        private static int Method1(int a, int b)
        {
            return a + b;
        }
        private static string Method2(string a, string b)
        {
            return a + b;
        }
        private static bool Method3(bool a)
        {
            return a;
        }
        static void Main(string[] args)
        {
            Say();
            int a = Method1(1, 2);
            string b = Method2("내용 합치기 ", "테스트");
            bool c = Method3(true);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
