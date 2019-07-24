using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IVisitorStaticRepository
    {
    }

    public class VisitorStaticRepository : RepositoryBase<VisitorStatic>, IVisitorStaticRepository
    {
        public VisitorStaticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}