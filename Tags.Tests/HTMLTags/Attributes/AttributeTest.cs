using System;
using Moq;
using NUnit.Framework;
using Tags.Encoders;
using Tags.HTMLTags;
using Tags.Test;
//using System.Web.Mvc;

namespace Tags.Tests.HTMLTags.Attributes
{
    public abstract class AttributeTest<T> where T : class, ITag
    {
        private TestTag _testTag;

        protected Mock<T> Tag;

        [SetUp]
        public virtual void SetUp()
        {
            Tag = new Mock<T>();
            _testTag = new TestTag("test");
        }

        [TearDown]
        public virtual void TearDown()
        {
            Tag.VerifyAll();
        }

        protected void AssertAttributeAdded(Action<T> actionToTest, string expectedResult)
        {
            Tag.Setup(t => t.AddAttribute(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<StringEncoder>()))
            .Callback((string k, string v, StringEncoder enc) => _testTag.AddAttribute(k, v, enc)).Verifiable();

            actionToTest.Invoke(Tag.Object);
            Assert.AreEqual(expectedResult, _testTag.ToString());
        }
    }
}