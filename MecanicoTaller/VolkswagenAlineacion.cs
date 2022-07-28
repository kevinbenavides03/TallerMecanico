using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public class VolkswagenAlineacion : Alineacion
    {
        string text;
        public VolkswagenAlineacion(string text)
        {
            this.text = text;
        }
        public override string Paint()
        {
            return " ---------- \n" +
                " | " + text + " |\n" +
                " ------------------\n";
        }
    }
}
