using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TestDirectoryProps
{
    internal class MainTestClass
    {
        public string Tick { get; } = Windows.Win32.PInvoke.GetTickCount().ToString();
    }
}
