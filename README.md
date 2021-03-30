# KurtsStore

Placeholder

//TODO: Add purple prose

## Build Script
```
  dotnet new globaljson --sdk-version 5.0.201 --output KurtsStore/SportlandSports  
  dotnet new web --no-https --output KurtsStore/SportlandSports --framework net5.0  
  dotnet new sln -o KurtsStore  
  dotnet sln KurtsStore add KurtsStore/SportlandSports  
  dotnet new xunit -o KurtsStore/SportlandSports.Tests  
  dotnet add KurtsStore/SportlandSports.Tests reference KurtsStore/SportlandSports  
```
![Screenshot 1](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/ISTA_421_Lab_1B_Configure_and_Build.JPG "Screenshot 1")
