dotnet pack --configuration Release
dotnet nuget push "bin/Release/mdm.Extensions.1.0.0.nupkg" --source "github"