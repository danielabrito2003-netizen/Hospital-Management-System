using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public  class CamasException : ApplicationException
    {
        public CamasException() : base ("Camas Ocupadas") { }

        public CamasException(string s) : base(s) { }

        public CamasException(string s,  Exception e) {

            throw new Exception(s + e.Message);
        }
    }
}
