using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;
using System;

namespace Soenneker.AutoFaker.Overrides.Documents.Document;

/// <summary>
/// An AutoFaker (AutoBogus) override for the base Document object
/// </summary>
public class DocumentOverride : AutoFakerOverride<Soenneker.Documents.Document.Document>
{
    public override bool CanOverride(AutoFakerContext context)
    {
        return context.GenerateType.IsSubclassOf(typeof(Soenneker.Documents.Document.Document));
    }

    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Soenneker.Documents.Document.Document)!;

        // These can be overriden with more specific type overrides
        target.DocumentId = context.Faker.Random.Guid().ToString();
        target.PartitionKey = target.DocumentId;

        DateTime utcNow = DateTime.UtcNow;
        target.CreatedAt = utcNow;
        target.ModifiedAt = utcNow;
    }
}