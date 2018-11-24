FROM microsoft/dotnet:2.1.300-sdk

COPY . /app

WORKDIR /app

RUN dotnet publish ./StudentAPI.Web/StudentAPI.Web.csproj -c Release -o out -r linux-x64

EXPOSE 80/tcp

RUN chmod +x ./entrypoint.sh

CMD /bin/bash ./entrypoint.sh