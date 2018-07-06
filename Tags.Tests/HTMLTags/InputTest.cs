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
    public class InputTest
    {
        private Input _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Input(InputType.Password);
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<input type=\"password\">");
        }

        [TestCase(typeof(SupportAltAttribute))]
        [TestCase(typeof(SupportAutocompleteAttribute))]
        [TestCase(typeof(SupportAutofocusAttribute))]
        [TestCase(typeof(SupportDisabledAttribute))]
        [TestCase(typeof(SupportFormAttribute))]
        [TestCase(typeof(SupportHeightAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void AddAccept()
        {
            _tag.AddAccept("image/*");
            Assert.AreEqual(_tag.ToString(), "<input accept=\"image/*\" type=\"password\">");
        }

        [Test]
        public void AddChecked()
        {
            foreach (InputType e in Enum.GetValues(typeof(InputType)))
            {
                _tag = new Input(e);
                switch (e)
                {
                    case InputType.Checkbox:
                        _tag.AddChecked();
                        Assert.AreEqual(_tag.ToString(), "<input checked=\"checked\" type=\"checkbox\">");
                        break;
                    case InputType.Radio:
                        _tag.AddChecked();
                        Assert.AreEqual(_tag.ToString(), "<input checked=\"checked\" type=\"radio\">");
                        break;
                    default:
                        Assert.Throws<InvalidAttribute>(_tag.AddChecked);
                        break;
                }
            }
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, System.Web.Mvc.TagRenderMode.StartTag);
        }
    }
}