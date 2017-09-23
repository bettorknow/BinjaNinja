using System;
using System.Collections.Generic;
using System.Text;
using Elasticsearch.Net;
using Library.Watchables.Data.Elastic;
using Moq;
using NUnit.Framework;

namespace Library.Watchable.Data.Elastic.Tests
{
    [TestFixture]
    public class ElasticRetrieveTests
    {
        private Mock<IElasticLowLevelClient> _client;
        private ElasticRetrieve _retriever;

        [SetUp]
        public void Setup()
        {
            _client = new Mock<IElasticLowLevelClient>();
            _retriever = new ElasticRetrieve(_client.Object);
        }

        [TestCase("Search")]
        [TestCase("Nothing")]
        [TestCase("Starwars")]
        public void ElasticStore_ShouldAttemptToRetrieveMovie(string film)
        {
            var elasticResponse = new ElasticsearchResponse<string>(0, new List<int>{0});
            _client.Setup(x => x.Search<string>("movie",It.IsAny<PostData<object>>(), null)).Returns(elasticResponse);

            Assert.Throws<ArgumentNullException>(()=> _retriever.RetrieveMovieData(film));

            _client.VerifyAll();
        }

        [TestCase("Search")]
        [TestCase("Nothing")]
        [TestCase("Game of Thrones")]
        public void ElasticStore_ShouldAttemptToRetrieveTv(string tele)
        {
            var elasticResponse = new ElasticsearchResponse<string>(0, new List<int> { 0 });
            _client.Setup(x => x.Search<string>("tv", It.IsAny<PostData<object>>(), null)).Returns(elasticResponse);

            Assert.Throws<ArgumentNullException>(() => _retriever.RetrieveTvData(tele));

            _client.VerifyAll();
        }
    }
}
