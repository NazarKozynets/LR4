using System;
using System.Text;

namespace Лаба4
{
    public class SecondTask
    {
        public string WithoutStrBuilder(string str)
        {
            string resStr = str[0].ToString();
            
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == '+' && int.TryParse(str[i - 1].ToString(), out int num) /*перевірка чи буде символ перед + числом*/ && str[i - 1] % 2 != 0)
                    resStr = resStr + "-";
                else
                    resStr = resStr + str[i];
            }

            return resStr;
        }

        public string WithStrBuilder(string str)
        {
            var sb = new StringBuilder();
            sb.Append(str[0]);
            
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == '+' && int.TryParse(str[i - 1].ToString(), out int num) && str[i - 1] % 2 != 0)
                    sb.Append("-");
                else
                    sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}