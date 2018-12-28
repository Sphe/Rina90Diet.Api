FROM microsoft/dotnet:2.1-sdk AS build

WORKDIR /app

# copy
COPY . ./


WORKDIR /app/Rina90Diet.Front.ApiWeb

RUN dotnet restore
RUN dotnet publish -c release -o out -r linux-x64

# build runtime image
FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/Rina90Diet.Front.ApiWeb/out ./
ENTRYPOINT ["dotnet", "Rina90Diet.Front.ApiWeb.dll"]
CMD []