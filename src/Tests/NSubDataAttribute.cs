using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoNSubstitute;
using Ploeh.AutoFixture.Xunit;

namespace Tests
{
    public class NSubDataAttribute : AutoDataAttribute
    {
        public NSubDataAttribute() 
            : base (new Fixture().Customize(new AutoNSubstituteCustomization()))
        {
        }
    }
}