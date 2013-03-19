using System.Linq;

namespace Site.Business
{
    public class PostController
    {
        private readonly IPostRepository repository;

        public PostController(IPostRepository repository)
        {
            this.repository = repository;
        }

        public PostsModel GetPosts(FooModel model)
        {
            return new PostsModel {Posts = repository.GetPosts().ToList() };
        }

        public class FooModel
        {
        }
    }
}