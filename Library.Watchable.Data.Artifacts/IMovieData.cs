using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Watchable.Data.Artifacts
{
    public interface IMovieData : IWatchableData
    {
        DateTime Release { get; set; }
    }
}
