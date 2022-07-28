using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MecanicoTaller

{
    public class Aplication 
    {
        public Marca plataforma;
        List<GUIObject> GUI ;
        public Aplication(Marca plataforma)
        {
            this.plataforma = plataforma;
            GUI = new List<GUIObject>();
        }
        public void CrearIU()
        {
            CambioLlanta titulo = plataforma.CreateLabel("Cuando este lisas sus llantas de  su auto");
            CambioLlanta mensaje = plataforma.CreateLabel("Cambia tu llantas no manejes sin llantas lisas  !");
            CambioBateria iconoAlerta = plataforma.CreateIcon("Alerta");
            Alineacion buttonOk = plataforma.CreateButton("Ok");
            Alineacion buttonCancelar = plataforma.CreateButton("Cancelar");

            GUI.Add(titulo);
            GUI.Add(mensaje);
            GUI.Add(iconoAlerta);
            GUI.Add(buttonOk);
            GUI.Add(buttonCancelar);
           


        }
        public void Paint()
        {
            string pantalla = "";

        foreach (var objeto in GUI) 
            {
                pantalla += objeto.Paint() + "\n";
            
            }


                Console.WriteLine(pantalla);
        }
    }
}

