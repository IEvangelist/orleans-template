# Orleans Template

[![.NET](https://github.com/IEvangelist/orleans-template/actions/workflows/dotnet.yml/badge.svg)](https://github.com/IEvangelist/orleans-template/actions/workflows/dotnet.yml)
[![CodeQL](https://github.com/IEvangelist/orleans-template/actions/workflows/codeql.yml/badge.svg)](https://github.com/IEvangelist/orleans-template/actions/workflows/codeql.yml)

GitHub repository template for Microsoft Orleans.

## In the template

- `src`: Main projects (the product code).
  - The template starts with _Abstractions.csproj_ and the _Grains.csproj_ projects, and a placeholder for a _Silo.csproj_ app project.
- `tests`: Test projects.
  - The template has  _Abstractions.Tests.csproj_ and the _Grains.Tests.csproj_ test projects.

## Get started

Create a new project in _src/Silo_ directory that will act as the client application. It should specify two project references, consuming both the _Abstractions.csproj_ and the _Grains.csproj_. The client app can be any kind of app that you require, for inspiration see [GitHub: Microsoft Orleans, Samples](https://github.com/dotnet/orleans/tree/main/samples).
