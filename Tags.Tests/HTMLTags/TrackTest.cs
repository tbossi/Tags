using System;
using NUnit.Framework;
using Tags.Exception;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TrackTest
    {
        private Track _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Track();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<track>");
        }

        [TestCase(typeof(SupportLabelAttribute))]
        [TestCase(typeof(SupportSrcAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void AddDefault()
        {
            _tag.AddDefault();
            Assert.AreEqual(_tag.ToString(), "<track default=\"default\">");
        }

        [TestCase(Kind.Subtitles, "en")]
        [TestCase(Kind.Chapters, null)]
        public void AddKind(Kind kind, string value)
        {
            _tag.AddKind(kind, value);
            var v = string.IsNullOrEmpty(value) ? "" : $" srclang=\"{value}\"";
            Assert.AreEqual(_tag.ToString(), $"<track kind=\"{kind.LiteralValue()}\"{v}>");
        }

        [TestCase(null)]
        [TestCase("")]
        public void AddKind_ThrowsException(string value)
        {
            Assert.Throws<InvalidAttribute>(() => _tag.AddKind(Kind.Subtitles, value));
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.SelfClosing);
        }
    }
}