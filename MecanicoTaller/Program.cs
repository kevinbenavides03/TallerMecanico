using System;


namespace MecanicoTaller
{
    internal class Program
    { 
    static void Main(string[] args)
{
    Aplication app = new Aplication(new OSVolkswagen());
            

            app.CrearIU();
            app.Paint();
    }

}
}

