## PSConsoleApp
This timer trigger every minute loads a PowerShell script that runs an .exe file. This executable is placed with the function; a simple console app that just posts a line to the log. Code below:

```c#
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
```
