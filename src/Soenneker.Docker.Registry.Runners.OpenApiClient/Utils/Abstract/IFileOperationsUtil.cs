using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Docker.Registry.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
