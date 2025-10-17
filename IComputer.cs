using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp13
{
    internal interface IComputer
    {
        public string ComputerName { get; set; }

        public int Sum(ref int num1, ref int num2);
    }
}
