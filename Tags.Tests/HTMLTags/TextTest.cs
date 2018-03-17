using System.Web;
using NUnit.Framework;
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
            var text2 = new Text("text1");
            var text3 = new Text("other text");

            Assert.AreEqual(text1, text1);
            Assert.AreEqual(text1, text2);
            Assert.AreNotEqual(text1, text3);
            Assert.AreNotEqual(text1, null);
        }

        [TestCase("Normal text")]
        [TestCase("<Car@tt&ri/màgìci#")]
        [TestCase("")]
        [TestCase(null)]
        public void ToString(string content)
        {
            Assert.AreEqual(new Text(content).ToString(), HttpUtility.HtmlEncode(content));
        }
    }
}