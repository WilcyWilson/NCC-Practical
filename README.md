# NCC-Practical
## Enable Runtime Compilation in an existing project
### 1. Install the Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation NuGet package.
Through CLI. Use your current dotnet version. 
```console
dotnet add package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation --version 5.0.3
```

To check your current dotnet version type.
```console
dotnet --info
```

### 2. Update the project's Startup.ConfigureServices method to include a call to AddRazorRuntimeCompilation. For example:
```cs
public void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages()
        .AddRazorRuntimeCompilation();

    // code omitted for brevity
}
```
## Enable Runtime Compilation at project creation
```console
dotnet new mvc --razor-runtime-compilation
```
