using NUnit.Framework;
using Tags.Test;

namespace Tags.Tests.Acceptance
{
    [TestFixture]
    [Category(TestCommons.CategoryAcceptanceTest)]
    public class HTMLBuilderAcceptanceTest
    {
        [Test]
        public void CorrectRender()
        {
            foreach (var sample in HTMLTestSamples.Samples)
            {
                Assert.AreEqual(sample.StringVersion, sample.HTMLBuilderVersion.ToString());
            }            
        }
    }
}