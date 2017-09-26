using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Library.Watchable.Data.Artifacts;
using Library.Watchables.Data.Elastic;
using Moq;
using Nest;
using NUnit.Framework;

namespace Library.Watchable.Data.Elastic.Tests
{
    [TestFixture]
    public class ElasticStoreTests
    {
        private Mock<IElasticClient> _client;
        private ElasticStore _store;
        
        [SetUp]
        public void Setup()
        {
            _client = new Mock<IElasticClient>();
            _store = new ElasticStore(_client.Object);
        }

        /*[TestCase("Starwars", "1978")]
        [TestCase("Something", "2011")]
        public async Task ElasticStore_ShouldAttemptToIndexMovie(string film, string year)
        {
            var movie = new Mock<IMovieData>();
            movie.Setup(m => m.Title).Returns(film);
            movie.Setup(m => m.Release).Returns(new DateTime(int.Parse(year),9,30));

            var response = new ElasticsearchResponse<string>(0, new List<int> { 1 });

            _client.Setup(c => c.IndexAsync<string>("movie", year, film, It.IsAny<PostData<object>>(),null,It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);

            await _store.StoreMovieWatchableAsync(movie.Object);

            _client.VerifyAll();
        }

        [TestCase("Game of Throne", 7, 68)]
        [TestCase("Something", 5, 100)]
        public async Task ElasticStore_ShouldAttemptToIndexTv(string tele, int series, int episodes)
        {
            var tv = new Mock<ITvData>();
            tv.Setup(m => m.Title).Returns(tele);
            tv.Setup(m => m.Episodes).Returns(episodes);
            tv.Setup(x => x.Series).Returns(series);

            var response = new ElasticsearchResponse<string>(0, new List<int> { 1 });

            _client.Setup(c => c.IndexAsync<string>("tv", tele, It.IsAny<PostData<object>>(), null, It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);

            await _store.StoreTvWatchableAsync(tv.Object);

            _client.VerifyAll();
        }*/
    }
}
