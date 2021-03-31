# KurtsStore

The purpose of this assignment is to demonstrate to the student how C# business logic, SQL-style databases, Razor, HTML, and CSS all come together to make a funtioning, practical website. It is an ongoing assignment that will be improved incrementally throughout the course as the author dives more deeply into individual topics.  

## Build Script
```
  dotnet new globaljson --sdk-version 5.0.201 --output KurtsStore/SportlandSports  
  dotnet new web --no-https --output KurtsStore/SportlandSports --framework net5.0  
  dotnet new sln -o KurtsStore  
  dotnet sln KurtsStore add KurtsStore/SportlandSports  
  dotnet new xunit -o KurtsStore/SportlandSports.Tests  
  dotnet add KurtsStore/SportlandSports.Tests reference KurtsStore/SportlandSports  
```
## Screenshots
### Configure and Build  
![Screenshot 1](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_1B_Configure_and_Build.JPG "Screenshot 1")
### Connect to Database  
![Screenshot 2](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_1B_Connect_to_Database.JPG "Screenshot 2")
### Display the Products
![Screenshot 3](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_1B_Display_the_Products.JPG "Screenshot 3")  
