using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public class OSVolkswagen : Marca
    {
        public Alineacion CreateButton(string text)
        {
            return new VolkswagenAlineacion(text);

        }
        public CambioBateria CreateIcon(string type)
        {
            return new VolkswagenCambioBateria(type);
        }
        public CambioLlanta CreateLabel(string label)
        {
            return new VolkswagenCambioLlanta(label);
        }

    }
}
