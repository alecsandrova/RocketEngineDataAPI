# RocketEngineDataAPI

This repository contains a REST API built with C# and ASP.NET Core that connects to a MongoDB database hosted in the cloud using Atlas. The database contains data from "Damage Propagation Modeling for Aircraft Engine Run-to-Failure Simulation" by Saxena, K. Goebel, D. Simon, and N. Eklund.

The API is called the "Rocket Engine Data API" and is part of a university project involving Dataspaces. 
## Controllers 
The API has two controllers:

### RocketController.cs: 
This controller handles the CRUD (Create, Read, Update, and Delete) operations for rocket data. It has the following endpoints:

* **POST /get_data**: Creates a new rocket record in the database.
* **GET /get_data**: Returns all rocket records in the database. Accepts two query parameters: **data_type** (required, must be set to "rockets") and **snippet** (optional, set to true to return only the first few characters of each record).
* **GET /get_data/{id}**: Returns a specific rocket record by ID.
* **PUT /get_data/{id}**: Updates a specific rocket record by ID.
* **DELETE /get_data/{id}**: Deletes a specific rocket record by ID.
### MetaController.cs: 
This controller handles metadata related to the API. It has the following endpoint:

* **GET /get_meta**: Returns metadata about the rocket data stored in the database, including a list of all fields in each record.

## Technologies Used
* C#
* ASP.NET Core
* MongoDB
* Atlas
