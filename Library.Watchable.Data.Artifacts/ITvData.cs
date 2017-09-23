using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Watchable.Data.Artifacts
{
    public interface ITvData : IWatchableData
    {
        int Episodes { get; set; }
        int Series { get; set; }
    }
}
