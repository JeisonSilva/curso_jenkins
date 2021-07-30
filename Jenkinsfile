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
                bat 'dotnet test ./src/todobackend.sln /p:CollectCoverage=true /p:CoverletOutputFormat=opencover --no-build'
            }
        }
        stage("ANALISE SONARQUBE"){
            environment{
                scannerHome = tool 'SONAR_SCANNER'
            }
            steps{
                withSonarQubeEnv('SONAR_LOCAL'){
                    bat "${scannerHome}/bin/sonar-scanner -e -Dsonar.projectKey=TodoBackend -Dsonar.cs.opencover.reportsPaths=src/todobackend.Tests/coverage.opencover.xml -Dsonar.coverage.exclusions=**Test*.cs -Dsonar.host.url=http://localhost:9000 -Dsonar.login=0c09bbe076dfe2f87d40fd4ccc5350818b99b9f0"
                }
                
            }
        }
        stage("Quality Gate"){
            steps{
                sleep 300
                timeout(time: 1, unit: 'MINUTES'){
                    waitForQualityGate abortPipeline: true
                }
                
                
            }
        }
        
    }
}