using NUnit.Framework;
using Tags.Encoders;

namespace Tags.Test.Encoders
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class PassThroughEncoderTest
    {
        [Test]
        public void Encode()
        {
            var encoder = new PassThroughEncoder();

            Assert.That(encoder.Encode(null), Is.Null);
            Assert.That(encoder.Encode(""), Is.EqualTo(""));
            Assert.That(encoder.Encode("att.asd#qweqwe-12_xx@@@  asdasd </>"), Is.EqualTo("att.asd#qweqwe-12_xx@@@  asdasd </>"));
        }
    }
}