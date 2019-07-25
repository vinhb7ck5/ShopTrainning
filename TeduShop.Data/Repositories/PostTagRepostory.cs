using TeduShop.Data.Infrastructure;
using TeduShop.Model.Models;

namespace TeduShop.Data.Repositories
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
    }

    public class PostTagRepostory : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepostory(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}