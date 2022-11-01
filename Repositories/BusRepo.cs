using DataAccess.Abstract;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class BusRepo : GenericRepositoryRepo<Bus, VehicleContext>, IBus
    {
    }
}
