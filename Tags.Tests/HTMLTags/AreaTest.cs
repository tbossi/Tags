using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AreaTest
    {
        private Area _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Area();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<area>");
        }

        [TestCase(typeof(SupportAltAttribute))]
        [TestCase(typeof(SupportTargetAttribute))]
        [TestCase(typeof(SupportDownloadAttribute))]
        [TestCase(typeof(SupportMediaQueryAttribute))]
        [TestCase(typeof(SupportRelAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void AddCoords()
        {
            _tag.AddCoords("90,58,3");
            Assert.AreEqual(_tag.ToString(), "<area coords=\"90,58,3\">");
        }

        [Test]
        public void AddHref()
        {
            _tag.AddHref("file://asd.doc");
            Assert.AreEqual(_tag.ToString(), "<area href=\"file://asd.doc\">");
        }

        [Test]
        public void AddShape()
        {
            _tag.AddShape(Shape.Circle);
            Assert.AreEqual(_tag.ToString(), $"<area shape=\"{Shape.Circle.LiteralValue()}\">");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.SelfClosing);
        }
    }
}