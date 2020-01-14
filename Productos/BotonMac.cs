namespace EjemploFabricaAbstracta
{

    class BotonMac : IBoton
    {
        public string CrearBoton(string t)
        {
            return $"Botón {t} Mac";
        }
    }
}
