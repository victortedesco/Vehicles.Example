using Vehicles.Example.Abstractions;

namespace Vehicles.Example.Classes;

public class Balloon(string name, string manufacturer, float maxVelocity) : IFlyable
{
    public string Name { get; init; } = name;

    public string Manufacturer { get; init; } = manufacturer;

    public float MaxVelocity { get; init; } = maxVelocity;

    public async Task Fly()
    {
        Console.WriteLine($"The balloon {ConsoleColors.MAGENTA}{Name} {ConsoleColors.NORMAL}from {ConsoleColors.RED}{Manufacturer} {ConsoleColors.NORMAL}is getting hotter!");
        await Task.Delay(6000);
        Console.WriteLine($"The balloon {ConsoleColors.MAGENTA}{Name} {ConsoleColors.NORMAL}from {ConsoleColors.RED}{Manufacturer} {ConsoleColors.NORMAL}is {ConsoleColors.CYAN}flying in the air {ConsoleColors.NORMAL}and it's velocity can reach up to {MaxVelocity} km/h.");
    }
}
