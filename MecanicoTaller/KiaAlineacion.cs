using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public  class KiaAlineacion : Alineacion
    {
        string text;
        public KiaAlineacion(string text)
        {
            this.text = text;
        
        }

        public override string Paint()
        {
            return "********* \n" +
                " * " + text + " *\n" + 
                "************* \n";
        }
    }
}
