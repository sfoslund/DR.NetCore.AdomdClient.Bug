#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["DR.NetCore.AdomdClient.Bug.csproj", ""]
RUN dotnet restore "./DR.NetCore.AdomdClient.Bug.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "DR.NetCore.AdomdClient.Bug.csproj" -c Release -o /app/build
