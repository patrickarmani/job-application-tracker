# job-application-tracker

### Brief description of our project

A web application for managing and tracking job applications.

## Sprint 1 Features

During Sprint 1, the team established the initial structure of the Job Application Tracker and implemented the core functionality required to begin managing job applications.

The Sprint 1 work includes:

- ASP.NET Core MVC project structure
- Job application data model
- Application status and work model enums
- Entity Framework Core integration
- SQLite database configuration
- Initial database migration
- Retrieval of job applications from the database
- Job application listing functionality
- Job application creation functionality (pending review and merge)
- Responsive user interface using Bootstrap 5
- Git branch and pull request workflow

## Technologies Used

The Job Application Tracker is built with the following technologies:

- C#
- .NET 10
- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- Bootstrap 5
- HTML
- CSS
- Git
- GitHub

## How to Run the Application

### Prerequisites

Make sure the following tools are installed:

- .NET 10 SDK
- Git

### Run locally

1. Clone the repository:

   ```bash
   git clone https://github.com/patrickarmani/job-application-tracker.git
   ```

2. Navigate to the project directory:

   ```bash
   cd job-application-tracker/JobApplicationTracker
   ```

3. Restore the project dependencies:

   ```bash
   dotnet restore
   ```

4. Build the project:

   ```bash
   dotnet build
   ```

5. Run the application:

   ```bash
   dotnet run
   ```

6. Open the local URL displayed in the terminal in your web browser.

## Database Setup

The application uses SQLite with Entity Framework Core for data persistence.

The database connection is configured in `appsettings.json` using the following connection string:

```text
Data Source=jobapplications.db
```

The project includes an initial Entity Framework Core migration named `InitialCreate`.

To create or update the local database, navigate to the `JobApplicationTracker` project directory and run:

```bash
dotnet ef database update
```

This command applies the existing migrations and creates the SQLite database if it does not already exist.

## Git Branch Workflow

The project uses a branch-based Git workflow to keep development organized and protect the main codebase.

- `main` contains the stable version of the project.
- `develop` is the integration branch for ongoing development.
- Feature and documentation branches are created from `develop`.
- Each task is developed in its own branch.
- Changes are submitted through a pull request to `develop`.
- Pull requests must be reviewed before they are merged.
- After approval, the branch can be merged into `develop`.

Example workflow:

```bash
git switch develop
git pull
git switch -c feature/example-feature
```

After completing the work, changes are committed, pushed to GitHub, and submitted for review through a pull request.

## Teammates

- [Patrick Armani](https://github.com/patrickarmani)
- [Ovinson Lugo](https://github.com/Obito2912)

### Quotes

- Patrick Armani: _Think celestial — even in the small things._ -  
  **_President Russell M. Nelson_**

- Ovinson Lugo: _This is very important: As we do our best, He will not let us fail._ -  
  **_Elder Neil L. Anderson_**
