#!/bin/bash
set -ev
dotnet restore --no-cache
dotnet test ./StudentAPI.Tests/StudentAPI.Tests.csproj
dotnet publish -c Release -o out