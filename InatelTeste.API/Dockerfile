#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5000
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

COPY ["InatelTeste.sln", "./"]

COPY ["src/InatelTeste.API/InatelTeste.API.csproj", "src/InatelTeste.API/"]
COPY ["src/InatelTeste.Application/InatelTeste.Application.csproj", "src/InatelTeste.Application/"]
COPY ["src/InatelTeste.Domain/InatelTeste.Domain.csproj", "src/InatelTeste.Domain/"]
COPY ["src/InatelTeste.Infrastructure/InatelTeste.Infrastructure.csproj", "src/InatelTeste.Infrastructure/"]

RUN dotnet restore
COPY . .

WORKDIR "/src/src/InatelTeste.API"
RUN dotnet build "InatelTeste.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "InatelTeste.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY wait-for-it.sh /usr/bin/wait-for-it
RUN chmod +x /usr/bin/wait-for-it

ENTRYPOINT ["wait-for-it", "mysql:3306", "--timeout=60", "--", "dotnet", "InatelTeste.API.dll"]