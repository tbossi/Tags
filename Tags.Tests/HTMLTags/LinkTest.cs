using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class LinkTest
    {
        private Link _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Link("http://url");
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<link href=\"http://url\">");
        }

        [TestCase(typeof(SupportMediaQueryAttribute))]
        [TestCase(typeof(SupportMIMETypeAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void AddRel()
        {
            _tag.AddRel(LinkRel.Alternate);
            Assert.AreEqual(_tag.ToString(), "<link href=\"http://url\" rel=\"alternate\">");
        }

        [Test]
        public void AddCrossorigin()
        {
            _tag.AddCrossorigin(Crossorigin.Anonymous);
            Assert.AreEqual(_tag.ToString(), "<link crossorigin=\"anonymous\" href=\"http://url\">");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.SelfClosing);
        }
    }
}