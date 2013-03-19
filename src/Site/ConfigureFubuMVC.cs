using FubuMVC.Core;
using Site.Business;

namespace Site
{
    public class ConfigureFubuMVC : FubuRegistry
    {
        public ConfigureFubuMVC()
        {
            // As is, this will be using all the default conventions and policies
            Actions.IncludeClassesSuffixedWithController();
            Routes
                .IgnoreControllerNamespaceEntirely()    
                .IgnoreClassNameForType<MyModel>()
                .HomeIs<PostController.FooModel>();
        }
    }

    public class TestController
    {
        public MyModel Hello(MyInputModel model)
        {
            return new MyModel {Message = "hello from fubu"};
        }

    }

    public class MyInputModel
    {
    }

    public class MyModel
    {
        public string Message { get; set; }
    }
}