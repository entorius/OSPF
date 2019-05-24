using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_Laboratorinis_OSPFWinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Network network = new Network();
            network.AddRouter("192.128.128.0", "R1");
            network.AddRouter("192.128.128.1", "R2");
            network.AddRouter("192.128.128.2", "R3");
            network.AddRouter("192.128.128.3", "R4");
            network.AddRouter("192.128.128.4", "R5");
            network.AddRouter("192.128.128.5", "R6");
            network.AddRouter("192.128.128.6", "R7");
            network.AddRouter("192.128.128.7", "R8");
            System.Console.ReadLine();
            network.AddPath(network.GetRouters()[0], network.GetRouters()[1], 2);
            network.AddPath(network.GetRouters()[1], network.GetRouters()[2], 3);
            network.AddPath(network.GetRouters()[2], network.GetRouters()[6], 9);
            network.AddPath(network.GetRouters()[2], network.GetRouters()[4], 4);
            network.AddPath(network.GetRouters()[6], network.GetRouters()[3], 7);
            network.AddPath(network.GetRouters()[3], network.GetRouters()[5], 8);
            network.AddPath(network.GetRouters()[4], network.GetRouters()[5], 5);
            network.AddPath(network.GetRouters()[0], network.GetRouters()[5], 6);
            network.AddPath(network.GetRouters()[0], network.GetRouters()[6], 6);
            Application.Run(new Form1(network));
        }
    }
}
