using System.Collections.Generic;
using FluentAssertions;
using NSubstitute;
using Ploeh.AutoFixture.Xunit;
using Site;
using Site.App_Start;
using Site.Business;
using Xunit;
using Xunit.Extensions;

namespace Tests
{
    public class PostsControllerTester
    {
        [Fact]
        public void PlaceHolder()
        { 

        }

        [Theory, NSubDataAttribute]
        public void should_return_posts(
            [Frozen] IPostRepository repository,
            List<Post> posts, 
            PostController controller)
        {
            repository.GetPosts().Returns(posts);
            controller.GetPosts(null).Posts.Should().Equal(posts);
        }
    }

    public class ContainerFactoryTester
    {
        [Fact]
        public void should_use_default_conventions()
        {
            ContainerFactory.GetContainer()
                .GetInstance<IPostRepository>()
                .Should()
                .BeOfType<PostRepository>();
        }
    }
}
