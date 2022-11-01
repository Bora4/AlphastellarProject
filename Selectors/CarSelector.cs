using WebApplication1.Models;
using WebApplication1.Selectors;
using DataAccess.Abstract;

namespace WebApplication1.Services
{
    public class CarSelector : ICarSelector
    {
        private readonly ICar _car;

        public CarSelector(ICar car)
        {
            _car = car;
        }
        public List<Car> GetCarByColor(string color)
        {
            var cars = _car.GetList(i => i.Color.Contains(color)).ToList();
            return cars;
        }
        public bool SwitchHeadLights(int carId)
        {
            var car = _car.Get(x=>x.Id==carId );
            if (car.HeadLights == true)
                car.HeadLights = false;
            else
                car.HeadLights = true;
            _car.Update(car);
            return true;
        }
        public bool DeleteCar(int carId)
        {
            var car = _car.Get(x => x.Id == carId);
            _car.Delete(car);
            return true;
        }
        
    }
}
