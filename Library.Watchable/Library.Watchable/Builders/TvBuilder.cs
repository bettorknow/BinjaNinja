using System;
using System.Collections.Generic;
using System.Text;
using Library.Watchable.Artifacts;
using Library.Watchable.Entities;

namespace Library.Watchable.Builders
{
    public class TvBuilder
    {
        public string Title { get; }
        public int? Season { get; private set; }
        public int? Episodes { get; private set; }

        public TvBuilder(string title)
        {
            Title = title;
        }

        public TvBuilder WithSeasons(int seasons)
        {
            Season = seasons;
            return this;
        }

        public TvBuilder WithEpisodes(int episodes)
        {
            Episodes = episodes;
            return this;
        }

        public ITvEntity Build()
        {
            return new TvEntity()
                .With(tv => tv.Seasons = Season)
                .With(tv => tv.Episodes = Episodes);
        }
    }
}
