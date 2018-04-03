using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class InlineScriptTest
    {
        private const string _script = "var i = (10 + \"5\" < 30) && null === undefined;";
        private InlineScript _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new InlineScript(_script);
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), $"<script>{_script}</script>");
        }
    }
}