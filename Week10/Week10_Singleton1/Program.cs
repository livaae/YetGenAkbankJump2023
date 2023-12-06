
using Week10_Singleton1;

Console.WriteLine("Singleton!");

ConfigurationService configurationService = ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance();
ConfigurationService.GetInstance().GetValue("");

var azureConnectionString = configurationService.GetValue("Storage: Azure");

Console.WriteLine();

