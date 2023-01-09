# Dev Notes

## How much time I spent on this exercise

2Hours

## Here's What I Fixed/Refactored/Added (in order of implementation, highest priority first)

Create console project using VSCODE with the following command

dotnet new console --framework net7.0

Add ReadMe.MD file

Add Empolyee class to Models 

Add Business Logic Layer for employee

Implement DisplayManagementTree in Program.cs and update the main to call it

Update Program.cs to use Dependency Injection

## Further Improvements I Would Make If I Had More Time (in order of implementation, highest priority first)

implement proper dependency injection, use a proper third-party IOC container

upgrade to an existing logger like log4net, no need to reinvent the wheel, which should be generic and using factory pattern.

## Here's What I Would Like to Talk About At The Interview

The default result I was getting is ordered by Id

->Tom
->->Mickey
->->->John
->->Jerry
->->Sarah

To meet the expected output result, I have made the assumption that the output is in alphabetical order