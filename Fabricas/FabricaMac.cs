namespace EjemploFabricaAbstracta
{
    class FabricaMac : IFabricaGUI
    {
        public IBoton CrearBoton()
        {
            return new BotonMac();
        }

        public ICheckbox CrearCheckbox()
        {
            return new CheckboxMac();
        }
    }
}
