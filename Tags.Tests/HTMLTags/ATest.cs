using System;
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
        private A _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new A(_url);
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), $"<a href=\"{_url}\"></a>");
        }

        [TestCase(typeof(SupportRelAttribute))]
        [TestCase(typeof(SupportTargetAttribute))]
        [TestCase(typeof(SupportDownloadAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}