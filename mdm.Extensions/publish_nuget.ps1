remove-item bin\Release\*.nupkg
dotnet pack --configuration Release
nuget push bin\Release\*.nupkg -Source https://api.nuget.org/v3/index.json