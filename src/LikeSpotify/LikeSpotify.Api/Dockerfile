#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["LikeSpotify.Api/LikeSpotify.Api.csproj", "LikeSpotify.Api/"]
COPY ["LikeSpotify.Repository/LikeSpotify.Repository.csproj", "LikeSpotify.Repository/"]
COPY ["LikeSpotify.CrossCutting/LikeSpotify.CrossCutting.csproj", "LikeSpotify.CrossCutting/"]
COPY ["LikeSpotify.Domain/LikeSpotify.Domain.csproj", "LikeSpotify.Domain/"]
COPY ["LikeSpotify.Application/LikeSpotify.Application.csproj", "LikeSpotify.Application/"]
RUN dotnet restore "LikeSpotify.Api/LikeSpotify.Api.csproj"
COPY . .
WORKDIR "/src/LikeSpotify.Api"
RUN dotnet build "LikeSpotify.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LikeSpotify.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LikeSpotify.Api.dll"]