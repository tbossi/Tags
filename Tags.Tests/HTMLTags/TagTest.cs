using System.Web.Mvc;
using NUnit.Framework;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TagTest
    {
        [Test]
        public void AddId()
        {
            var tag = new TestTag();
            tag.AddId("tag-id");

            Assert.AreEqual(tag.ToString(), "<testtag id=\"tag-id\"></testtag>");
        }

        [Test]
        public void AddId_Override()
        {
            var tag = new TestTag();
            tag.AddId("tag-id");
            tag.AddId("other-id");

            Assert.AreEqual(tag.ToString(), "<testtag id=\"other-id\"></testtag>");
        }

        [Test]
        public void AddClasses()
        {
            var tag = new TestTag();
            tag.AddClasses("class1", "other", null, "class1", "", "ccc");

            Assert.AreEqual(tag.ToString(), "<testtag class=\"ccc other class1\"></testtag>");
        }

        [Test]
        public void AddClasses_MultipleCalls()
        {
            var tag = new TestTag();
            tag.AddClasses("class1", "other");
            tag.AddClasses("class1", "ccc");

            Assert.AreEqual(tag.ToString(), "<testtag class=\"ccc other class1\"></testtag>");
        }

        [Test]
        public void AddData()
        {
            var tag = new TestTag();
            tag.AddData("mykey", "value of data");

            Assert.AreEqual(tag.ToString(), "<testtag data-mykey=\"value of data\"></testtag>");
        }

        [Test]
        public void AddData_MultipleCalls()
        {
            var tag = new TestTag();
            tag.AddData("mykey", "value of data");
            tag.AddData("otherkey", "6468461351321");
            tag.AddData("mykey", "new value");

            Assert.AreEqual(tag.ToString(), "<testtag data-mykey=\"new value\" data-otherkey=\"6468461351321\"></testtag>");
        }

        [Test]
        public void AddTitle()
        {
            var tag = new TestTag();
            tag.AddTitle("tag title");

            Assert.AreEqual(tag.ToString(), "<testtag title=\"tag title\"></testtag>");
        }

        [Test]
        public void AddTitle_Override()
        {
            var tag = new TestTag();
            tag.AddTitle("tag title");
            tag.AddTitle("other title");

            Assert.AreEqual(tag.ToString(), "<testtag title=\"other title\"></testtag>");
        }

        [Test]
        public void AddInnerHtml()
        {
            var tag = new TestTag();
            var inner1 = new TestTag("foo");
            var inner2 = new TestTag("bar", TagRenderMode.SelfClosing);
            tag.AddInnerHtml(inner1, inner2);

            Assert.AreEqual(tag.ToString(), "<testtag><foo></foo><bar /></testtag>");
        }
    }
}