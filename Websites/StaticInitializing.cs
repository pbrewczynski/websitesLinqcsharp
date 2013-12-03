using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Websites
{
    class StaticInitializing
    {
        public StaticInitializing()
        {
            Console.WriteLine("I executed constructor");
            System.Threading.Thread.Sleep(5000);
        }
    }
}
