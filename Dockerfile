FROM microsoft/aspnetcore-build
WORKDIR /StudentApi.Web  
COPY StudentApi.Web/out .
ENTRYPOINT ["dotnet", "StudentApi.Web.dll"]  