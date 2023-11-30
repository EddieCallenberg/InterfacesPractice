using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesPractice.Interfaces
{
    internal interface IBook
    {
        string Title { get; set; }
        string Author { get; set; }
        void PrintContent();
    }
}
