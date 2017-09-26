using System;
using System.Threading.Tasks;
using Elasticsearch.Net;
using Library.Watchable.Data.Artifacts;
using Library.Watchables.Data.Elastic;
using Moq;
using Nest;
using NUnit.Framework;

namespace Library.Watchable.Data.Elastic.ElasticTests
{
    [TestFixture]
    public class ElasticStoreTests
    {
        [Test]
        public async Task ExpectElasticStore_StoresTvIndexAsync()
        {
            var settings = new ConnectionSettings(new Uri("http://192.168.0.60:9200"))
                .DefaultIndex("tv");

            var lowlevelClient = new ElasticClient(settings);
            var store = new ElasticStore(lowlevelClient);
            var retrieve = new ElasticRetrieve(lowlevelClient);

            var tvShow = new TvData
            {
                Title = "Game of Thrones",
                Episodes = 10,
                Series = 5
            };

            var id = await store.StoreTvWatchableAsync(tvShow);
            //Assert.That(id, Is.EqualTo(""));

            var tv = retrieve.RetrieveTvData(tvShow.Title);
        }
    }
}
