using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Library.Watchable.Data.Artifacts
{
    public interface IWatchableStore
    {
        Task<string> StoreTvWatchableAsync(ITvData tv);
        Task<string> StoreMovieWatchableAsync(IMovieData tv);
    }
}
