# Pokemon Review API

This project is a Pokémon review API built using ASP.NET and documented with Swagger.

## Features

* Get detailed information about Pokemon, including types, and abilities.
* Search for Pokemon by name.
* Leave reviews for Pokemon.

### Technologies

* ASP.NET
* Swagger (OpenAPI Specification)

### Prerequisites

* [.NET Core SDK (6.0.419)](https://dotnet.microsoft.com/en-us/download)
* A code editor or IDE (e.g., Visual Studio, Visual Studio Code)

### Getting Started

1. Clone this repository.
2. Open the solution file (e.g., PokemonReviewAPI.sln) in your preferred IDE.
3. Restore NuGet packages (usually by right-clicking the solution and selecting "NuGet > Restore NuGet Packages").
4. Run the project (F5). The API will typically run on a default port (e.g. <http://localhost:7184>).

### Using the API

The API is documented using Swagger. You can access the interactive documentation at the following URL (replace `<port>` with the actual port your application is running on):

```bash
http://localhost:<port>/swagger/index.html
```

The Swagger documentation provides details on all available endpoints, including request methods, parameters, and expected responses.

### License

This project is licensed under the [MIT License](https://opensource.org/license/mit).
