# Product Management and CRUD Operations with ASP.NET Core Web API

This project is a simple ASP.NET Core Web API designed to manage a product list and perform basic CRUD (Create, Read, Update, Delete) operations. The API supports interaction through Swagger for testing and demonstration purposes.

## Objectives

- Create a Web API to manage a product list.
- Implement basic CRUD operations for the product list.
- Use Swagger to test and perform API operations.

## Steps to Implement

### Controller Creation

1. Start with an ASP.NET Core WebAPI template.
2. Remove the default `WeatherForecast` class and controller from the project.
3. Create a new API controller named `ProductController`.

### Endpoints

The `ProductController` includes the following endpoints:

1. **Get All Products**
   - **HTTP Method**: GET
   - **Route**: `api/product`
   - **Description**: Returns the product list in JSON format.

2. **Get Product by ID**
   - **HTTP Method**: GET
   - **Route**: `api/product/{id}`
   - **Description**: Returns a specific product in JSON format based on the provided ID.

3. **Create a New Product**
   - **HTTP Method**: POST
   - **Route**: `api/product`
   - **Description**: Adds a new product to the product list.

4. **Update an Existing Product**
   - **HTTP Method**: PUT
   - **Route**: `api/product/{id}`
   - **Description**: Updates the details of an existing product identified by ID.

5. **Delete a Product**
   - **HTTP Method**: DELETE
   - **Route**: `api/product/{id}`
   - **Description**: Deletes a product identified by ID from the product list.

### Product List Storage

A private static list is used within the `ProductController` to store the product data. This serves as an in-memory storage for demonstration purposes.

### Product Model

The `Product` class represents the structure of a product object. It includes the following properties:

- `id` (int): Unique identifier for the product.
- `name` (string): Name of the product.
- `price` (decimal): Price of the product.
- `category` (string): Category to which the product belongs.

## Project Structure

```
ASP.NET Core WebAPI Project
├── Controllers/
│   └── ProductController.cs   # Contains API endpoints
├── Models/
│   └── Product.cs             # Product model class
├── Program.cs                 # Entry point of the application
├── Startup.cs                 # Application configuration
└── README.md                  # Project documentation
```

## How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/username/aspnetcore-webapi.git
   ```
2. Navigate to the project directory:
   ```bash
   cd aspnetcore-webapi
   ```
3. Build and run the project:
   ```bash
   dotnet run
   ```
4. Open your browser and navigate to:
   ```
   http://localhost:<port>/swagger
   ```
   Replace `<port>` with the port number specified in the terminal.

5. Use Swagger to test the API endpoints.
