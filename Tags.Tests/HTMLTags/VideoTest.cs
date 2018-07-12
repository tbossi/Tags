using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class VideoTest
    {
        private Video _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Video();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<video></video>");
        }

        [Test]
        public void AddPoster()
        {
            _tag.AddPoster("/url/to/image.png");
            Assert.AreEqual(_tag.ToString(), "<video poster=\"/url/to/image.png\"></video>");
        }

        [TestCase(typeof(SupportAutoplayAttribute))]
        [TestCase(typeof(SupportControlsAttribute))]
        [TestCase(typeof(SupportHeightAttribute))]
        [TestCase(typeof(SupportLoopAttribute))]
        [TestCase(typeof(SupportMutedAttribute))]
        [TestCase(typeof(SupportPreloadAttribute))]
        [TestCase(typeof(SupportSrcAttribute))]
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