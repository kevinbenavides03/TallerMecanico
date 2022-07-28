using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public  class OSKia : Marca
    {
        public Alineacion CreateButton(string text)
        {
            return new KiaAlineacion(text);
    
        }
        public CambioBateria CreateIcon(string type)
        {
            return new KiaCambioBateria(type);    
        }
        public CambioLlanta CreateLabel(string label)
        {
            return new KiaCambioLlanta(label);
        }

    }
}
