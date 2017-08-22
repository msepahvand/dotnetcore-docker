#!/bin/bash
set -e
run_cmd="dotnet /app/StudentAPI.Web/out/StudentAPI.Web.dll --server.urls http://*:5000"
exec $run_cmd