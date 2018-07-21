using System;
using System.Diagnostics;
using NUnit.Framework;
using Tags.Test;

namespace Tags.Tests.Acceptance
{
    [TestFixture]
    [Category(TestCommons.CategoryAcceptanceTest)]
    public class HTMLBuilderPerformanceTest
    {
        [Test]
        public void HTMLBuilder_FasterThan_TagBuilder()
        {
            var iterations = 10;

            var (elapsedHTMLBuilder, HTMLBuilderString) = Measure(BuildHTML_HTMLBuilder, iterations);
            System.Console.WriteLine($"Elapsed HTMLBuilder: {elapsedHTMLBuilder}");

            var (elapsedTagBuilder, TagBuilderString) = Measure(BuildHTML_TagBuilder, iterations);
            System.Console.WriteLine($"Elapsed TagBuilder: {elapsedTagBuilder}");

            Assert.AreEqual(TagBuilderString, HTMLBuilderString);
            Assert.That(elapsedHTMLBuilder, Is.LessThan(elapsedTagBuilder));
        }

        private static (TimeSpan, string) Measure(Func<string> htmlGenerator, int iterations)
        {
            string result = null;
            var stopwatch = new Stopwatch();
            TimeSpan totalTime = TimeSpan.Zero;

            for (int i = 0; i < iterations; i++)
            {
                stopwatch.Start();
                result = htmlGenerator.Invoke();
                stopwatch.Stop();

                totalTime += stopwatch.Elapsed;
                stopwatch.Reset();
            }

            totalTime = totalTime / iterations;

            return (totalTime, result);
        }

        private string BuildHTML_TagBuilder()
        {
            return HTMLTestSamples.Samples[0].TagBuilderVersionGenerator().ToString();
        }

        private string BuildHTML_HTMLBuilder()
        {
            return HTMLTestSamples.Samples[0].HTMLBuilderVersionGenerator().ToString();
        }
    }
}