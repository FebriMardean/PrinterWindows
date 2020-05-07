using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterWindows
{
    public class PrinterWindows
    {
        public string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("Show Dimension");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer printing....");
        }
    }
}
