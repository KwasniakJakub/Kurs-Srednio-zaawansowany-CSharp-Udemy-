//Kompozycja podobnie jak dziedziczenie jest innym rodzajem
//relacji pomiędzy dwiema klasami (używane do projektowania luźno powiązanych aplikacji)
namespace Composition_Kompozycja_
{
    public class Installer
    {
        private readonly Logger logger;

        public Installer(Logger logger)
        {
            this.logger = logger;
        }
        public void Install()
        {
            logger.Log("We are installing the application");
        }
    }
}
