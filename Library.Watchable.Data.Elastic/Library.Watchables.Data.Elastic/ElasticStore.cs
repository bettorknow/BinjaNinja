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
        private readonly IElasticClient _elasticClient;

        public ElasticStore(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient.WhenNullThrow(nameof(elasticClient));
        }

        public async Task<IIndexResponse> StoreTvWatchableAsync(ITvData tv)
        {
            var asyncIndexResponse = await _elasticClient
                .IndexAsync(tv);
            return asyncIndexResponse;
        }

        public async Task<IIndexResponse> StoreMovieWatchableAsync(IMovieData movie)
        {
            var asyncIndexResponse = await _elasticClient
                .IndexAsync(movie);
            return asyncIndexResponse;
        }
    }
}
