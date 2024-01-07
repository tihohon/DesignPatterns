using Observer;

var coloradoStation = new WeatherStation();
var coloradoPresidentPhoneScreen = new SmartPhoneScreen(coloradoStation);
var russianSpyMonitor = new LSDScreen(coloradoStation);
coloradoStation.Add(coloradoPresidentPhoneScreen);
coloradoStation.Add(russianSpyMonitor);

coloradoStation.UpdateWeather(4.3, 229, "Kill yourself please");
coloradoPresidentPhoneScreen.Display();
russianSpyMonitor.Display();

coloradoStation.Remove(coloradoPresidentPhoneScreen);

coloradoStation.UpdateWeather(4.4, 1337, "Don't kill yourself please");
coloradoPresidentPhoneScreen.Display();
russianSpyMonitor.Display();
