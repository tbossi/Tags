using System;
using Moq;
using NUnit.Framework;
using Tags.HTMLTags;
using System.Web.Mvc;

namespace Tags.Tests.HTMLTags.Attributes
{
    public abstract class AttributeTest<T> where T : class, ITag
    {
        protected Mock<T> Tag;
        protected TagBuilder Builder;

        [SetUp]
        public virtual void SetUp()
        {
            Tag = new Mock<T>();
            Builder = new TagBuilder("test");
        }

        [TearDown]
        public virtual void TearDown()
        {
            Tag.VerifyAll();
        }

        protected void AssertAttributeAdded(Action<T> actionToTest, string expectedResult)
        {
            Tag.Setup(t => t.TagBuilder).Returns(Builder).Verifiable();

            actionToTest.Invoke(Tag.Object);
            Assert.AreEqual(Builder.ToString(), expectedResult);
        }
    }
}