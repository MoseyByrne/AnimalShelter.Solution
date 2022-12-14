# _AnimalShelter.Solution_

#### By Mo Byrne

#### _Brief description of application_

---
## Table of Contents
[Technologies Used](#technologies-used)  
[Description](#description)  
[Setup/Installation Requirements](#setup-and-installation-requirements)
[API Documentation](#api-documentation)
[Known Bugs](#known-bugs)  
[License](#License)

---
## Technologies Used

* _C#_
* _.NET_
* _HTML_
* _CSS_
* _SQL Workbench_
* _Entity Framework_
* _MVC_

---
## Description

_This is a detailed description of your application. Give as much detail as needed to explain what the application does as well as any other information you want users or other developers to have._

---
## Setup and Installation Requirements

<details>
<summary><strong>Initial Setup</strong></summary>  

1. Copy the git repository url: https://github.com/moseybyrne/AnimalShelter.Solution 
2. Open a shell program and navigate to your desktop.
3. Clone the repository for this project using the `git clone` command and including the copied URL.
4. While still in the shell program, navigate to the root directory of the newly created file named `AnimalShelter.Solution`.
5. From the root directory, navigate to the `AnimalShelter` directory.
6. Move onto SQL Workbench instructions below to re-create database necessary to run this project.
</details>

<details>
<summary><strong>SQL Workbench Configuration</strong></summary>

1. Create an `appsetting.json` file in the `AnimalShelter` directory of the project  
   <pre>AnimalShelter.Solution
   └── AnimalShelter
    └── <strong>appsetting.json</strong></pre>
2. Insert the following code [^1]  
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid=root;pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    ```

3. Once `appsettings.json` file has been created, navigate back to SQL Workbench.
</details>

<details>
<summary><strong>To Run</strong></summary>

1. Navigate to:  
   <pre>AnimalShelter.Solution
   └── <strong>AnimalShelter</strong></pre>

2. Run `$ dotnet restore` in the console.  
3. Run `$ dotnet database update` in the console.  
4. Run `$ dotnet run` in the console
</details><br>

## API Documentation

## Using Swagger Documentation

To explore AnimalShelter API with Swagger/Swashbuckle, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `https://localhost:5001/index.html`

## Endpoints

Base URL: https://localhost:5000

## HTTP Request Structure
* GET /api/animals
* POST /api/animals
* GET /api/animals/{id}
* PUT /api/animals/{id}
* DELETE /api/animals/{id}

Example Query
https://localhost:5000/api/animals/1

## Sample JSON Response

{\
    "animalId": 1,\
    "name": "Matilda",\
    "species": "Cat",\
    "age": 7,\
    "gender": "Female",\
}

## Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | true | Return matches by name.
| species | string | none | true | Return matches by species.| age | string | none | true | Return matches by age.

## Example Query
http://localhost:5000/api/animals?species=cat

## Sample JSON Response
[\
{\
    "animalId": 1,\
    "name": "Matilda",\
    "species": "Cat",\
    "age": 7,\
    "gender": "Female",\
}\
{\
    "animalId": 4,\
    "name": "Pip",\
    "species": "Cat",\
    "age": 4,\
    "gender": "Male",\
}\
]


This program was built using *`Microsoft .NET SDK 5.0.401`*, and may not be compatible with other versions. Your milage may vary.

---
## Known Bugs

* Any known bugs

---
## License



[Copyright](/LICENSE) © 2022 Mo Byrne

---
### Footnotes

[^1]: You must include your password in the code block section labeled `[YOUR-PASSWORD-HERE]`.