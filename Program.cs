using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Лаба4
{
    class Program
    {
        static void Time(Action action)
        {
            var sw = new Stopwatch();
            sw.Start();
            action();
            sw.Stop();
            Console.WriteLine($"Time: {sw.Elapsed}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of task:");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    var firstTask = new FirstTask();
                    Console.WriteLine("Input n");
                    int n = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("1 version");
                    Time(() => firstTask.FirstVersion(n));
                    
                    Console.WriteLine("2 version");
                    Time(() => firstTask.SecondVersion(n));
                    
                    Console.WriteLine("3 version");
                    Time(() => firstTask.ThirdVersion(n));

                    Console.WriteLine("4 version");
                    Time(() => firstTask.FourthVersion(n));
                    break;
                case 2:
                    var secondTask = new SecondTask();
                    Console.WriteLine("Input string");
                    string str = Console.ReadLine();
                    
                    Console.WriteLine("Without stringBuilder");
                    Time(() => Console.WriteLine(secondTask.WithoutStrBuilder(str)));
                    
                    Console.WriteLine("With stringBuilder");
                    Time((() => Console.WriteLine(secondTask.WithStrBuilder(str))));
                    break;
                case 3: 
                    var task16 = new Task16();
                    task16.Solution();
                    break;
                default:
                    Console.WriteLine("Wrong number!");
                    break;
            }
        }
    }
}