# Pet Adoptions

> View listings for pet adoptions.

## Getting Started

### Requirements

- .NET Core
- Node
- Yarn
- Editor, Preferably Visual Studio or Visual Studio Code
- [Rescue Groups API Key](https://rescuegroups.org/services/request-an-api-key/)
  - Take a second to [read the TOS](https://rescuegroups.org/api-terms-of-service/) before requesting an API key

### C# VSCode Extension

If you are using VSCode, you should [install the C# extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp).

### Set ENV Variables

Create a file `.env` in the root of the project, using the contents in `.env.example`. Then, replace any variables with your own, such as `RESCUE_GROUPS_API_KEY` with your own key.

### Overview

The source code is broken up into a few different directories:
- `src/Api` exposes an API for retrieving animal listings
- `src/Client` is a Blazor WebAssembly app that calls the Api
- `src/Server` is more of an experiment. It is separate from Api and Client in that it is a Blazor Server app that does the work of both Api and Client.

### Start

There's a few ways you can start the app. Each way requires you to start the Api and Client separately.

1. Basic
    Start the Api in a terminal:
    ```sh
    $ dotnet run -p src/Api
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: https://localhost:4001
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: http://localhost:4000
    info: Microsoft.Hosting.Lifetime[0]
          Application started. Press Ctrl+C to shut down.
    info: Microsoft.Hosting.Lifetime[0]
          Hosting environment: Development
    info: Microsoft.Hosting.Lifetime[0]
          Content root path: /projects/PetAdoptions/src/PetAdoptions.Api
    ```
    Then start the client in another terminal:
    ```sh
    $ dotnet run -p src/Client
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: https://localhost:5001
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: http://localhost:5000
    info: Microsoft.Hosting.Lifetime[0]
          Application started. Press Ctrl+C to shut down.
    info: Microsoft.Hosting.Lifetime[0]
          Hosting environment: Development
    info: Microsoft.Hosting.Lifetime[0]
          Content root path: /projects/PetAdoptions/src/PetAdoptions.Client
    ```
1. Watch Mode, recompiles on files saved (recommended)
    Both the Api and Client can be started in watch mode where the code is recompiled on file save. This is done by using `watch run debug` instead of `run`:
    ```sh
    $ dotnet watch run debug -p src/Api
    watch : Started
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: https://localhost:4001
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: http://localhost:4000
    info: Microsoft.Hosting.Lifetime[0]
          Application started. Press Ctrl+C to shut down.
    info: Microsoft.Hosting.Lifetime[0]
          Hosting environment: Development
    info: Microsoft.Hosting.Lifetime[0]
          Content root path: /projects/PetAdoptions/src/PetAdoptions.Api
    ```
1. VSCode Debugger, allows setting breakpoints in code:
    - Navigate to the Debug panel in VSCode and start the `.NET Core Launch (Api)` task.
    - There is currently not a debugger config for starting the Client, so you'll have to start the client using Basic or Watch.

Once you've started the server, go to `http://localhost:5000` in your browser.
