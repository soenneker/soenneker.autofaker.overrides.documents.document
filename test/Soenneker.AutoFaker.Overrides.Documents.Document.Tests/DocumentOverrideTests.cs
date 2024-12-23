using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.AutoFaker.Overrides.Documents.Document.Tests;

[Collection("Collection")]
public class DocumentOverrideTests : FixturedUnitTest
{
    public DocumentOverrideTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
