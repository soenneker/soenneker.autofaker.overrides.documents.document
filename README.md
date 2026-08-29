[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.documents.document.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.documents.document/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.documents.document/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.documents.document/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.documents.document.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.documents.document/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.documents.document/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.documents.document/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Documents.Document

An AutoFaker override that gives `Document` models internally consistent identifiers and timestamps.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Documents.Document
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Documents.Document;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides = [new DocumentOverride()];

OrderDocument document = autoFaker.Generate<OrderDocument>();
```

The override applies to `Document` and derived types. It sets:

- `DocumentId` to a GUID string.
- `PartitionKey` to the same value as `DocumentId`.
- `CreatedAt` and `ModifiedAt` to the same current UTC timestamp.

When combining this with a more specific override, put the specific override later in `Config.Overrides` if it should replace any of these values.
