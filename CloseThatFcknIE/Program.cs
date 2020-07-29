using System;
using System.Diagnostics;
using System.Linq;

namespace CloseThatFcknIE
{
    class Program
    {
        static void Main(string[] args)
        {
            var ies = Process.GetProcesses().Where(x => x.ProcessName == "iexplore");

            Console.WriteLine($"Total to kill: {ies.Count()}");

            foreach (var proc in ies)
            {
                proc.Kill();
            }

            Console.WriteLine("Farewell fuckn IE!");
            Console.WriteLine("Press any button...");
            Console.ReadKey();
        }
    }
}