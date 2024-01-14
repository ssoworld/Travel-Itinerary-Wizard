dotnet test   -c Debug --collect:"XPlat Code Coverage" --verbosity normal  --settings coverlet.runsettings /p:CollectCoverage=true --results-directory ./coverage
cp coverage/**/coverage.cobertura.xml coverage.cobertura.xml
# dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:ExcludeByAttribute="CompilerGenerated"
reportgenerator -reports:"XUnit.Coverlet.Collector\testResults\**\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html