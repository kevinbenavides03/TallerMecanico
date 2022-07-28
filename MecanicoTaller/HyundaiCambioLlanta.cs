using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public class HyundaiCambioLlanta : CambioLlanta
    {
        string label;
        public HyundaiCambioLlanta(string label)
        {
            this.label = label;
        }
        public override string Paint()
        {
            return "<< " + label + " >>";
        }
    }
}
