dotnet pack --configuration Release
nuget push "bin/Release/mdm.Extensions.1.0.0.nupkg" -Source https://api.nuget.org/v3/index.json