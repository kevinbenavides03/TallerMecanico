using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public class OSHyundai : Marca
    {
        public Alineacion CreateButton(string text) 
        {
            return new HyundaiAlineacion(text);
        }
        public CambioBateria CreateIcon(string type)
        {
            return new HyundaiCambioBateria(type);
        }
        public CambioLlanta CreateLabel(string label)
        {
            return new HyundaiCambioLlanta(label);
        }
    }
}
