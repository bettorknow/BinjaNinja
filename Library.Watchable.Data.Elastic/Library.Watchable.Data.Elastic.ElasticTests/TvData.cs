using System;
using System.Collections.Generic;
using System.Text;
using Library.Watchable.Data.Artifacts;

namespace Library.Watchable.Data.Elastic.ElasticTests
{
    public class TvData : ITvData
    {
        public string Title { get; set; }
        public int Episodes { get; set; }
        public int Series { get; set; }
    }
}
