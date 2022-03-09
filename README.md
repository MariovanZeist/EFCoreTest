# EFCoreTest
Project is used to demonstrate an issue with EFCore 6.0.2

run ``dotnet ef database update`` (this will update the database, but will not supply any data as it's not needed)
and then run the application.
It will crash.

Then downgrade ``Microsoft.EntityFrameworkCore.Design`` and ``Microsoft.EntityFrameworkCore.Sqlserver`` to 6.0.1
and run again.
It will now run until completion.
