#!/bin/bash
set -ev
dotnet restore StudentAPI.sln --no-cache
dotnet test ./StudentAPI.Tests/StudentAPI.Tests.csproj
dotnet publish ./StudentAPI.Web/StudentAPI.Web.csproj -c Release -o out -r linux-x64