using System.Web;
using NUnit.Framework;
using Tags.Encoders;

namespace Tags.Test.Encoders
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ContentEncoderTest
    {
        [Test]
        public void Encode()
        {
            var encoder = new ContentEncoder();

            Assert.That(encoder.Encode(null), Is.EqualTo(HttpUtility.HtmlEncode(null)));
            Assert.That(encoder.Encode(""), Is.EqualTo(HttpUtility.HtmlEncode("")));
            Assert.That(encoder.Encode("att.asd#qweqwe-12_xx@@@  asdasd </>"), Is.EqualTo(HttpUtility.HtmlEncode("att.asd#qweqwe-12_xx@@@  asdasd </>")));
        }
    }
}