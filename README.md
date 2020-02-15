## Scrutor.AspNetCore

 ASP.NET Core [Scrutor](https://github.com/khellang/Scrutor) extension for automatic registration of classes inherited from IScopedLifetime, ISelfScopedLifetime, ITransientLifetime, ISelfTransientLifetime, ISingletonLifetime, ISelfSingletonLifetime

## Installation

Install the [Scrutor.AspNetCore NuGet Package](https://www.nuget.org/packages/Scrutor.AspNetCore).

### Package Manager Console

```
Install-Package Scrutor.AspNetCore
```

### .NET Core CLI

```
dotnet add package Scrutor.AspNetCore
```

## Usage

```csharp
public void ConfigureServices(IServiceCollection services)
{
    //add to the end of the method
    services.AddAdvancedDependencyInjection();
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    //add to the end of the method
    app.UseAdvancedDependencyInjection();
}

//usage without constructor classes
var service = ServiceLocator.Context.GetService<MyClass>();
```
