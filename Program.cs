// See https://aka.ms/new-console-template for more information

using Vehicles.Example.Classes;

var airplane = new Airplane("Concorde", "British Aircraft", 2150.2f);
airplane.Fly();

var balloon = new Balloon("Hot Air Balloon", "Montgolfier Brothers", 80.5f);
balloon.Fly();

var boat = new Boat("Titanic", "White Star Line", 44.7f);
boat.Sail();

Console.WriteLine();

Console.Read();
