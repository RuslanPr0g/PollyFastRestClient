using ExamplePollyFastRestClient.Enums;
using System.Threading.Tasks;

namespace ExamplePollyFastRestClient.Services
{
    public interface IGenderService
    {
        Task<Gender> Predict(string name);
    }
}
