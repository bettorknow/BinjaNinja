using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Newtonsoft.Json;

namespace Library.Watchable.Data.Artifacts
{
    public interface IWatchableStore
    {
        Task<IIndexResponse> StoreTvWatchableAsync(ITvData tv);
        Task<IIndexResponse> StoreMovieWatchableAsync(IMovieData tv);
    }
}
