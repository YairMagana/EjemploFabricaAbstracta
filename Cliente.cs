using System;

namespace EjemploFabricaAbstracta
{
    class Cliente
    {
        public void Inicializar()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Cliente: Creando snippets de código para Windows");
            ClientMethod(new FabricaWindows());
            Console.WriteLine();

            Console.WriteLine("Cliente: Creando snippets de código para Mac");
            ClientMethod(new FabricaMac());
        }

        public void ClientMethod(IFabricaGUI fabrica)
        {
            var boton = fabrica.CrearBoton();
            var checkbox = fabrica.CrearCheckbox();

            Console.WriteLine(boton.CrearBoton("X"));
            Console.WriteLine(checkbox.CrearCheckbox("Y"));

            Console.ReadKey();
        }
    }
}
