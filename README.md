# MarsRoverProblem

The solution is provided by using the State Pattern.

Unit test and Code Coverage Results:

![image](https://user-images.githubusercontent.com/42169539/160299723-99b6834e-a379-4e74-bfdf-2516677e4b34.png)


If you want to increase the code coverage rate, 
you can measure it by running the following command in the root folder after adding the unit test.

dotnet test MarsRover.Tests/MarsRover.Tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
