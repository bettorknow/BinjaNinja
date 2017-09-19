using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Library.Watchable.Artifacts;

namespace Library.Watchable.Entities
{
    public class TvEntity : ITvEntity
    {
        public TvEntity With(Action<TvEntity> configure)
        {
            configure(this);
            return this;
        }

        public string Title { get; internal set; }
        public int? Seasons { get; internal set; }
        public int? Episodes { get; internal set; }
    }
}
