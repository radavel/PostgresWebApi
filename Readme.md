# Postgres Web Api

## Pre-requisites
### Set up Postges SQL
1.- Install Postgres SQL in your env https://www.postgresql.org/download/
2.- Install a Postgres SQL DB Manager https://www.pgadmin.org/download/

### Install dotnet on your CLI

- Install <code>dotnet</code> command:
https://learn.microsoft.com/en-us/dotnet/core/install/windows?tabs=net60
- Install <code>dotnet ef</code> command:
https://learn.microsoft.com/en-us/ef/core/cli/dotnet

<hr>

### Connect project to your postgres
1. Open the project on your favorite IDE editor:
    - https://visualstudio.microsoft.com/es/downloads/
    - https://code.visualstudio.com/
2. Locate <code>appsettings.json</code> file and open it.
3. Update the string named <code>PostgresSQLConnection</code> with your own connection settings.
    - >Host={host};Port={port};Database={database};User Id={user};Password={password};
4. Done

### Run Migrations
In order to create your db and tables we need to run the migrations. Run the commands below:

<code>dotnet build</code>
<code>dotnet ef database update</code>

<hr>

### Run project
If you are using **Visual Studio** as your IDE just click over play button on top, if not, you can run the it with the following command:
<code>dotnet run</code>

### Use Swagger
You can read more about what is Swagger here https://swagger.io, but simply it's a way to test our endpoints from our WebApi.

>**Important**: You need to have running the project.

Open the following URL on your browser:
https://localhost:7253/swagger
You will see a list with all the endpoints grouped by entity.

>**Note**: You can change the project ports if you want at any time. Just need to update your *lauchSettings.json* inside *Properties* folder. 
