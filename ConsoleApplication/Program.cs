using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "http://localhost/asp/mypage.aspx?id=123";
            var str1 = str.Split('/');
            StringBuilder path = new StringBuilder();

            for (int i = 0; i <= str1.Length - 1; i++)
            {
                //if (str1[i].Contains(".aspx"))
                //    str1[i].Remove();
                str = string.Empty;
            }
        }
    }
}
