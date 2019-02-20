using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Service1;


namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CLIENT";
            Service1Client client = new Service1Client();
            string x = client.GetData(123);
            Console.WriteLine(x);
        }
    }
}
