# About
This is a sample application for purchasing product and printing report of the purhcased product with all CRUD operation

## How to Run This App
First Download this app. Open server side project solution with visual studio.
Change the sql server connection string in appsetting.json file with your own sql server name.
As this application is developed with code first approch so you need to run following command in package manager console
1) Add-Migration
2) Update-Database

Thats enough. There are some seed data for necessary table so you don't need to provide any data. Just start using.
now open the client project with visual studio code
run the command below
1) npm i
2) ng s -o

then you will able to Ordered List, To create new record click add new order and fill up the form and save.
To print report click the action button in Ordered List and clik the menu item Export then the report will be printed

## Version
For backend you need .net core 3.1 sdk and
for frontend you need CLI version 11+

## Features
1. Place Order
2. Ordered list
3. Perform Update and Delete
4. Print Specific Order Report

## Technologies
1. .net core
2. EntityFrameWork
3. Sql Server
4. Angular
5. Angular Material

## Screenshots
![Test Image 1](https://github.com/Piasuddin/ITIL_LAB_TEST/blob/main/Screenshot%20(48).png)
![Test Image 1](https://github.com/Piasuddin/ITIL_LAB_TEST/blob/main/Screenshot%20(47).png)
![Test Image 1](https://github.com/Piasuddin/ITIL_LAB_TEST/blob/main/Screenshot%20(50).png)
![Test Image 1](https://github.com/Piasuddin/ITIL_LAB_TEST/blob/main/Screenshot%20(51).png)

