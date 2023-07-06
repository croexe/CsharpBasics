namespace InterfaceExtensibility;

internal class DbMigrator
{
    private readonly ILogger _logger;

    public DbMigrator(ILogger logger)
    {
        _logger = logger;
    }
    public void Migrate()
    {
        _logger.LogInfo("Migration Started: " + DateTime.Now);
        _logger.LogError("Null Argument Error occured: " + DateTime.Now);
    }
}