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

            // netsh http delete urlacl url=http://+9000/

            // netsh http show urlacl url=http://+9000/

        }
    }

}
