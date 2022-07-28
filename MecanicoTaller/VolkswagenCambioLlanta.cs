using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public class VolkswagenCambioLlanta : CambioLlanta
    {
        string label;
        public VolkswagenCambioLlanta(string label)
        {
            this.label = label;
        }
        public override string Paint()
        {
            return "<< " + label + " >>";
        }
    }
}