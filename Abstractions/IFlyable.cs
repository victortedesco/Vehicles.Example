namespace Vehicles.Example.Abstractions;

public interface IFlyable : IVehicle
{
    Task Fly();
}
