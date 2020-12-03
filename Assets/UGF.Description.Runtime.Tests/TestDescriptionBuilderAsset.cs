namespace UGF.Description.Runtime.Tests
{
    public class TestDescriptionBuilderAsset : DescriptionBuilderAsset<TestDescription>
    {
        protected override TestDescription OnBuild()
        {
            return new TestDescription();
        }
    }
}
