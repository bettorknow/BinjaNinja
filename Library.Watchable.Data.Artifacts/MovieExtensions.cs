using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Watchable.Data.Artifacts
{
    public static class MovieExtensions
    {
        public static string YearIndex(this IMovieData releaseDate)
        {
            return releaseDate.Release.Year.ToString();
        }
    }
}
