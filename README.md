# template-roslyn-analyzer

[![CI](https://github.com/mrahhal/template-roslyn-analyzer/actions/workflows/ci.yml/badge.svg)](https://github.com/mrahhal/template-roslyn-analyzer/actions/workflows/ci.yml)
[![NuGet version](https://badge.fury.io/nu/template-roslyn-analyzer.svg)](https://www.nuget.org/packages/template-roslyn-analyzer)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.txt)

A template for a Roslyn analyzer.

This is for my own use, but feel free to use it if it helps you. The CI workflow uses a shared workflow of mine from another repo, it might change without notice.

## Features

- .NET 7 + C# 11 + NRTs (nullable reference types) + ImplicitUsings
- VSIX for debugging analyzer
- GitHub CI action to build, test, and release

## Checklist

You can use the prepare.ps1 script to bulk rename/replace "template-roslyn-analyzer" to the repo folder name:

```
./prepare
```

Manual checklist:

- Replace "template-roslyn-analyzer" in file and file names with your repo name
- Rename the "TemplateRoslynAnalyzer" namespace
- Update LICENSE.txt
- Replace "Mohammad Rahhal"
- Uncomment sections in this README
- Add `NUGET_TOKEN` GitHub secret for CI (can be created from [here](https://www.nuget.org/account/apikeys))

## Used by

- https://github.com/mrahhal/MR.Analyzers.Whitespace
- https://github.com/mrahhal/MR.Analyzers.Records

<!--
## Include in your project

```xml
<PackageReference Include="template-roslyn-analyzer" Version="{version}" PrivateAssets="All" ExcludeAssets="compile" />
```
-->

## Rules

- `T1000`: AvoidSomething: Analyzer/Fixer for avoiding something
