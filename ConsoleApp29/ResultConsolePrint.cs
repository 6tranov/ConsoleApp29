using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp29
{
    class ResultConsolePrint : IResultPrint
    {
        public void Print(Result[] results)
        {
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
        }
    }
}
