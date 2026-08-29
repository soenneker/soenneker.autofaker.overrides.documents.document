[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.documents.document.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.documents.document/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.documents.document/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.documents.document/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.documents.document.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.documents.document/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.documents.document/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.documents.document/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Documents.Document

An AutoFaker (AutoBogus) override for the base Document object.

## Install

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Documents.Document
```

## What you get

- `DocumentOverride` — An AutoFaker (AutoBogus) override for the base Document object.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `DocumentOverride.CanOverride(context)` | Executes the can override operation. | A value indicating whether the operation succeeded. |
