# MyTaskApp
Create and manage a ToDo list

--Newest updates (listed new to old)--
* (2022-04-27) Made Minor UI changes to selected tasks and dashboard
* (2022-04-27) Add task is now apart of dashboard instead of seperate window
* (2022-04-27) Reworked code structure to seperate Business app layer from UI layer as much as possible
* (2022-04-22) Update to a Modern UI
* (2022-04-20) Added MySql Parameters for queries
* (2022-04-20) Added Remember me button that stores user and password (needs work to bypass login screen on load)
* (2022-04-20) Updated localhost credentials to contain guest user for extra security

--Point of the project--

This project was my first project after learning C# for the 2022 Spring summester. 
The idea was to combine my two classes of Database Design and Business Application Programming to make a program that has to work with database read, write, update, etc.

--How it works--

The task project allows the user to connect to the database either with an exisiting account or by creating a new account. 
When either or is done, The system stores the user and password (be advised passwords are not hashed. If testing, do not use a real password) under a unique primary key stored as a number. The primary key is also used as a foriegn key for the tasks to load only the tasks to the assigned user as well as only generate tasks to them. Throughout the project, there is an add task, mark selected tasks as completed, and clear all. Each one uses different MySql queries to manage these tasks. Mark as completed sets the task bool to true while clear all simply whipes task from the database. 

--Images of the program--

![image](https://user-images.githubusercontent.com/76855046/164760398-dff8a441-18e0-4336-a257-6e0526449c28.png)
![image](https://user-images.githubusercontent.com/76855046/165661935-3c7149d7-19dc-4927-b023-e0eb0e56fb08.png)
![image](https://user-images.githubusercontent.com/76855046/165662009-24ec6a34-7392-4708-a211-9fcc3617a012.png)

--Future Additions--

Some things I would like to work on/learn in the future are as follows:

* Create "Boards" that show tasks in specific categories
* Adding date picker to manipulate viewed tasks by the date they are due
* Learn good practices for hashing passwords and implement it into account creation/login
* Create a better UI than what is current
* Learn stored procedures to help avoid sql injection

--If wanting to test/edit app yourself--

Due to security, The database is purely local for now. If setting up yourself, Please create a new database in MySql and 
add the new connection string creditials in the AppConfig File. Database Schema is simple but is as follows:

appusers -> userid(PK), username, password

tasks -> taskid(PK), user_id(Fk), task, completed

