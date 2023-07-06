// See https://aka.ms/new-console-template for more information
using InterfaceExtensibility;

var migration = new DbMigrator(new ConsoleLogger());
var nextMigration = new DbMigrator(new FileLogger("C:\\Users\\Irinej\\log.txt"));
nextMigration.Migrate();
migration.Migrate();