using System.Collections.Generic;

namespace PollyFastRestClient.Components
{
    public interface ISearchComponent
    {
        List<T> Search<T>();
    }
}
