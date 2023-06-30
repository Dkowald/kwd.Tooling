# kwd.Templates

A small collection of some dotnet new templates.

## Install

Via [nuget](https://www.nuget.org/packages/kwd.Templates/):  
```console
dotnet new install kwd.Templates
```

Via Clone: 
```console
git clone https://github.com/Dkowald/kwd.Tooling.git ./kwd.Tools
dotnet new install ./kwd.Tools/src/kwd.Templates/DataStrings
```

## Templates

### DataStrings
A C# type to replace a raw string.  
Useful as a typesafe drop-in to replace string arguments.  
Uses the pattern from [kwd.CoreUtil](https://github.com/Dkowald/kwd.CoreUtil).
```console
dotnet new datastring -n SampleDataString
```

### Markdown
A starter Markdown (md)  
Defaults to Readme.md  
Includes cheet-sheet and links for quick reference.
```console
dotnet new md -n Readme.md
```

### CIBuild
A CI build / Traversal project
useful for
- Replacing the use of 'Soulution Folder'
- Explicitly defining build projects for Continuous Intergration (CI).
```console
dotnet new cibuild -n Repository
```