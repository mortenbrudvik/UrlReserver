using System;

namespace UrlReserverConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // netsh http add urlacl url=http://+9000/ user=everyone
            const string address = "http://+:9000/";
            var urlReserver = new UrlReserver();
            var status = urlReserver.Reserve(address, "everyone");
            Console.Out.WriteLine($"Trying to register \"{address}\" - { status }");

            status = urlReserver.Reserve(address, "everyone");
            Console.Out.WriteLine($"Trying to register twice \"{address}\" - { status }");

            // netsh http delete urlacl url=http://+9000/
            status = urlReserver.UnReserve(address);
            Console.Out.WriteLine($"Trying to un-register \"{address}\" - { status }");

            status = urlReserver.UnReserve(address);
            Console.Out.WriteLine($"Trying to un-register twice \"{address}\" - { status }");
        }
    }

}
