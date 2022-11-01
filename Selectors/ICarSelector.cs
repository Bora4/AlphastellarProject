using WebApplication1.Models;

namespace WebApplication1.Selectors
{
    public interface ICarSelector
    {
        List<Car> GetCarByColor(string color);
        bool SwitchHeadLights(int carId);
        bool DeleteCar(int carId);
    }
}
