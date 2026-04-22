using Soenneker.Tests.HostedUnit;

namespace Soenneker.AutoFaker.Overrides.Documents.Document.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class DocumentOverrideTests : HostedUnitTest
{
    public DocumentOverrideTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
