# RESTful Student

A **.NET**-based REST API designed to manage student information in his department. This API allows for the creation, retrieval, update, and deletion (CRUD) of student records. We use simple **SQLite** database due to the simplicity of useage.

## Topics 
- REST API
- Data Transfer Objects (**DTOs**)
- Extension Method
- Group Builder
- Validation using Data Annotation
- [NuGet](https://nuget.org)
- Entity Framework
- Dependency Injection
- Asynchronous Endpoints


## Usage

1. First ensure you've those prerequisites:
   - [.NET SDK](https://dotnet.microsoft.com/en-us/download)
   - Install those extensions to your VS Code:
     - [C# Dev Kit](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
     - [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client)
     - [SQLite](https://marketplace.visualstudio.com/items?itemName=alexcvzz.vscode-sqlite)

2. Clone the repo:
   ```bash
   git clone git@github.com:mohamedhassan218/RESTful-Student.git
   ```

3. Change the directory:
    ```bash
    cd RESTful-Student\Students\
    ```

4. Install the dependencies:
   ```bash
   dotnet restore
   ```
   
5. You don't need to migrate the database due to we put the code that does this in the startup, so just run:
    ```bash
    dotnet run
    ```

6. And now, you can test the API by running each request in the `test.http` file.


## Acknowledgement

This project was developed following the comprehensive tutorial [“Building a RESTful API in .NET”](https://youtu.be/AhAxLiGC7Pc?si=aUeo7nPsE-94gsRR) by *Julio Casal*. 

The tutorial provided invaluable insights into creating robust and scalable RESTful APIs using the .NET framework. A heartfelt thank you to the author for sharing their expertise and making this learning experience possible.

### Additional Resources

If you're interested in learning more about building RESTful APIs with .NET, here are some additional resources:

- [Official .NET Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [Advanced ASP.NET Core Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-5.0)