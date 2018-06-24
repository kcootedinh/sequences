# Sequence coding assessment

Solution by Kieran Coote-Dinh 

## Getting Started

### Prerequisites

This project is a ASP.NET Core project and requires .NET Core 2.1. Retrieve .NET Core SDK from (https://www.microsoft.com/net/download/windows)

### Building

The solution can be built with dotnet build from the root folder.

```
dotnet build
```

Nuget dependencies can be restored with dotnet restore from the root folder, or individual project folders. A dotnet build will, if necessary, restore dependencies.  

```
dotnet restore
```

## Running the application

The solution can be run with dotnet run from within the Sequences project, and visiting the url [http://localhost:5000](http://localhost:5000). dotnet run will, if necessary, restore dependencies and build the solution.

```
cd Sequences
dotnet run
```

Alternatively, the tests can be run in Visual Studio, or other supporting IDEs.

## Running the tests

Change into the Sequences.Tests.Unit directory.

```
cd Sequences.Tests.Unit
```

and run dotnet test.

```
dotnet test
```

Alternatively, the tests can be run in Visual Studio, or other supporting IDEs.