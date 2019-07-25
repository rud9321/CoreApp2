

database migration --
dotnet ef --startup-project ../susa.core.api migrations add initialmigration

database update --
dotnet ef --startup-project ../susa.core.api database update