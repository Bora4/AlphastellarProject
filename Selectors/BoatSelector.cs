using DataAccess.Abstract;
using WebApplication1.Models;

namespace WebApplication1.Selectors
{
    public class BoatSelector : IBoatSelector
    {
        private readonly IBoat _boat;

        public BoatSelector(IBoat boat)
        {
            _boat = boat;
        }

        public List<Boat> GetBoatByColor(string color)
        {
            var boats = _boat.GetList(i => i.Color.Contains(color)).ToList();
            return boats;
        }
    }
}