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
        [TestCase(typeof(SupportMaxLengthAttribute))]
        [TestCase(typeof(SupportMultipleAttribute))]
        [TestCase(typeof(SupportNameAttribute))]
        [TestCase(typeof(SupportPlaceholderAttribute))]
        [TestCase(typeof(SupportReadonlyAttribute))]
        [TestCase(typeof(SupportRequiredAttribute))]
        [TestCase(typeof(SupportSizeAttribute))]
        [TestCase(typeof(SupportSrcAttribute))]
        [TestCase(typeof(SupportStringValueAttribute))]
        [TestCase(typeof(SupportWidthAttribute))]
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
        public void AddList()
        {
            _tag.AddList("datalist_id");
            Assert.AreEqual(_tag.ToString(), "<input list=\"datalist_id\" type=\"password\">");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.SelfClosing);
        }

        [Test]
        public void AddPattern()
        {
            const string pattern = "[A-Za-z]{3,6}.*";
            foreach (InputType e in Enum.GetValues(typeof(InputType)))
            {
                _tag = new Input(e);
                switch (e)
                {
                    case InputType.Date:
                    case InputType.Email:
                    case InputType.Password:
                    case InputType.Search:
                    case InputType.Tel:
                    case InputType.Text:
                    case InputType.Url:
                        _tag.AddPattern(pattern);
                        Assert.AreEqual(_tag.ToString(), $"<input pattern=\"{pattern}\" type=\"{e.LiteralValue()}\">");
                        break;
                    default:
                        Assert.Throws<InvalidAttribute>(() => _tag.AddPattern(pattern));
                        break;
                }
            }
        }

        [Test]
        public void AddStep()
        {
            const int step = 3;
            foreach (InputType e in Enum.GetValues(typeof(InputType)))
            {
                _tag = new Input(e);
                switch (e)
                {
                    case InputType.Date:
                    case InputType.DatetimeLocal:
                    case InputType.Month:
                    case InputType.Number:
                    case InputType.Range:
                    case InputType.Time:
                    case InputType.Week:
                        _tag.AddStep(step);
                        Assert.AreEqual(_tag.ToString(), $"<input step=\"{step}\" type=\"{e.LiteralValue()}\">");
                        break;
                    default:
                        Assert.Throws<InvalidAttribute>(() => _tag.AddStep(step));
                        break;
                }
            }
        }
    }
}