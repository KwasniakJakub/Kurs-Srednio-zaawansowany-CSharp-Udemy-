//Kompozycja podobnie jak dziedziczenie jest innym rodzajem
//relacji pomiędzy dwiema klasami (używane do projektowania luźno powiązanych aplikacji)
namespace Composition_Kompozycja_
{
    public class DBMigrator
    {
        private readonly Logger logger;

        public DBMigrator(Logger logger)
        {
           this.logger = logger;
        }
        public void Migrate()
        {
            logger.Log("We are migrating ...");
        }
    }
}
