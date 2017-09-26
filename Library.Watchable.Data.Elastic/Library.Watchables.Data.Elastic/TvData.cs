using Library.Watchable.Data.Artifacts;

namespace Library.Watchables.Data.Elastic
{
    public class TvData : ITvData
    {
        public string Title { get; set; }
        public int Episodes { get; set; }
        public int Series { get; set; }
    }
}
