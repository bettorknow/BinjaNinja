using System;
using System.Collections.Generic;
using System.Text;
using Elasticsearch.Net;
using Library.Watchable.Data.Artifacts;
using Newtonsoft.Json;

namespace Library.Watchables.Data.Elastic
{
    public class ElasticRetrieve : IWatchableRetrieve
    {
        private readonly IElasticLowLevelClient _elasticClient;

        public ElasticRetrieve(IElasticLowLevelClient elasticClient)
        {
            _elasticClient = elasticClient;
        }

        public ITvData RetrieveTvData(string title)
        {
            var searchResponse = _elasticClient.Search<string>("tv", new
            {
                from = 0,
                size = 10,
                query = new
                {
                    match = new
                    {
                        field = "title",
                        query = title
                    }
                }
            });
            return JsonConvert.DeserializeObject<ITvData>(searchResponse.Body);
        }

        public IMovieData RetrieveMovieData(string title)
        {
            var searchResponse = _elasticClient.Search<string>("movie", new
            {
                from = 0,
                size = 10,
                query = new
                {
                    match = new
                    {
                        field = "title",
                        query = title
                    }
                }
            });
            return JsonConvert.DeserializeObject<IMovieData>(searchResponse.Body);
        }
    }
}
