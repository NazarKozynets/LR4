using System;
using System.Text;

namespace Лаба4
{
    public class FirstTask
    {
        //Щоб час виконання програми був максимально точним, значення n буде передано в параметр кожного методу
        public void FirstVersion(int n)
        {
            string res = "1";

            for (int i = 2; i <= n; i++)
            {
                res += $" {i}";
            }

            Console.WriteLine(res);
        }

        public void SecondVersion(int n)
        {
            string res = $"{n}";

            for (int i = n - 1; i > 0; i--)
            {
                res = $"{i} " + res;
            }
            
            Console.WriteLine(res);
        }

        public void ThirdVersion(int n)
        {
            var sb = new StringBuilder();
            sb.Append("1");

            for (int i = 2; i <= n; i++)
            {
                sb.Append($" {i}");
            }
            
            string res = sb.ToString();
            Console.WriteLine(res);
        }

        public void FourthVersion(int n)
        {
            var sb = new StringBuilder();
            for (int i = n; i > 0; i--)
            {
                sb.Insert(0, $"{i} ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}