using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ExternalScriptTest
    {
        private const string _url = "http://url";
        private ExternalScript _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new ExternalScript(_url);
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), $"<script src=\"{_url}\"></script>");
        }

        [TestCase(typeof(SupportCharsetAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [TestCase(Execution.Async, "async=\"async\"")]
        [TestCase(Execution.Defer, "defer=\"defer\"")]
        public void AddExecution(Execution execution, string expectedAttribute)
        {
            _tag.AddExecution(execution);
            Assert.AreEqual(_tag.ToString(), $"<script {expectedAttribute} src=\"{_url}\"></script>");
        }
    }
}