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
## Chapter 7 Screenshots  
### Configure and Build  
![Screenshot 1](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_1B_Configure_and_Build.JPG "Screenshot 1")
### Connect to Database  
![Screenshot 2](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_1B_Connect_to_Database.JPG "Screenshot 2")
### Display the Products
![Screenshot 3](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_1B_Display_the_Products.JPG "Screenshot 3")  
## Chapter 8 Screenshots  
### Filter by Category, Category Selected
![Screenshot 4](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_2A_Filter_by_Category.JPG "Screenshot 4")  
### Add Shopping Cart
![Screenshot 5](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_2A_Add_Shopping_Cart.JPG "Screenshot 5")  
### Shopping Cart with Session Data
![Screenshot 6](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_2A_Shopping_Cart_with_Session_Data.JPG "Screenshot 6")  
### Test Explorer Results
![Screenshot 7](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_2A_Test_Explorer_Results.JPG "Screenshot 7")  
## Chapter 9 Screenshots  
### Remove Items  
![Screenshot 8](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_3A_Add_Remove_Button.JPG "Screenshot 8")  
### Checkout Info  
![Screenshot 9](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_3A_Add_Checkout.JPG "Screenshot 9")  
### Checkout Complete  
![Screenshot 10](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_3A_Checkout_Complete.JPG "Screenshot 10")  
### Test Explorer Results  
![Screenshot 11](https://raw.githubusercontent.com/kurt-woodward/KurtsStore/master/Screenshots/ISTA_421_Lab_3A_Test_Explorer_Results.JPG "Screenshot 11")  
