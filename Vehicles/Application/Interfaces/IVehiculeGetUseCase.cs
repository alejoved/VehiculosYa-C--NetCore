using VehiculosYa.Vehicles.Domain.Models;

namespace VehiculosYa.Vehicles.Application.Interfaces;

public interface IVehicleGetUseCase
{
    public List<Vehicle> Execute();
    public Vehicle ExecuteById(Guid id);
    public Vehicle ExecuteByPlate(string plate); 
}