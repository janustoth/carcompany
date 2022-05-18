# Assignment

The purpose of the assignment is to build an API that allows different car parking garages to manage the parking spaces.

You are building an API for a car garage company that has multiple garages in different locations. They would like to know what cars are currently in what parking lots. They have positioned scanners at all entrances and exits of all parking lots so that it is possible for the system to automatically registers cars entering and exiting the parking lots.

You need to create an SQL database to store the data for cars and parking lots and an API to service requests coming from the frontend and sensors.

The api should be able to do the following:

1. Get a list of parking lots (already implemented for reference)
2. Add a new parking lot
3. Remove a parking lot
4. Register a car (license plate) entering a parking lot
5. Register a car (lincense palte) exiting a parking lot
6. Get a list of all cars in a parking lot at a given time (can be now or in the past). Consider here that a lot of data could be returned and we want to display it on the frontend. 
7. Get a count of all cars in a parking lot at a given time (can be now or in the past)
8. Find a parking lot with available spaces right now

Note that in order to achieve pkt 5 and 6 above the API must store historical data for a parking lot so that it is possible to go back in time.

To the extend that time allows try to:

- use automated testing to verify that the api works (unit testing and integration testing are good options)
- consider scalability and design for many parking lots, lots of cars and many calls coming in a the same time
- follow good design principals like separation of concerns and design patterns to the extend that it makes sense

## The solution

This project has been set up with a simple skeleton that starts an .NET Core api. The skeleton is partially based on this tutorial: <https://docs.microsoft.com/en-us/aspnet/core/tutorials/min-web-api?view=aspnetcore-6.0&tabs=visual-studio-code>

It has been set up using Visual Studio Code and it is suggested to use that. Visual Studio Code is available for free from Microsoft and works cross platform. Do take care to read the link above and make sure you have the solution running on your machine.

The file "Program.cs" contains the main program that setup up the api. Feel free to refactor this file as you see fit.

When the solution is running the api can be browsed and tested using swagger from this page <https://localhost:7163/swagger/index.html>.

To run the solution use the run menu in visual studio code.

The solution uses an in memory database that you are intended to extend with further tables and relations using Entity Framework. The database context can be found in CarCompanyDbContext.cs and the configuration of the in memory database is in line 5 of Program.cs.
