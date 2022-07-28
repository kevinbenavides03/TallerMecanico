using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public class VolkswagenCambioBateria : CambioBateria
    {
        string type;
        public VolkswagenCambioBateria(string type)
        {
            this.type = type;
        }
        public override string Paint()
        {
            string resultado = "";

            switch (type)
            {
                case "Alerta":
                    resultado = " \n ---Marca: Volkswagen--- \n Cantidad: 1 " +
                        " Alineacion: $ 50 **" +
                        " \n Cantidad: 1 **" +
                        " Cambio de Bateria: $ 60 ***" +
                        " \n Cantidad: 1 **" +
                        " Cambio de llanta: $ 100 ***" +

                        " Total + 12%: $ 235";

                    break;
                case "Peligro":
                    break;
            }
            return resultado;
        }
    }
}
