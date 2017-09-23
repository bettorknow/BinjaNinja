using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Library.Framework.Extensions;
using Library.Watchable.Data.Artifacts;
using Nest;
using Newtonsoft.Json;

namespace Library.Watchables.Data.Elastic
{
    public class ElasticStore : IWatchableStore
    {
        private readonly IElasticLowLevelClient _elasticClient;

        public ElasticStore(IElasticLowLevelClient elasticClient)
        {
            _elasticClient = elasticClient.WhenNullThrow(nameof(elasticClient));
        }

        public async Task<string> StoreTvWatchableAsync(ITvData tv)
        {
            var asyncIndexResponse = await _elasticClient.IndexAsync<string>("tv", tv.Title, new PostData<ITvData>(tv));
            return asyncIndexResponse.Body;
        }

        public async Task<string> StoreMovieWatchableAsync(IMovieData movie)
        {
            var asyncIndexResponse = await _elasticClient.IndexAsync<string>("movie", movie.YearIndex(), movie.Title, new PostData<IMovieData>(movie));
            return asyncIndexResponse.Body;
        }
    }
}
