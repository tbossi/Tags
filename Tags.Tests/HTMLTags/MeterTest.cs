using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class MeterTest
    {
        private Meter _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Meter(5);
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<meter value=\"5\"></meter>");
        }

        [Test]
        public void AddMin()
        {
            _tag.AddMin(1);
            Assert.AreEqual(_tag.ToString(), "<meter min=\"1\" value=\"5\"></meter>");
        }

        [Test]
        public void AddMax()
        {
            _tag.AddMax(150.3);
            Assert.AreEqual(_tag.ToString(), "<meter max=\"150.3\" value=\"5\"></meter>");
        }

        [Test]
        public void AddLow()
        {
            _tag.AddLow(3.3);
            Assert.AreEqual(_tag.ToString(), "<meter low=\"3.3\" value=\"5\"></meter>");
        }

        [Test]
        public void AddHigh()
        {
            _tag.AddMax(10.59);
            Assert.AreEqual(_tag.ToString(), "<meter high=\"10.59\" value=\"5\"></meter>");
        }

        [Test]
        public void AddOptimum()
        {
            _tag.AddOptimum(6);
            Assert.AreEqual(_tag.ToString(), "<meter optimum=\"6\" value=\"5\"></meter>");
        }

        [TestCase(typeof(SupportFormAttribute))]
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