1. Select Default project CarRentalSystem.Infrastructure
2. Add-Migration <migration-name> -StartUpProject <start-up-project-name> -Context <DbContext-class-name>
3. Example: Add-Migration InitialDomainTable -StartUpProject CarRentalSystem.Startup -Context CarRentalDbContext
4. Update-Database -StartUpProject <start-up-project-name> -Context <DbContext-class-name>

https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?t