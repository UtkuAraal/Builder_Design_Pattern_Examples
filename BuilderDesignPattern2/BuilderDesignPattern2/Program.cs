using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // https://localhost/api/v1/user?id=5&name=utku

            var eb = new EndpointBuilder("https://localhost");
            eb
                .Append("api")
                .Append("v1")
                .Append("user")
                .AppendParam("id", "5")
                .AppendParam("name", "utku");
      
            var url = eb.Build();
            Console.WriteLine(url);
        }
    }
}

