pipeline{
    agent any
    stages{
        stage("COMPILACAO BACKEND"){
            steps{
                bat 'dotnet build ./src/todobackend.sln'
            }
        }
        stage("TESTE BACKEND"){
            steps{
                bat 'dotnet test ./src/todobackend.sln --no-build'
            }
        }
        stage("ANALISE SONARQUBE"){
            steps{
                bat 'dotnet test ./src/todobackend.sln /p:CollectCoverage=true /p:CoverletOutputFormat=opencover --no-build'
                bat 'dotnet sonarscanner begin /k:"TodoBackend" /d:sonar.cs.opencover.reportsPaths=src/coverage.opencover.xml /d:sonar.coverage.exclusions="**Test*.cs" /d:sonar.host.url="http://localhost:9000"  /v:sonar.projectVersion=1.0.1 /d:sonar.login="0c09bbe076dfe2f87d40fd4ccc5350818b99b9f0"'
                bat 'dotnet build ./src/todobackend.sln'
                bat 'dotnet sonarscanner end /d:sonar.login="0c09bbe076dfe2f87d40fd4ccc5350818b99b9f0"'
            }
        }
        stage("QUALITY GATE"){
            steps{
                timeout(time: 1, unit: 'MINUTES') {
                    waitForQualityGate abortPipeline: true
                }
                
            }
        }
        
    }
}