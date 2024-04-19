using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
namespace Library_Management
{

    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
    .WithParsed<Options>(o =>
    {
        if (o.AddBook)
        {

        }
        {

        }
    }
    }
    }
}
