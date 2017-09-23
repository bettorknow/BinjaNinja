using System;
using Elasticsearch.Net;
using Library.Watchable.Data.Artifacts;
using Library.Watchables.Data.Elastic;
using Moq;
using NUnit.Framework;

namespace Library.Watchable.Data.Elastic.ElasticTests
{
    [TestFixture]
    public class ElasticStoreTests
    {
        [Test]
        public void ExpectElasticStore_StoresTvIndex()
        {
            var settings = new ConnectionConfiguration(new Uri("http://192.168.0.60:9200"))
                .RequestTimeout(TimeSpan.FromMinutes(2));

            var lowlevelClient = new ElasticLowLevelClient(settings);
            var store = new ElasticStore(lowlevelClient);

            var tvShow = new TvData
            {
                Title = "tvshow",
                Episodes = 10,
                Series = 5
            };

            var id = store.StoreTvWatchableAsync(tvShow);
            Assert.That(id, Is.EqualTo(""));
        }
    }
}
