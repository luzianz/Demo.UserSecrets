# User Secrets

## Require `Microsoft.Extensions.SecretManager.Tools` tool.
```xml
<ItemGroup>
	<DotNetCliToolReference Include="Microsoft.Extensions.SecretManager.Tools" Version="2.0.0" />
</ItemGroup>
```

## Require `Microsoft.Extensions.Configuration.UserSecrets` package.
```xml
<ItemGroup>
	<PackageReference Include="Microsoft.Extensions.Configuration.UserSecrets" Version="2.0.0" />
</ItemGroup>
```

## Restore
```sh
dotnet restore
```

## Ensure you have `<UserSecretsId>some-id</UserSecretsId>` in your `.csproj` file.
```xml
<Project Sdk="Microsoft.NET.Sdk.Web">
	<PropertyGroup>
		<TargetFramework>netcoreapp2.0</TargetFramework>
		<UserSecretsId>Demo.UserSecrets</UserSecretsId>
	</PropertyGroup>
	<!-- ... -->
</Project>
```

## Set "MyPassword" as an example of a user secret.
```sh
dotnet user-secrets set MyPassword s00p3r-C-kr37p@sssWerD
```
To manage your user secrets, refer to `dotnet user-secrets --help`.

## Run the application in a "Development" environment
User secrets only work in Development.
```sh
ASPNETCORE_ENVIRONMENT=Development dotnet run
```