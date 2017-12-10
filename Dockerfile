FROM microsoft/dotnet:2.0.0-sdk

COPY ./StudentAPI.Web/out /app

WORKDIR /app

EXPOSE 80/tcp

RUN chmod +x ./entrypoint.sh

CMD /bin/bash ./entrypoint.sh