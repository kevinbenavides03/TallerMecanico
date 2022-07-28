using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
    public class HyundaiCambioBateria : CambioBateria
    {
        string type;
        public HyundaiCambioBateria(string type)
        {
            this.type = type;
        }
        public override string Paint()
        {
            string resultado = "";

            switch (type)
            {
                case "Alerta":
                    resultado = " \n ---Marca: Hyundai--- \n Cantidad: 1 " +
                        " Alineacion: $ 50 **" +
                        " \n Cantidad: 1 **" +
                        " Cambio de Bateria: $ 70 ***" +
                        " \n Cantidad: 1 **" +
                        " Cambio de llanta: $ 130 ***" +
                       
                        " Total + 12%: $ 280";

                    break;
                case "Peligro":
                    break;
            }
            return resultado;
        }
    }
}
