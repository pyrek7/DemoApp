pipeline {
    agent any

    stages {
       stage('Build') {
 steps {
  bat "msbuild.exe ${workspace}\\DemoApp.csproj /nologo /nr:false  /p:platform=\"x64\" /p:configuration=\"release\"/t:clean;restore;rebuild"
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
