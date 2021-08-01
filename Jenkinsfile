pipeline{
    agent any
    environment {
        DOTNET_ROOT = "/opt/jenkins/tools/com.cloudbees.jenkins.plugins.customtools.CustomTool/dotnet-sdk-3.1/"
        PATH = "/opt/jenkins/tools/com.cloudbees.jenkins.plugins.customtools.CustomTool/dotnet-sdk-3.1/:$PATH"
    }
    stages{
        stage("COMPILACAO BACKEND"){
            steps{
                sh 'dotnet build ./src/todobackend.sln'
            }
        }
        stage("TESTE BACKEND"){
            steps{
                sh 'dotnet test ./src/todobackend.sln /p:CollectCoverage=true /p:CoverletOutputFormat=opencover --no-build'
            }
        }
        stage("ANALISE SONARQUBE"){
            environment{
                scannerHome = tool 'SONAR_SCANNER'
            }
            steps{
                withSonarQubeEnv('SONAR_LOCAL'){
                    sh "${scannerHome}/bin/sonar-scanner -e -Dsonar.projectKey=TodoBackend -Dsonar.cs.opencover.reportsPaths=src/todobackend.Tests/coverage.opencover.xml -Dsonar.coverage.exclusions=**Test*.cs -Dsonar.host.url=http://172.24.0.4:9000 -Dsonar.login=0c09bbe076dfe2f87d40fd4ccc5350818b99b9f0"
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