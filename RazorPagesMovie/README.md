# Tutorials-net6-0-WebApps-RazorPages
https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-6.0

## Part 01: Get started with Razor Pages in ASP.NET Core
    dotnet new webapp -o RazorPagesMovie

## Part 02: Add a model to a Razor Pages app in ASP.NET Core
Commands must be run from the project root directory (Program.cs path)
1) Add a folder named Models.
2) Add a class to the Models folder named Movie.cs
3)
        dotnet add package Microsoft.EntityFrameworkCore.Design
        dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer
        
4) [dotnet-aspnet-codegenerator (Scaffolding)](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-6.0 "ASP.NET Core scaffolding engine")

        dotnet-aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovie.Data.RazorPagesMovieContext -udl -outDir Pages/Movies --referenceScriptLibraries
        
5) Add initial migration snapshot

        dotnet ef migrations add "Initial" --context RazorPagesMovie.Data.RazorPagesMovieContext --output-dir ./Data/Migrations
        dotnet ef database update

## Part 04
1) Create the database seed (SeedData class in Models)
2) Add the seed initializer

## Part 05: Update the generated pages in an ASP.NET Core app
1) Update Movie model with more data annotations
2) Add route template to Edit, Details, and Delete pages

## Part 06: Add search to ASP.NET Core Razor Pages
Add search to movies by title or genre

## Part 07: Add a new field to a Razor Page in ASP.NET Core
1) Add a Rating property to the Movie model
2) Add Rating to Movies pages
3) Apply migrations

        dotnet ef migrations add rating
        dotnet ef database update

## Part 08
1) Add validation logic rules (DataAnnotations) to the Movie model
    * use built-in [Required], [StringLength], [RegularExpression], and [Range] validation attributes
    * use built-in [DataType] attribute
2) Apply migrations

        dotnet ef migrations add New_DataAnnotations
        dotnet ef database update
