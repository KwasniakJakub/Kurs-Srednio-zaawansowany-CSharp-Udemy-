//Kompozycja podobnie jak dziedziczenie jest innym rodzajem
//relacji pomiędzy dwiema klasami (używane do projektowania luźno powiązanych aplikacji)

namespace Composition_Kompozycja_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
