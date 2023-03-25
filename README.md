# Pierre's Sweet And Savory Treats

#### By: Jannon Sielaff

An application with user authentication and a many-to-many database relationship.

## Technologies Used

* C#
* HTML
* CSS
* Visual Studio
* .Net Framework
* Razor Markup
* SQL

## Setup Instructions

1. Clone this repository.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "PierresTreats.Solution/PierresTreats".
3. Create a file in /PierresTreats called appsettings.json.  In this file, place the following text:

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[your database name];uid=[your user ID];pwd=[Your password];"
  }
}

4. In the command line, run the command "dotnet build" to compile the code. After you have compiled the code and injected all of your dependencies, you can publish the application to the internet by typing dotnet watch run.  This will open a web browser to LocalHost:5000 or Localhost:5001.  From here you can interact with the application. Since this is a web application, you will interact with it in your web browser.


## Known Bugs

* NA

## License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

* Copyright (c) _2023_ _Jannon Sielaff_
