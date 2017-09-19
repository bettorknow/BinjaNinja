using System;
using Library.Watchable.Artifacts;
using Library.Watchable.Entities;

namespace Library.Watchable.Builders
{
    public class MovieBuilder
    {
        public string Title { get;  }
        public DateTime ReleaseDate { get; private set;  }

        public MovieBuilder(string title)
        {
            Title = title;
        }

        public MovieBuilder WithReleaseDate(DateTime releaseDate)
        {
            ReleaseDate = releaseDate;
            return this;
        }

        public IMovieEntity Build()
        {
            return new MovieEntity();
        }
    }
}
