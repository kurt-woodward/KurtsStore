using System.Linq;

namespace SportlandSports.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
    }
}
