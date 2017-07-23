#!/bin/bash
set -ev
dotnet restore --no-cache
dotnet test ./StudentApi.Tests/StudentApi.Tests.csproj
dotnet publish -c Release -o out