FROM mcr.microsoft.com/dotnet/aspnet:8.0

RUN mkdir /Workspace \
  && mkdir /Workspace/Data \
  && mkdir /Workspace/Configuration \
  && mkdir /Workspace/Logs

ADD ./Other/Resources/DependentCodeUnits/TitaniumWebProxy2Backend/BuildResult_DotNet_win-x64 /Workspace/Application

WORKDIR /Workspace/Application
HEALTHCHECK CMD curl --insecure --fail https://localhost:443/HealthCheck
ENTRYPOINT ["dotnet", "/Workspace/Application/TitaniumWebProxy2Backend.dll"]
