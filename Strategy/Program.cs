// See https://aka.ms/new-console-template for more information

using Strategy;

var jetDuck = new Duck(new JetFlying());
var wingsDuck = new Duck(new WingsFlying());
jetDuck.Migrate();
wingsDuck.Migrate();