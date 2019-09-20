# PeopleSearchProject
A simple Angular app with a reactive form that makes an API call to the .net backend. The app displays the returned list of people in a card per person format. The api call is an observable that triggers on a change event and an observable is defined with a debouncetime of 400ms to consolidate calls to the back end. 

The backend api is built with the Entity Framework that seeds the following persons to the database.
- Mike Bell
- Laura Palmer-Bell
- John Doe
- Jane Doe
- Anthony Lomax
- Pete Toto

The API call GetPersons generates a random delay of up to 2 seconds to simiulate network delay.  

### Prerequisites
- Visual Studio
- Angular CLI
- NodeJS
- LocalDb
- Entity Framework

### Installing/Running the App
- In Visual Studio, pull the project from github
- Link a localDb to the project nameing the new db PeopleSearch. The app looks for the db in the defulat DataDirectory which is the app_data directory in the project. If localDB does not store the file there you may need to copy it over. 
- Run the IIS Express Debuger in Visual Studio.
- From the projects Angular folder, run ng serve
- Navigate to http://localhost:4200

## Running the tests
Unit testing is built into the Angular app and the .net backend. 
Both the frontend and backend, mock data for the api calls. 
To run the Angular unit tests, run ng test from the project's /Angular folder. 
For the backend, in Visual Studio go to Tools->Run->All Tests.
Note, there is a bug in the backend unit test. The mock data isn't getting loaded into the virtual Db Context. This still needs to be investigated.  
