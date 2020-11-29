using UGF.Builder.Runtime;

namespace UGF.Description.Runtime.Tests
{
    public class TestDescribed : DescribedBase<TestDescription>
    {
        public int Value { get; }
        public bool Boolean { get; }

        public TestDescribed(int value, bool boolean, TestDescription description) : base(description)
        {
            Value = value;
            Boolean = boolean;
        }
    }

    public interface ITestDescribedBuilder : IBuilder
    {
        TestDescribed Build(int value, bool boolean, TestDescription description);
    }

    public class TestDescribedBuilder : DescribedBuilderBase<(int value, bool boolean, TestDescription description), TestDescribed, TestDescription>, ITestDescribedBuilder
    {
        public TestDescribed Build(int value, bool boolean, TestDescription description)
        {
            return OnBuild(value, boolean, description);
        }

        protected override TestDescribed OnBuild((int value, bool boolean, TestDescription description) arguments)
        {
            return OnBuild(arguments.value, arguments.boolean, arguments.description);
        }

        protected virtual TestDescribed OnBuild(int value, bool boolean, TestDescription description)
        {
            return new TestDescribed(value, boolean, description);
        }
    }

    public class TestDescribedWithDescriptionBuilder : TestDescribedWithDescriptionBuilderBase
    {
        protected override TestDescription OnBuildDescription()
        {
            return new TestDescription();
        }

        protected override TestDescribed OnBuild(int value, bool boolean, TestDescription description)
        {
            return new TestDescribed(value, boolean, description);
        }
    }

    public abstract class TestDescribedWithDescriptionBuilderBase : DescribedWithDescriptionBuilder<(int value, bool boolean), TestDescribed, TestDescription>, ITestDescribedBuilder
    {
        public TestDescribed Build(int value, bool boolean, TestDescription description)
        {
            return OnBuild(value, boolean, description);
        }

        protected override TestDescribed OnBuild((int value, bool boolean) arguments, TestDescription description)
        {
            return OnBuild(arguments.value, arguments.boolean, description);
        }

        protected abstract TestDescribed OnBuild(int value, bool boolean, TestDescription description);
    }
}
