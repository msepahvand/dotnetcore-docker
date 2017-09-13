[![Build Status](https://travis-ci.org/msepahvand/dotnetcore-docker.svg?branch=master)](https://travis-ci.org/msepahvand/dotnetcore-docker)

Start by:

`docker-compose build`

`docker-compose up`

Helpful docker commands

List all containers: `docker ps -aq`

Stop all containers: `docker stop $(docker ps -aq)`

Remove all containers: `docker rm $(docker ps -aq)`

### Deploy to Amazon ECS

The ECS CLI allows us to deploy multi container apps with docker-compose. The CLI is currently (September 2017) only available for Linux. Also it only supports version 2 of the docker-compose syntax.
More about the [gotchas of docker-compose on the ECS CLI].

1 - Install the ECS CLI:
`sudo curl -o /usr/local/bin/ecs-cli https://s3.amazonaws.com/amazon-ecs-cli/ecs-cli-linux-amd64-latest`

`sudo chmod +x /usr/local/bin/ecs-cli`


2 - Configure the ECS CLI
`ecs-cli configure --region ap-southeast-2 --access-key AWS_ACCESS_KEY --secret-key AWS_SECRET_KEY --cluster ecs-cli-demo`

3 - Create an ECS cluster
Here we create an ECS cluster which is 1 instance of type t2.medium, note that we need to generate a key pair in EC2 dashboard which maps to `EC2_KEY_PAIR_NAME` here
`ecs-cli up --keypair EC2_KEY_PAIR_NAME --capability-iam --size 1 --instance-type t2.medium --force`

4 - Create and start an ECS task
Create an ECS task definition and run the containers (From a directory containing a `docker-compose.yml`):
`ecs-cli compose up`

5 - List running containers (Gives you the status of the container cluster and if running the public IP)
`ecs-cli compose ps`

# References
[.Net Core and SQL Server In Docker - Part 1]

[Building and shipping a .NET Core application with Docker and TravisCI]

[Amazon ECS: using the CLI with Docker Compose]

[Docker cluster management on AWS]

[.Net Core and SQL Server In Docker - Part 1]: <http://blog.kontena.io/dot-net-core-and-sql-server-in-docker/>

[Building and shipping a .NET Core application with Docker and TravisCI]: <https://dusted.codes/building-and-shipping-a-dotnet-core-application-with-docker-and-travisci>

[Docker cluster management on AWS]:<https://medium.com/@Electricste/amazon-ecs-using-the-cli-with-docker-compose-74287f19b181>

[gotchas of docker-compose on the ECS CLI]:<https://laszlo.cloud/Docker-cluster-management-on-AWS>

[Amazon ECS: using the CLI with Docker Compose]:<https://medium.com/@Electricste/amazon-ecs-using-the-cli-with-docker-compose-74287f19b181>