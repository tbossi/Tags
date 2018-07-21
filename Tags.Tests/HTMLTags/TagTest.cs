using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Tags.Encoders;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TagTest
    {
        private TestTag _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new TestTag();
        }

        [Test]
        public void AddInnerHtml()
        {
            var list = new Tag[] { new TestTag("asd"), new TestTag("qwe"), new TestTag("div") };

            Assert.That(_tag.Content.Count, Is.EqualTo(0));
            _tag.AddInnerHtml(list);
            Assert.That(_tag.Content.SequenceEqual(list));
        }

        [Test]
        public void AddAttribute()
        {
            Assert.That(_tag.Attributes, Is.Empty);
            _tag.AddAttribute("key1");
            Assert.That(_tag.Attributes["key1"], Is.Null);
            _tag.AddAttribute("key2", "<<\"asd");
            Assert.That(_tag.Attributes["key2"], Is.EqualTo(new AttributeEncoder().Encode("<<\"asd")));
            _tag.AddAttribute("key3", "<<\"asd", new PassThroughEncoder());
            Assert.That(_tag.Attributes["key3"], Is.EqualTo(new PassThroughEncoder().Encode("<<\"asd")));
            Assert.That(_tag.Attributes.Count, Is.EqualTo(3));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("           ")]
        public void MergeAttribute_ThrowsException(string key)
        {
            Assert.Throws<ArgumentException>(() => _tag.AddAttribute(key));
        }

        [Test]
        public void Render()
        {
            RenderAssertion(new TestTag("tagname"), "<tagname></tagname>");
            RenderAssertion(new TestTag("tagname", TagRenderMode.SelfClosing), "<tagname>");

            var tag = new TestTag("tagname");
            tag.AddAttribute("attr1");
            tag.AddAttribute("attr2", "value of attr");
            RenderAssertion(tag, "<tagname attr1 attr2=\"value of attr\"></tagname>");

            tag = new TestTag("tagname");
            tag.AddAttribute("attr1");
            tag.AddInnerHtml(new TestTag("innerTag", TagRenderMode.SelfClosing));
            RenderAssertion(tag, "<tagname attr1><innerTag></tagname>");
        }

        private void RenderAssertion(Tag tagToTest, string expectedString)
        {
            var sb = new StringBuilder();
            Assert.AreEqual(sb, tagToTest.Render(sb));
            Assert.AreEqual(expectedString, sb.ToString());
        }
    }
}