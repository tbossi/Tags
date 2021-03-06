using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AudioTest
    {
        private Audio _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Audio();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<audio></audio>");
        }

        [TestCase(typeof(SupportAutoplayAttribute))]
        [TestCase(typeof(SupportControlsAttribute))]
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
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}