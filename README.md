API-based application exercise with Angular 1.x and ASP.NET Web API - 
Solution Implementation by Justin C.

This Repository has both the implementation of the API (API folder) and the user interface (UI Folder). 
The steps below will guide you through setting up and running the applications from start to finish.
1.	Fork or download the code from this repository.
2.	Open the Solution file TestApi.sln in the API folder in Visual Studio
3.	Successfully rebuild the solution. You might have to restore some nugget packages in order to resolve some of the dependencies
4.	Run the project by typing F5 or Debug/Start from the menu in Visual Studio.
5.	At this point, there should be a generic page with ASP.NET written on it. Click on the link on top that says API, it should take you to a Help page with the different endpoints. The ones that we will need are under Person. 
 


6.	Use a client application to make sure you can hit the endpoints, the url as you can see on the browser is: http://localhost:4001/.
In order to get the complete list, use http://localhost:4001/api/Person for instance.

7.	At this point, we can run the UI piece by navigating in the file system to the UI directory and make sure the Angular application is working
8.	Be sure NPM and Bower are installed
1.	Type npm at the command-line. If you don't have it, get it here: NPM
2.	Type bower at the command-line. If you don't have it get it here: Bower
9.	Navigate to the /UI directory.
10.	Run npm build
11.	Run npm install
12.	Run npm start to start the UI
13.	Start the debugger to make sure all the dependencies are added
14.	In case we are missing some, run bower install 
15.	Navigate to http://localhost:8000/
16.	When updating, take a look at the Console in order to see if it was successful or not. 


