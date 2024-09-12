using Vehicles.Example.Abstractions;

namespace Vehicles.Example.Classes;

public class Boat(string name, string manufacturer, float maxVelocity) : ISailable
{
    public string Name { get; init; } = name;

    public string Manufacturer { get; init; } = manufacturer;

    public float MaxVelocity { get; init; } = maxVelocity;

    public async Task Sail()
    {
        Console.WriteLine($"The boat {ConsoleColors.MAGENTA}{Name} {ConsoleColors.NORMAL}from {ConsoleColors.RED}{Manufacturer} {ConsoleColors.NORMAL}is starting it's engine!");
        await Task.Delay(4000);
        Console.WriteLine($"The boat {ConsoleColors.MAGENTA}{Name} {ConsoleColors.NORMAL}from {ConsoleColors.RED}{Manufacturer}{ConsoleColors.NORMAL} is {ConsoleColors.YELLOW}sailing in the water{ConsoleColors.NORMAL} and it's velocity can reach up to {MaxVelocity} km/h.");
    }
}
