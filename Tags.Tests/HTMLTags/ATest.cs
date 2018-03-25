using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ATest
    {
        private const string _url = "http://url";
        private readonly A tag = new A(_url);

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), $"<a href=\"{_url}\"></a>");
        }

        [Test]
        public void AddDownload()
        {
            tag.AddDownload("fileName");
            Assert.AreEqual(tag.ToString(), $"<a href=\"{_url}\" download=\"fileName\"></a>");
        }

        [Test]
        public void AddRel()
        {
            tag.AddRel(Rel.Nofollow);
            Assert.AreEqual(tag.ToString(), $"<a href=\"{_url}\" rel=\"{Rel.Nofollow.LiteralValue()}\"></a>");
        }

        [Test]
        public void AddTarget()
        {
            tag.AddTarget(Target._blank);
            Assert.AreEqual(tag.ToString(), $"<a href=\"{_url}\" target=\"{Target._blank.LiteralValue()}\"></a>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}