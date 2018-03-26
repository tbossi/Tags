using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TimeTest
    {
        private readonly Time tag = new Time();

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<time></time>");
        }

        [Test]
        public void AddDatetime()
        {
            var date = new DateTime();
            tag.AddDatetime(date);
            Assert.AreEqual(tag.ToString(), $"<time datetime=\"{date.ToString("u")}\"></time>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}