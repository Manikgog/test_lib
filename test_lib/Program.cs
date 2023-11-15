using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ds.test.impl;

namespace test_lib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPluginFactory factory = new Plugins();

            string[] namesOfActions = factory.GetPluginNames;

            int num1 = 4;
            int num2 = 2;

            foreach(string name in namesOfActions)
            {
                Console.WriteLine(factory.GetPlugin(name).PluginsName);
                Console.WriteLine(num1 + " " + num2 + " = " + factory.GetPlugin(name).Run(num1, num2));
            }




        }
    }
}
