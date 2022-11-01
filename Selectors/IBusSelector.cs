using WebApplication1.Models;

namespace WebApplication1.Selectors
{
    public interface IBusSelector
    {
        List<Bus> GetBusByColor(string color);
    }
}
