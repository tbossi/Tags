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
        private readonly Iframe tag = new Iframe("http://src");

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<iframe src=\"http://src\"></iframe>");
        }

        [Test]
        public void AddHeight()
        {
            tag.AddHeight(500);
            Assert.AreEqual(tag.ToString(), "<iframe src=\"http://src\" height=\"500\"></iframe>");
        }

        [Test]
        public void AddWidth()
        {
            tag.AddWidth(987);
            Assert.AreEqual(tag.ToString(), "<iframe src=\"http://src\" width=\"987\"></iframe>");
        }

        [Test]
        public void AddName()
        {
            tag.AddName("name");
            Assert.AreEqual(tag.ToString(), "<iframe src=\"http://src\" name=\"name\"></iframe>");
        }

        [Test]
        public void AddSrcdoc()
        {
            tag.AddSrcdoc("<p>hello!</p>");
            Assert.AreEqual(tag.ToString(), "<iframe src=\"http://src\" srcdoc=\"<p>hello!</p>\"></iframe>");
        }

        [Test]
        public void AddSandbox()
        {
            tag.AddSandbox();
            Assert.AreEqual(tag.ToString(), "<iframe src=\"http://src\" sandbox=\"\"></iframe>");
        }

        [Test]
        public void AddSandbox_MultipleValues()
        {
            tag.AddSandbox(Sandbox.AllowForms, Sandbox.AllowPointerLock);
            Assert.AreEqual(tag.ToString(), $"<iframe src=\"http://src\" sandbox=\"{Sandbox.AllowForms.Value} {Sandbox.AllowPointerLock.Value}\"></iframe>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}