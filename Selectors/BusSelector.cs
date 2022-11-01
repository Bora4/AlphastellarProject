using DataAccess.Abstract;
using WebApplication1.Models;

namespace WebApplication1.Selectors
{
    public class BusSelector : IBusSelector
    {
        private readonly IBus _bus;

        public BusSelector(IBus bus)
        {
            _bus = bus;
        }

        public List<Bus> GetBusByColor(string color)
        {
            var buses = _bus.GetList(i => i.Color.Contains(color)).ToList();
            return buses;
        }
    }
}
