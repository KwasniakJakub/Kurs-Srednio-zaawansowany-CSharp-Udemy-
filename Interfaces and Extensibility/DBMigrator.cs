using System;

namespace Interfaces_and_Extensibility
{
    public class DBMigrator
    {
        private readonly ILogger _logger;

        public DBMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started ad {0}" + DateTime.Now);
            //Console.WriteLine("Migration started ad {0}", DateTime.Now);

            //Details of migrating database
            
            _logger.LogInfo("Migration finished ad {0}" + DateTime.Now);
            //Console.WriteLine("Migration finished ad {0}", DateTime.Now);
        }
    }
}
