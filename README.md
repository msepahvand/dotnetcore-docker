[![Build Status](https://travis-ci.org/elduderino87/dotnetcore-docker.svg?branch=master)](https://travis-ci.org/elduderino87/dotnetcore-docker)

Start by:

`docker-compose build`
`docker-compose up`

Helpful docker commands

List all containers: `docker ps -aq`

Stop all containers: `docker stop $(docker ps -aq)`

Remove all containers: `docker rm $(docker ps -aq)`

# References
[.Net Core and SQL Server In Docker - Part 1]

[Building and shipping a .NET Core application with Docker and TravisCI]


[.Net Core and SQL Server In Docker - Part 1]: <http://blog.kontena.io/dot-net-core-and-sql-server-in-docker/>

[Building and shipping a .NET Core application with Docker and TravisCI]: <https://dusted.codes/building-and-shipping-a-dotnet-core-application-with-docker-and-travisci>