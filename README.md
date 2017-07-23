List all containers: `docker ps -aq`
Stop all containers: `docker stop $(docker ps -aq)`
Remove all containers: `docker rm $(docker ps -aq)`

 To run:


`dotnet publish -c Release -o out`
`docker build -t studentapi .`

`docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=Password1!" -p 1433:1433 --name sqlserver -d microsoft/mssql-server-linux`

`docker run -it --rm -p 5000:5000 --link sqlserver -e "SQLSERVER_HOST=sqlserver" -e "SA_PASSWORD=Password1!" studentapi`