#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["nix_project/DnD_Charlist.BLL/DnD_Charlist.BLL.csproj", "nix_project/DnD_Charlist.BLL/"]
RUN dotnet restore "nix_project/DnD_Charlist.BLL/DnD_Charlist.BLL.csproj"
COPY . .
WORKDIR "/src/nix_project/DnD_Charlist.BLL"
RUN dotnet build "DnD_Charlist.BLL.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DnD_Charlist.BLL.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DnD_Charlist.BLL.dll"]