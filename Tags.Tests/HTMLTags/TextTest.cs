using System.Web;
using NUnit.Framework;
using Tags.Encoders;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TextTest
    {
        [Test]
        public void Ctor()
        {
            var text1 = new Text("text1");
            var text2 = new Text("other text");
            var text3 = new Text("text1", new PassThroughEncoder());
            
            Assert.AreEqual(text1, text1);
            Assert.AreNotEqual(text1, text2);
            Assert.AreNotEqual(text1, text3);
            Assert.AreNotEqual(text1, null);
        }

        [TestCase("Normal text")]
        [TestCase("<Car@tt&ri/màgìci#")]
        [TestCase("")]
        public void ToString(string content)
        {
            Assert.AreEqual(new Text(content).ToString(), new ContentEncoder().Encode(content));
            Assert.AreEqual(new Text(content, new PassThroughEncoder()).ToString(), new PassThroughEncoder().Encode(content));
        }
    }
}