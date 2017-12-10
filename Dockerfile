FROM microsoft/dotnet:2.0.0-sdk

COPY ./StudentAPI.Web /app

WORKDIR /app

RUN dotnet publish ./StudentAPI.Web.csproj -c Release -o out -r linux-x64

EXPOSE 80/tcp

RUN chmod +x ./entrypoint.sh

CMD /bin/bash ./entrypoint.sh