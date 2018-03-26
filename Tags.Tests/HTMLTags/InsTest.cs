using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class InsTest
    {
        private readonly Ins tag = new Ins();

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<ins></ins>");
        }

        [Test]
        public void AddCite()
        {
            tag.AddCite("http://url");
            Assert.AreEqual(tag.ToString(), "<ins cite=\"http://url\"></ins>");
        }

        [Test]
        public void AddDatetime()
        {
            var date = new DateTime();
            tag.AddDatetime(date);
            Assert.AreEqual(tag.ToString(), $"<ins datetime=\"{date.ToString("u")}\"></ins>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}