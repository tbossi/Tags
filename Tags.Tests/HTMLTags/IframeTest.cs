using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class IframeTest
    {
        private Iframe _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Iframe("http://src");
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<iframe src=\"http://src\"></iframe>");
        }

        [TestCase(typeof(SupportHeightAttribute))]
        [TestCase(typeof(SupportWidthAttribute))]
        [TestCase(typeof(SupportNameAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void AddSrcdoc()
        {
            _tag.AddSrcdoc("<p>hello \"boy\"!</p>");
            Assert.AreEqual(_tag.ToString(), "<iframe src=\"http://src\" srcdoc=\"<p>hello &quot;boy&quot;!</p>\"></iframe>");
        }

        [Test]
        public void AddSandbox()
        {
            _tag.AddSandbox();
            Assert.AreEqual(_tag.ToString(), "<iframe sandbox=\"\" src=\"http://src\"></iframe>");
        }

        [Test]
        public void AddSandbox_MultipleValues()
        {
            _tag.AddSandbox(Sandbox.AllowForms, Sandbox.AllowPointerLock);
            Assert.AreEqual(_tag.ToString(), $"<iframe sandbox=\"{Sandbox.AllowForms.LiteralValue()} {Sandbox.AllowPointerLock.LiteralValue()}\" src=\"http://src\"></iframe>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}