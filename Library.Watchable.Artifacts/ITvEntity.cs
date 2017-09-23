using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Watchable.Artifacts
{
    public interface ITvEntity
    {
        string Title { get;  }
        int? Seasons { get; }
        int? Episodes { get; }
    }
}
