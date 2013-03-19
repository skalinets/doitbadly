using System.Collections.Generic;

namespace Site.Business
{
    public interface IPostRepository
    {
        IList<Post> GetPosts();
    }

    public class PostRepository : IPostRepository
    {
        public IList<Post> GetPosts()
        {
            return new List<Post> {new Post()};
        }
    }
}