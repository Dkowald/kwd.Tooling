# Overview
Various .NET Core templates to assist development.  
These as specialized to my own needs, so may not have general usage.  
But they can be used as further dotnet new template examples.

## DataStrings
A C# type to replace a raw string.  
Useful as a typesafe drop-in to replace string arguments.  
Uses the pattern from [kwd.CoreUtil](https://github.com/Dkowald/kwd.CoreUtil).
```console
dotnet new datastring
```
## Markdown
A starter Markdown (md)  
Defaults to Readme.md  
Includes cheet-sheet and links for quick reference.
```console
dotnet new md
```
## CIBuild
A CI build / Traversal project
useful for
- Replacing the use of 'Soulution Folder'
- Explicitly defining build projects for Continuous Intergration (CI).
```console
dotnet new cibuild
```
-----
^ [source](https://github.com/Dkowald/kwd.Tooling) / [nuget](https://www.nuget.org/packages/kwd.Templates)

^^ Icon by <a href="https://www.svgrepo.com" target="_blank">SVG Repo</a>  