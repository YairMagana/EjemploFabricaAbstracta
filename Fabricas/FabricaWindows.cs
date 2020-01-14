namespace EjemploFabricaAbstracta
{
    class FabricaWindows : IFabricaGUI
    {
        public IBoton CrearBoton()
        {
            return new BotonWindows();
        }

        public ICheckbox CrearCheckbox()
        {
            return new CheckboxWindows();
        }
    }
}
