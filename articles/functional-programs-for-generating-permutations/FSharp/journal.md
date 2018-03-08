### NuGet restore without internet connetion: 

First list the local sources: 

    dotnet nuget locals all --list

Then use one or more of them:

    dotnet restore --source C:\Users\bigfo\.nuget\packages\
    dotnet build --no-restore
