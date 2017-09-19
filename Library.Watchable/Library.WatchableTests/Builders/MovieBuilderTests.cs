using System;
using System.Collections.Generic;
using FluentAssertions;
using Library.Watchable.Builders;
using NUnit.Framework;

namespace Library.WatchableTests.Builders
{
    [TestFixture]
    public class MovieBuilderTests
    {
        [TestCaseSource(nameof(TestInputs.DatesForTest))]
        public void WhenBuildWithReleaseDate_ExpectEntityToHaveSameValue(DateTime expectedDate)
        {
            new MovieBuilder("Star Wars")
                .WithReleaseDate(expectedDate)
                .Build()
                .Should()
                .Be(expectedDate);
        }

        [Test]
        public void WhenBuildWithoutReleaseDate_ExpectEntityToHaveNullValue(DateTime expectedDate)
        {
            new MovieBuilder("Star Wars")
                .Build()
                .Should()
                .BeNull();
        }

        [TestCaseSource(nameof(TestInputs.Titles))]
        public void WhenBuildWithoutTitle_ExpectEntityToHaveSameValue(string title)
        {
            new MovieBuilder(title)
                .Build()
                .Should()
                .BeNull();
        }
    }
}
