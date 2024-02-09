FROM mcr.microsoft.com/dotnet/sdk:6.0 as build
WORKDIR /app
COPY ./Core_Proje/*.csproj ./Core_Proje/
COPY ./DataAccessLayer/*.csproj ./DataAccessLayer/
COPY ./EntityLayer/*.csproj ./EntityLayer/
COPY ./BusinessLayer/*.csproj ./BusinessLayer/
COPY ./Core_Proje_Api/*.csproj ./Core_Proje_Api/
COPY *.sln .
RUN dotnet restore
COPY . .
RUN dotnet publish ./Core_Proje/*.csproj -o /publish/
FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /app
COPY --from=build /publish .
ENV ASPNETCORE_URLS="http://*:5000"
ENTRYPOINT ["dotnet", "Core_Proje.dll"]
