namespace Vehicles.Example.Abstractions;

public interface IVehicle
{
    string Name { get; }
    string Manufacturer { get; }
    float MaxVelocity { get; }
}
