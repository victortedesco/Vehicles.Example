namespace Vehicles.Example.Abstractions;

public interface ISailable : IVehicle
{
    Task Sail();
}
