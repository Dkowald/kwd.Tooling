# kwd.Templates

A small collection of some dotnet new templates.

## Install

Via [nuget](https://www.nuget.org/packages/kwd.Templates/):  
```console
#Install all 
dotnet new install kwd.Templates
```

Via Clone: 
```pwsh
git clone https://github.com/Dkowald/kwd.Tooling.git ./kwd.Tools

# Install just the templates you want.
dotnet new install ./kwd.Tools/src/kwd.Templates/DataStrings
```

## Templates

### FluxPart
Adds a razor component that uses fluxor, 
including backing .cs and .css files.

```pwsh
dotnet new FluxPart -n SampleComponent
```


### RazorPart
Adds a razor component, including its 
backing .cs and .css files.

```pwsh
dotnet new RazorPart -n SampleRazorComponent
```

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