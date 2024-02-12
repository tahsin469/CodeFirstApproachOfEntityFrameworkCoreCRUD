
``````````````````````````````````````````````````````````````````````````````````````````````````````````````````
<Project Sdk="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net6.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.26">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="6.0.26" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.26">
      <PrivateAssets>all</PrivateAssets>
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="6.0.16" />
  </ItemGroup>

</Project>


````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````````

1. Create your first migration : Add-Migration InitialCreate
2. Create your database and schema : Update-Database
3. Evolving your model : Add-Migration AddBlogCreatedTimestamp, Update-Database
4. 

