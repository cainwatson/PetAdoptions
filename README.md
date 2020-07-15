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

### Start

There's a few ways you can start the app.

1. Basic
    ```sh
    $ dotnet run
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: https://localhost:5001
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: http://localhost:5000
    info: Microsoft.Hosting.Lifetime[0]
          Application started. Press Ctrl+C to shut down.
    info: Microsoft.Hosting.Lifetime[0]
          Hosting environment: Development
    info: Microsoft.Hosting.Lifetime[0]
          Content root path: /projects/PetAdoptionsServer
    ```
1. Watch Mode, recompiles on files saved (recommended)
    ```sh
    $ dotnet watch run debug
    watch : Started
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: https://localhost:5001
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: http://localhost:5000
    info: Microsoft.Hosting.Lifetime[0]
          Application started. Press Ctrl+C to shut down.
    info: Microsoft.Hosting.Lifetime[0]
          Hosting environment: Development
    info: Microsoft.Hosting.Lifetime[0]
          Content root path: /projects/PetAdoptionsServer
    ```
1. VSCode Debugger, allows setting breakpoints in code:
    - Navigate to the Debug panel in VSCode and start the `.NET Core Launch (web)` task.

Once you've started the server, go to `https://localhost:5001` in your browser. You may be prompted that the website is not secure, you can safely ignore it and continue.
