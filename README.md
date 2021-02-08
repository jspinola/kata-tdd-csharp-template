# README.md

Three sample templates to start a TDD kata with C#

## minimal-template
Contains the minimal C# structure to work with, containing a single test project and the sources in the same place

### Run the tests

```
cd minimal-template
dotnet test
```

## project-template
Contains the minimal C# project structure to work with having production code separate from tests, containing a class lib project and the corresponding test project

### Run the tests

```
cd project-template
dotnet test Kata.Tests
```
## solution-template
Contains the minimal C# solution, containing a class lib project and the corresponding test project

### Run the tests

```
cd solution-template
dotnet test
```

## Requirements

.NET 5