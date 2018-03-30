using System.Web.Mvc;
using NUnit.Framework;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TagTest
    {
        [Test]
        public void AddInnerHtml()
        {
            var tag = new TestTag();
            var inner1 = new TestTag("foo");
            var inner2 = new TestTag("bar", TagRenderMode.SelfClosing);
            tag.AddInnerHtml(inner1, inner2);

            Assert.AreEqual(tag.ToString(), "<testtag><foo></foo><bar /></testtag>");
        }
    }
}