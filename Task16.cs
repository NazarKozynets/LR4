using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Лаба4
{
    public class Task16
    {
        public void Solution()
        {
            string s = "Tom Marvolo Riddle";
            string t = "I am Lord Voldemort!";

            s = Regex.Replace(s, "[^a-zA-Z]", "");
            t = Regex.Replace(t, "[^a-zA-Z]", "");
            //[^a-zA-Z] - любой символ, кроме букв
            s = s.ToLower();
            t = t.ToLower();
           
            bool b = String.Concat(s.OrderBy(c => c)) == String.Concat(t.OrderBy(c => c)) ? true : false; //OrderBy сравнивает строки по возрастанию, Concat соединяет строки, потом они сравниваются

            Console.WriteLine(b);
        }
    }
}