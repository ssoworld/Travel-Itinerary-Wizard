dotnet test  --collect:"XPlat Code Coverage" --settings coverlet.runsettings /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura
# dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:ExcludeByAttribute="CompilerGenerated"
reportgenerator -reports:"XUnit.Coverlet.Collector\testResults\**\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html