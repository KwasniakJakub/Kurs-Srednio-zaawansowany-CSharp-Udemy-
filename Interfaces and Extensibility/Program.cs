namespace Interfaces_and_Extensibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrator(new FileLogger("C:\\Projects\\log.txt"));
            dbMigrator.Migrate();
        }
    }
}
