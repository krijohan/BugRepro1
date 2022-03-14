do {dotnet test --logger "console;verbosity=detailed" .\BugRepro1.sln} until (!$?)
