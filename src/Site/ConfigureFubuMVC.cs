using FubuMVC.Core;

namespace Site
{
    public class ConfigureFubuMVC : FubuRegistry
    {
        public ConfigureFubuMVC()
        {
            // As is, this will be using all the default conventions and policies
            Actions.IncludeClassesSuffixedWithController();
        }
    }

    public class TestController
    {
        public MyModel Hello()
        {
            return new MyModel {Message = "hello from fubu"};
        }

    }

    public class MyModel
    {
        public string Message { get; set; }
    }
}