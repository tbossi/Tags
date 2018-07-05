using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AutocompleteAttributeTest : AttributeTest<SupportAutocompleteAttribute>
    {
        [TestCase(true, "on")]
        [TestCase(false, "off")]
        public void AddAutocomplete(bool autocomplete, string expectedValue)
        {
            AssertAttributeAdded(tag => tag.AddAutocomplete(autocomplete), $"<test autocomplete=\"{expectedValue}\"></test>");
        }
    }
}