using Soenneker.Tests.HostedUnit;

namespace Soenneker.Docker.Registry.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class DockerRegistryOpenApiClientRunnerTests : HostedUnitTest
{
    public DockerRegistryOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
