#!/bin/bash
set -e
run_cmd="dotnet /app/StudentAPI.Web/out/StudentAPI.Web.dll --server.urls http://*:5000"
cd /app/StudentAPI.Core
until dotnet ef database update; do
>&2 echo "SQL Server is starting up"
sleep 1
done
>&2 echo "SQL Server is up - executing command"
exec $run_cmd