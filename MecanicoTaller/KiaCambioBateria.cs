using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller
{
   public  class KiaCambioBateria : CambioBateria
    {
        string type;
        public KiaCambioBateria(string type)
        {
            this.type = type;
        }
        public override string Paint()
        {
            string resultado = "";

            switch (type)
            {
                case "Alerta":
                     resultado = " \n ---Marca: Kia--- \n Cantidad: 1 " +
                        " Alineacion: $ 50 **" +
                        " \n Cantidad: 1 **" +
                        " Cambio de Bateria: $ 50 ***" +
                        " \n Cantidad: 1 **" +
                        " Cambio de llanta: $ 100 ***" +
                        
                        " Total + 12%: $ 224";


                    break;
                case "Peligro":
                    break;
            }
            return resultado;
        }
    }
}
