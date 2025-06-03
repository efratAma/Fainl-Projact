using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Exseption
{
    internal class ExseptionBl : Exception
    {
        public ExseptionBl(string message) : base(message)
        {
        }
        
    }
}
