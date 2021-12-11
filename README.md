# template-roslyn-analyzer

[![CI](https://github.com/mrahhal/template-roslyn-analyzer/actions/workflows/ci.yml/badge.svg)](https://github.com/mrahhal/template-roslyn-analyzer/actions/workflows/ci.yml)
[![NuGet version](https://badge.fury.io/nu/template-roslyn-analyzer.svg)](https://www.nuget.org/packages/template-roslyn-analyzer)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://opensource.org/licenses/MIT)

A template for a Roslyn analyzer.

## Features

- .NET 6 + C# 10 + NRT (nullable reference types) + ImplicitUsings
- VSIX for debugging analyzer
- GitHub CI action to build and test

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

## Used by

- https://github.com/mrahhal/MR.Analyzers.Whitespace
- https://github.com/mrahhal/MR.Analyzers.Records

<!--
## Include in your project

```xml
<PackageReference Include="template-roslyn-analyzer" Version="1.0.0" PrivateAssets="All" />
```
-->

## Rules

- `T1000`: AvoidSomething: Analyzer/Fixer for avoiding something
