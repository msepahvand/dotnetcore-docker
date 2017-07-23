List all containers: `docker ps -aq`
Stop all containers: `docker stop $(docker ps -aq)`
Remove all containers: `docker rm $(docker ps -aq)`

Restore packages: `dotnet restore --no-cache`
Run tests: `dotnet test ./StudentApi.Tests/StudentApi.Tests.csproj`
Publish: `dotnet publish -c Release -o out`
Build docker image: `docker build -t studentapi .`

run docker (SQL Server container): `docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Password1!" -p 1433:1433 --name sqlserver -d microsoft/mssql-server-linux`

run docker (ASP.NET Core API container):`docker run -it --rm -p 5000:5000 --link sqlserver -e "SQLSERVER_HOST=sqlserver" -e "SA_PASSWORD=Password1!" studentapi`