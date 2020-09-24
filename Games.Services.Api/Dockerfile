#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-nanoserver-1903 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-nanoserver-1903 AS build
WORKDIR /src
COPY ["Games.Services.Api/Games.Services.Api.csproj", "Games.Services.Api/"]
COPY ["Games.Infra.CrossCutting.IoC/Games.Infra.CrossCutting.IoC.csproj", "Games.Infra.CrossCutting.IoC/"]
COPY ["Games.Infra.Data/Games.Infra.Data.csproj", "Games.Infra.Data/"]
COPY ["Games.Domain.Core/Games.Domain.Core.csproj", "Games.Domain.Core/"]
COPY ["Games.Domain/Games.Domain.csproj", "Games.Domain/"]
COPY ["Game.Infra.CrossCutting.Bus/Game.Infra.CrossCutting.Bus.csproj", "Game.Infra.CrossCutting.Bus/"]
COPY ["Games.Application/Games.Application.csproj", "Games.Application/"]
COPY ["Games.Infra.CrossCutting.Identity/Games.Infra.CrossCutting.Identity.csproj", "Games.Infra.CrossCutting.Identity/"]
RUN dotnet restore "Games.Services.Api/Games.Services.Api.csproj"
COPY . .
WORKDIR "/src/Games.Services.Api"
RUN dotnet build "Games.Services.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Games.Services.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Games.Services.Api.dll"]