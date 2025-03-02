# Fullstack CV Builder API

## Overview

This repository contains the third assignment for the Web Development course in the .NET Cloud Developer program at IT-Högskolan. 
It includes the API for the Fullstack CV Builder project, providing backend functionality for creating, updating, and managing CV data.
The API is built using .NET 8 and Entity Framework Core. It is designed to communicate with the frontend to perform CRUD operations.

## Features

- **CRUD Operations**: Create, Read, Update, and Delete operations for managing CV data
- **Skills and Projects Management**: Manage skills and project details

  
## Technologies Used

- **.NET 8**
- **C#**
- **Entity Framework Core** for database interaction
- **SQL Server** / **Azure SQL Database** for database management

## API Endpoints

### Skills Management

| HTTP Method | Endpoint            | Description                         |
|-------------|---------------------|-------------------------------------|
| GET         | `/api/Skills`        | Get a list of all skills           |
| GET         | `/api/Skills/{id}`   | Get a specific skill by ID         |
| POST        | `/api/Skills`        | Create a new skill                 |
| PUT         | `/api/Skills/{id}`   | Update an existing skill by ID     |
| DELETE      | `/api/Skills/{id}`   | Delete a skill by ID               |

### Projects Management

| HTTP Method | Endpoint            | Description                         |
|-------------|---------------------|-------------------------------------|
| GET         | `/api/Projects`      | Get a list of all projects         |
| GET         | `/api/Projects/{id}` | Get a specific project by ID       |
| POST        | `/api/Projects`      | Create a new project               |
| PUT         | `/api/Projects/{id}` | Update an existing project by ID   |
| DELETE      | `/api/Projects/{id}` | Delete a project by ID             |


Link to the Frontend: [Fullstack CV Builder Frontend Repository](https://github.com/Sah2Sah2/Lab3-WebDev_FullstackCVBuilderFE)



