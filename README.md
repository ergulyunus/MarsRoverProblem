# MarsRoverProblem

The solution is provided by using the State Pattern.

Unit test and Code Coverage Results:

+----------------+--------+--------+--------+
| Module         | Line   | Branch | Method |
+----------------+--------+--------+--------+
| MarsRover.Core | 57.36% | 36.36% | 63.15% |
+----------------+--------+--------+--------+

+---------+--------+--------+--------+
|         | Line   | Branch | Method |
+---------+--------+--------+--------+
| Total   | 57.36% | 36.36% | 63.15% |
+---------+--------+--------+--------+
| Average | 57.36% | 36.36% | 63.15% |
+---------+--------+--------+--------+

If you want to increase the code coverage rate, 
you can measure it by running the following command in the root folder after adding the unit test.

dotnet test MarsRover.Tests/MarsRover.Tests.csproj /p:CollectCoverage=true /p:CoverletOutputFormat=opencover
