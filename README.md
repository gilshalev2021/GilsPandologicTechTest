# PandologicTechTest

The Server was built with .NET 6.0, The client was built with Angular 12

The
To run the server:

- Restore NuGet Packages
- To Create the database with initial data seed, from the Package Manager Console, run: update-database
- Update the connection string in Program.cs file to address your local SQLEXPRESS server
- Run the PandologicTechTestApi profile, since the client is configured to look for its url, at localhost:7072 !!!

To run the client:
- Run ‘npm install’
- Run ‘ng serve --open’
     
To run the Unit Tests:

- Update the connection string in the relevant tests to address your local SQLEXPRESS server


