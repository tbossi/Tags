using NUnit.Framework;
using Tags;

namespace Tags.Test
{
    [TestFixture]
    public class HTMLBuilderTest
    {
        [Test]
        public void Tags()
        {
            var tag = HTMLBuilder.Tag;
        }
    }
}