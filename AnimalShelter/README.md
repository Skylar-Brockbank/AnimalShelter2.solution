<br>
<p align="center">
  <u><big>|| <b>Animal Shelter API</b> ||</big></u>
</p>
<p align="center">
    <!-- Skylar Avatar/Logo -->
    <br>
    <a href="https://github.com/Skylar-Brockbank">
        <img src="https://avatars.githubusercontent.com/u/91647723?v=4" alt= "skylar brockbank profile" width="100" height="100" style="border-radius:50%">
    </a>
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/Skylar-Brockbank">
            <strong>Skylar Brockbank's GitHub</strong>
        </a>
    </p>
    <p align="center">
        <a href="https://www.linkedin.com/in/skylar-brockbank/">
            <img src="https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=2867B2">
        </a>
    </p> 
    <!-- Project Shields -->    
</p>

<p align="center">
  <small>Initiated January 21th, 2021.</small>
</p>
------------------------------

### <u>Table of Contents</u>
* <a href="#-about-the-project">About the Project</a>
    * <a href="#description">Description</a>
    * <a href="#known-bugs">Known Bugs</a>
    * <a href="#built-with">Built With</a>
* <a href="#getting-started">Getting Started</a>
    * <a href="#prerequisites">Prerequisites</a>
    * <a href="#setup-and-use">Setup and Use</a>
* <a href="#api-documentation">API Documentation</a>
* <a href="#license">License</a>
    
------------------------------
## 📚 About the Project

### Description
An API that returns information about animals in the shelter.

### Known Bugs

* There are no known bugs at this time.

### Built With
* [Visual Studio Code](https://code.visualstudio.com/)
* [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-3.1)
* [MySQL](https://dev.mysql.com/)
* [Entity Framework Core 2.2.6](https://docs.microsoft.com/en-us/ef/core/)
* [Postman](postman.com)

------------------------------

## Getting Started

### Prerequisites

#### Install .NET Core
* On macOS Mojave or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download the .NET Core SDK from Microsoft Corp for macOS.
* On Windows 10 x64 or later
  * [Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp for Windows.

#### Install dotnet script
 Enter the command ``dotnet tool install -g dotnet-script`` in Terminal for macOS or PowerShell for Windows.

#### Install MySQL Workbench
 [Download and install the appropriate version of MySQL Workbench](https://dev.mysql.com/downloads/workbench/).

#### Install Postman
(Optional) [Download and install Postman](https://www.postman.com/downloads/).

#### Code Editor

  To view or edit the code, you will need a code editor or text editor. I recommend VisualStudio Code.

  1) Code Editor Download:[VisualStudio Code](https://www.npmjs.com/)
  2) Click the download most applicable to your OS and system.
  3) Wait for download to complete, then install -- Windows will run the setup exe and macOS will drag and drop into applications.
  4) Optionally, create a [GitHub Account](https://github.com)

### Setup and Use

  #### Cloning

  1) Navigate to the [Animal Shelter API repository here](https://github.com/Skylar-Brockbank/AnimalShelter2.solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/Skylar-Brockbank/AnimalShelter2.solution`
  5) Run the command `cd AnimalShelter.Solution/AnimalShelter` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `code .` to open the project in VisualStudio Code for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### Download

  1) Navigate to the [Animal Shelter API repository here](https://github.com/Skylar-Brockbank/AnimalShelter2.solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Click 'Download ZIP' and unextract.
  4) Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the GameApi.Solution directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=skylar_brockbank;uid=root;pwd=YOUR_PASSWORD_HERE};"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YOUR_PASSWORD_HERE' with relevant MySQL password (set at installation of MySQL).

#### Database
  1) Navigate to GameApi.Solution directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelter.Solution/AnimalShelter`).
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to GameApi.Solution directory using the MacOS Terminal or Windows Powershell (e.g. `cd Desktop/AnimalShelter.Solution/AnimalShelter`).
  2) Run the command `dotnet run` to have access to the API in Postman or browser.  

  ## API Documentation
  Explore the API endpoints in Postman or a browser.

  ### Note on CORS
  CORS is a W3C standard that allows a server to relax the same-origin policy. It is not a security feature, CORS relaxes security. It allows a server to explicitly allow some cross-origin requests while rejecting others. An API is not safer by allowing CORS.
  For more information or to see how CORS functions, see the [Microsoft documentation](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-2.2#how-cors).

  
  ### Endpoints
  Base URL: `https://localhost:5000`
  
  __________________________________________
  __*** Available Components ***__

  * Animal
  __________________________________________
  
   #### HTTP Request Structure
  ```
  GET /api/{component}
  POST /api/{component}
  GET /api/{component}/{id}
  PUT /api/{component}/{id}
  DELETE /api/{component}/{id}
  GET /api/{component}/type/{type}
  ```

  #### Example Query
  ```
  https://localhost:5000/api/Players/13
  ```
  
  #### Sample JSON Response
  ```
  {
    "name": "Doug The Dog",
    "sex": "M",
    "age": 6,
    "type": "cat"
  }
  ```

  ### Api/Animal/id parameters

  | Parameter | Type | Default | Required | Description |
  | :---: | :---: | :---: | :---: | --- |
  | id | int | none | false | Specific target Animal|

  This endpoint returns the animal with the id specified
  #### Example Query
  ```
  https://localhost:5000/api/Animals/4
  ```

  ### Api/Animal/type/{type} parameters

  | Parameter | Type | Default | Required | Description |
  | :---: | :---: | :---: | :---: | --- |
  | type | string | none | true | Specified animal type |

  This endpoint gives a list of animals that match the type specified
  
  #### Example Query
  ```
  https://localhost:5000/api/Animals/type/cat
  ```
------------------------------


### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (C) 2021 Skylar Brockbank. All Rights Reserved.

```
MIT License

Copyright (c) 2021 Skylar Brockbank.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```

------------------------------