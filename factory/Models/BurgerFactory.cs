
using Microsoft.AspNetCore.Mvc.Rendering;

namespace factory.Models
{
    public interface IBurgerFactory
    {
        string Bun { get; }
        string Condiments { get; }
        string Patty { get; }



    }
}







