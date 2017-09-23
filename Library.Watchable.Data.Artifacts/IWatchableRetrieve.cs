using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Watchable.Data.Artifacts
{
    public interface IWatchableRetrieve
    {
        ITvData RetrieveTvData(string title);
        IMovieData RetrieveMovieData(string title);
    }
}
