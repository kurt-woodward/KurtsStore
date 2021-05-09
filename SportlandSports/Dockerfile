#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0
FROM mcr.microsoft.com/dotnet/sdk:5.0

COPY ["/bin/Release/net5.0/publish", "SportlandSports/"]

ENV ASPNETCORE_ENVIRONMENT Production

EXPOSE 5000
WORKDIR /SportlandSports
ENTRYPOINT ["dotnet", "SportlandSports.dll", "--urls=http://0.0.0.0:5000"]