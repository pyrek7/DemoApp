pipeline {
    agent any
    environment {
  dotnet = 'C:\\ProgramFiles\\dotnet\\dotnet.exe'
              }
    stages {
        stage('Build') {
            steps {
               bat 'dotnet build --configuration Release'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}
