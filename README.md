# GMDemo
This is a sample application to demonstrate a method of managing gambling machines, currently the project just uses a small mock repository loop to get data for populating the grid. 
Please refer to future enhancements for ideas on integrating to a live database, at the base the application uses the following tools:
 - Microsoft MVC pattern
 - Moq for the fake repository in Unit tests
 - Logger interface for custom logging
 - Autofac to do dependecy resolution of mock data and logging
 - Telerik Kendo UI controls for UI elements
 - Jquery for working with UI elements
 - Microsoft Test Runner for unit testing
 
Further enhancements:

 - Add actual database interface so we can chat to Azure
 - setup sample database on Azure
 - create, read, update and delete records using dapper ORM
 - change repo from mock list of machines to actual records on SQL database
 
If by some chance the solution does not start by default please, point to the Gm/Index view
example "http://localhost:8081/Gm/Index"

