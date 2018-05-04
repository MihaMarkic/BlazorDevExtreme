using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDevExtreme
{
    public class JQueryEventArgs: EventArgs
    {
        public string Identifier { get; }
        public JQueryEventArgs(string identifier)
        {
            Identifier = identifier;
        }
    }
}
