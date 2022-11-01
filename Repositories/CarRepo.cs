using DataAccess.Abstract;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class CarRepo : GenericRepositoryRepo<Car, VehicleContext>, ICar
    {
    }
}
