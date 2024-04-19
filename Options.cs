using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class Options
    {
        [Option("addBook", Required = false, HelpText = "Adds a book to the library")]
        public bool AddBook { get; set; }

    }
}
