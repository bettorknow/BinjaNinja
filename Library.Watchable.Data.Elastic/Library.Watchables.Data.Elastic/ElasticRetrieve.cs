using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Elasticsearch.Net;
using Library.Watchable.Data.Artifacts;
using Nest;
using Newtonsoft.Json;

namespace Library.Watchables.Data.Elastic
{
    public class ElasticRetrieve : IWatchableRetrieve
    {
        private readonly IElasticClient _elasticClient;

        public ElasticRetrieve(IElasticClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public ITvData RetrieveTvData(string title)
        {
            var searchResponse = _elasticClient.Search<TvData>(s => s
                    .AllTypes()
                    .From(0)
                    .Size(10)
                    .Query(q => q
                        .Match(m => m
                            .Field(f => f.Title)
                            .Query(title)
                        )
                    ))
                ;
            return searchResponse.Documents.First();
        }

        public IMovieData RetrieveMovieData(string title)
        {
            var searchResponse = _elasticClient.Search<MovieData>(s => s
                    .AllTypes()
                    .From(0)
                    .Size(10)
                    .Query(q => q
                        .Match(m => m
                            .Field(f => f.Title)
                            .Query(title)
                        )
                    ))
                ;
            return searchResponse.Documents.First();
        }
    }
}
