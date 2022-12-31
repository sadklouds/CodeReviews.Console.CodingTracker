# CodeReviews.Console.CodingTracker
Console program of tracking coding sessions times to an SQLite Database using CRUD Operations

# Given Requirements:
- [x] Application register cosing sessions
- [x] Coding session can be tracked by inputting the start and end times manually.
- [x] The user shouldn't input the duration of the session. It should be calculated based on the Start and End times, in a separate "CalculateDuration" method.
- [x] The application should store and retrieve data from a real database
- [x] When the application starts, it should create an SQLite database, if one isn’t present.
- [x] It should also create a table in the database, where the habit will be logged.
- [x] The app should show the user a menu of options.
- [x] The users should be able to insert, delete, update and view their logged habits.
- [x] Handle all possible errors so that the application never crashes.
- [x] can only interact with the database using raw SQL. You can’t use mappers such as Entity Framework.
- [x] show the data on the console, you should use the "ConsoleTableExt" library.
- [x] Required to have separate classes in different files (ex. UserInput.cs, Validation.cs, CodingController.cs)
- [x] Should tell the user the specific format you want the date and time to be logged and not allow any other format.
- [x] Create a configuration file that you'll contain your database path and connection strings.
- [x] When reading from the database, you can't use an anonymous object, you have to read your table into a List of Coding Sessions.


# Features

SQLite database connection
 - The program uses an SQLite database connection to store and read information.
 - If no database exists, or the correct table does not exist they will be created on program start.

A console-based UI where users can navigate by int input from the keyboard


CRUD DB functions
  - From the main menu users can Create, Read, Update or Delete entries for coding sessions, with a start date and endtime  in DD-MM-YYYY HH:mm format (24h clock).
  - Dates inputted are checked to make sure they are in the correct and realistic format.
  - Before updating or deleting records, IDs are validated to ensure they exist and that no strings have been entered. 
  -All functions work. Errors handled and input validation implemented to maintain integrity of database.
  
 Stop Watch
    - Instead of manually inputting the date users can track in real time.
    - when users are finished they just end the session with a console input
    - the duration is then calculated ain automatically inserted into the data base 

# Challenges 

- Date and time were a hurdle for me to store correctly when trying the calculate the duration with the timespan function. Formatting was the main issue, which-
was solved by specifying a sepcific format when converting to string, during database insertion.

-I had never configured an app-config file before and some some issues with configuration mangaer. This was resolved by installing a nugget package for system to reinclude,
this feature to .NET 6.
 
# Comments

  By learning the single responsibilty principle, I was able to split my classes into objects with single resposiblities, this allowed for much easier bug fixing and
  refactoring during development.
    
# Resources Used

  - The help and advice of my mentor Cappuccinocodes
  
  - IamTimCorey youtube SQL video series 
  
  - MS docs for setting up SQLite with C#
  
  - MS docs for DateTime
  
  - MS docs for control strings/ app config
  
  - MS docs for TimeSpan
  
  - Various StackOverflow articles
      
