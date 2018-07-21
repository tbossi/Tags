using System.Web;
using NUnit.Framework;
using Tags.Encoders;

namespace Tags.Test.Encoders
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AttributeEncoderTest
    {
        [Test]
        public void Encode()
        {
            var encoder = new AttributeEncoder();

            Assert.That(encoder.Encode(null), Is.Null);
            Assert.That(encoder.Encode(""), Is.EqualTo(HttpUtility.HtmlAttributeEncode("")));
            Assert.That(encoder.Encode("att.asd#qweqwe-12_xx"), Is.EqualTo(HttpUtility.HtmlAttributeEncode("att.asd#qweqwe-12_xx")));
        }
    }
}