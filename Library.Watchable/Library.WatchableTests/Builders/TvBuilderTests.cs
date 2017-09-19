using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Library.Watchable.Builders;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Library.WatchableTests.Builders
{
    [TestFixture]
    public class TvBuilderTests
    {
        [TestCaseSource(nameof(TestInputs.IntsForTest))]
        public void WhenBuildWithEpisodes_ExpectEntityToHaveSameValue(int expectedEpisodes)
        {
            var entity = new TvBuilder("Friday Night Lights").WithEpisodes(expectedEpisodes).Build();
           
            entity.Episodes.Should().Be(expectedEpisodes);
        }

        [Test]
        public void WhenBuildWithoutEpisodes_ExpectEntityToBeNull()
        {
            var entity = new TvBuilder("Friday Night Lights").Build();
            
            entity.Episodes.Should().BeNull();
        }

        [TestCaseSource(nameof(TestInputs.IntsForTest))]
        public void WhenBuildWithSeasons_ExpectEntityToHaveSameValue(int expectedSeasons)
        {
            var entity = new TvBuilder("Friday Night Lights").WithSeasons(expectedSeasons);

            entity.Season.Should().Be(expectedSeasons);
        }

        [Test]
        public void WhenBuildWithoutSeasons_ExpectEntityToBeNull()
        {
            var entity = new TvBuilder("Friday Night Lights").Build();

            entity.Seasons.Should().BeNull();
        }

        [TestCaseSource(nameof(TestInputs.Titles))]
        public void WhenBuildWithTitle_ExpectEntityToHaveSameValue(string expectedTitle)
        {
            var entity = new TvBuilder(expectedTitle);

            entity.Title.Should().Be(expectedTitle);
        }

        
    }
}
