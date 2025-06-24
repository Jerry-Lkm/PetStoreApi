# PetStoreApi

This project is just cloned from PetStore.

Initial CQRS pattern has been set up for APIs.

## Entity Framework Migrations

To implement and manage database migrations with .NET Entity Framework:

1. Install the required tools (if not already installed):
   ```bash
   dotnet tool install --global dotnet-ef
   ```
2. Add a migration (If have any update/add for DataContext):
   ```bash
   dotnet ef migrations add <MigrationName> --project PetStore.DataLayer --startup-project PetStore.Api
   ```
   Replace `<MigrationName>` with a descriptive name for your migration.
3. Update the database:
   ```bash
   dotnet ef database update --project PetStore.DataLayer --startup-project PetStore.Api
   ```
4. To remove the last migration (if needed):
   ```bash
   dotnet ef migrations remove --project PetStore.DataLayer --startup-project PetStore.Api
   ```

For more details, see the official [EF Core documentation](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/).