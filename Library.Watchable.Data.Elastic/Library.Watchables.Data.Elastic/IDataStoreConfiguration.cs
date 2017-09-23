using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Watchables.Data.Elastic
{
    public interface IDataStoreConfiguration
    {
        string ConnectionString { get; }
        TimeSpan Timeout { get; }
    }
}
