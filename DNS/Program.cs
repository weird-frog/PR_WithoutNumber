using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите имя сайта в виде \"www.имя.домен\"\n(Например www.google.com)");

                string hostname = Console.ReadLine(), ips = "", aliases = "";
                IPHostEntry ipHostEntry = Dns.GetHostEntry(hostname);

                foreach (IPAddress ip in ipHostEntry.AddressList)
                {
                    ips += ip.ToString() + "\n";
                }

                foreach (string aliasName in ipHostEntry.Aliases)
                {
                    aliases += aliasName + "\n";
                }

                if (aliases == "")
                {
                    Console.WriteLine("Псевдонимы: НЕТ");
                }
                else
                {
                    Console.WriteLine("Псевдонимы:\n" + aliases);
                }

                Console.WriteLine("\nСписок IP:\n" + ips);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong...\n{ex}");
                Console.ReadKey();
            }
            
        }
    }
}
