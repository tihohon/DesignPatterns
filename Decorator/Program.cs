using Decorator.KibanaClient;
using Decorator.Logger;

var logger = new Logger();
var toFileDecorator = new LogToFile("/Users/tihon/RiderProjects/DesignPatterns/Decorator/Logger/log.txt");
toFileDecorator.SetLogger(logger);
toFileDecorator.Log("YOUR MUM");
var consoleLogger = new LogToConsole();
consoleLogger.SetLogger(toFileDecorator);
consoleLogger.Log("Sadness");
var stubKibanaClient = new KibanaStubClient();
var loggerWithKibanaLogger = new LogToKibana(stubKibanaClient);
loggerWithKibanaLogger.SetLogger(consoleLogger);
loggerWithKibanaLogger.Log("Summer Time");
loggerWithKibanaLogger.Log("Summer Time Sadness");
Console.WriteLine(stubKibanaClient.SendedData);