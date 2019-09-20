# PeopleSearchProject
A simple Angular app with a reactive form that makes an API calls to the .net backend. The app displays the returned list of people in a card per person format. The api call is an observable that triggers on a change event. The observable is defined with a debouncetime of 400ms to consolidate calls to the back end. 

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
- LocalDb

### Installing
- Pull the project to a local folder.
- Add the project to Visual Studio.
- Run the IIS Express Debuger in Visual Studio.
- From the projects Angular folder, run ng serve

## Running the tests
Unit testing is built into the Angular app and the .net backend. 
Both the frontend and backend, mock data for the api calls. 
To run the Angular unit tests, run ng test from the project's /Angular folder. 
For the backend, in Visual Studio go to Tools->Run->All Tests.
Note, there is a bug in the backend unit test. The mock data isn't getting loaded into the virtual Db Context. This still needs to be investigated.  
