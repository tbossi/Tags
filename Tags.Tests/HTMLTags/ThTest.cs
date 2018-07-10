using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ThTest
    {
        private Th _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Th();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<th></th>");
        }

        [Test]
        public void AddScope()
        {
            _tag.AddScope(Scope.Col);
            Assert.AreEqual(_tag.ToString(), $"<th scope=\"{Scope.Col.LiteralValue()}\"></th>");
        }

        [TestCase(typeof(SupportColspanAttribute))]
        [TestCase(typeof(SupportRowspanAttribute))]
        [TestCase(typeof(SupportHeadersAttribute))]
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