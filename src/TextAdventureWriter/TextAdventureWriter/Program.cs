using System;
using TawLauncher;

namespace TextAdventureWriter
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var launch = new Launch();
            launch.Init();
        }
    }
}
