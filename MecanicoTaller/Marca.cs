using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public interface Marca
    {
        public Alineacion CreateButton(string text);
        public CambioLlanta CreateLabel(string label);
        public CambioBateria CreateIcon(string type);
    }
}
