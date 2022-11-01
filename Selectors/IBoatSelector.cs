using WebApplication1.Models;

namespace WebApplication1.Selectors
{
    public interface IBoatSelector
    {
        List<Boat> GetBoatByColor(string color);
    }
}
