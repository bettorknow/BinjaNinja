using System;
using Library.Watchable.Data.Artifacts;

namespace Library.Watchables.Data.Elastic
{
    public class MovieData : IMovieData
    {
        public string Title { get; set; }
        public DateTime Release { get; set; }
    }
}
