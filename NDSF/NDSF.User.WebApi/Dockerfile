#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["NDSF.User.WebApi/NDSF.User.WebApi.csproj", "NDSF.User.WebApi/"]
RUN dotnet restore "NDSF.User.WebApi/NDSF.User.WebApi.csproj"
COPY . .
WORKDIR "/src/NDSF.User.WebApi"
RUN dotnet build "NDSF.User.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "NDSF.User.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "NDSF.User.WebApi.dll"]