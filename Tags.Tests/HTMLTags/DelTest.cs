using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DelTest
    {
        private readonly Del tag = new Del();

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<del></del>");
        }

        [Test]
        public void AddCite()
        {
            tag.AddCite("http://url");
            Assert.AreEqual(tag.ToString(), "<del cite=\"http://url\"></del>");
        }

        [Test]
        public void AddDatetime()
        {
            var date = new DateTime();
            tag.AddDatetime(date);
            Assert.AreEqual(tag.ToString(), $"<del datetime=\"{date.ToString("u")}\"></del>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}