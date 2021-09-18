using System.Collections.Generic;
using System.Threading.Tasks;

namespace PollyFastRestClient.Components
{
    public interface ISearchComponent
    {
        Task<string> Search(string data);
    }
}
