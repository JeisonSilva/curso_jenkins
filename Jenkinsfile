pipeline{
    agent any
    stages{
        stage("Compilando aplicação"){
            steps{
                bat 'dotnet build ./src/todobackend.sln'
            }
        }
    }
}