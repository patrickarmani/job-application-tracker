# job-application-tracker

### Brief description of our project

A web app for keeping track of the jobs you've applied to: where you applied,
for what position, when, and where each application stands
(Applied → Interview → Offer / Rejected / Withdrawn).

Built for CSE499 Senior Project.

## Features

- **Dashboard**: total number of applications, a count per status, and a table of recent applications
- **Applications list**: every application shown as a card with a color-coded status badge
- **Add / edit**: one shared form for company, position, location, work model
  (on-site / hybrid / remote), date applied, status, job posting URL, and notes
- **Details page**: all the information for a single application
- **Delete**: with a confirmation page before anything is removed

## Project status

| Feature                                            | Status                      |
| -------------------------------------------------- | --------------------------- |
| Data model + database (SQLite, EF Core migrations) | ✅ Done                     |
| Create, view, edit, delete applications            | ✅ Done                     |
| Dashboard with status counts                       | ✅ Done                     |
| Responsive layout (Bootstrap)                      | ✅ Done                     |
| Search by company/position + filter by status      | 🚧 UI done, backend pending |
| TODO: next planned features                        | ⬜ Not started              |

## CRUD workflow

The application provides a complete CRUD workflow for job applications:

1. **Create** — add a new job application with company, position, location, work model, application date, status, job URL, and notes.
2. **Read** — view saved applications in the applications list and open the Details page for a specific application.
3. **Update** — edit an existing application, including its current application status.
4. **Delete** — remove an application through a confirmation page to prevent accidental deletion.

The workflow uses ASP.NET Core MVC, Entity Framework Core, and SQLite for data persistence.

## Key pull requests

| PR                                                                      | Description                                                      | Author  |
| ----------------------------------------------------------------------- | ---------------------------------------------------------------- | ------- |
| [#15](https://github.com/patrickarmani/job-application-tracker/pull/15) | Backend for listing job applications                             | Patrick |
| [#19](https://github.com/patrickarmani/job-application-tracker/pull/19) | First frontend pass: layout, dashboard, and application cards    | Ovinson |
| [#20](https://github.com/patrickarmani/job-application-tracker/pull/20) | Backend for creating job applications                            | Patrick |
| [#29](https://github.com/patrickarmani/job-application-tracker/pull/29) | Editing job applications                                         | Patrick |
| [#33](https://github.com/patrickarmani/job-application-tracker/pull/33) | Success and error feedback messages for create, edit, and delete | Patrick |
| [#34](https://github.com/patrickarmani/job-application-tracker/pull/34) | Shared status badge partial for consistent status display        | Ovinson |

## Tech stack

- ASP.NET Core MVC (.NET 10)
- Entity Framework Core with SQLite
- Razor views + Bootstrap 5.3

## Running it locally

1. Install the [.NET 10 SDK](https://dotnet.microsoft.com/download).
2. Install the EF Core tools (one time): `dotnet tool install --global dotnet-ef`
3. Create the local database:
   ```
   cd JobApplicationTracker
   dotnet ef database update
   ```
4. Run the app: `dotnet watch` (or `dotnet run`)

The database is a local file (`jobapplications.db`) and is not committed to git,
so each person has their own data.

## Design

Wireframes are in [`docs/JobTracker-Wireframes.pdf`](docs/JobTracker-Wireframes.pdf).

### Visual identity

The application uses a consistent, responsive visual style based on Bootstrap 5.3.

- **Primary color:** blue, used for primary actions and important interface elements.
- **Secondary color:** dark tones, used for navigation, headings, and supporting elements.
- **Status badges:** each application status has a distinct visual treatment for Applied, Interview, Offer, Rejected, and Withdrawn.
- **Forms and buttons:** consistent styling is used across Create, Edit, Details, and Delete views.
- **Application cards:** applications use a consistent card layout for readability and quick status identification.
- **Responsive design:** the interface is designed to work on both desktop and mobile screen sizes.

## Teammates

- [Patrick Armani](https://github.com/patrickarmani)
- [Ovinson Lugo](https://github.com/Obito2912)

### Quotes

- Patrick Armani: _Think celestial — even in the small things._ -
  **_President Russell M. Nelson_**

- Ovinson Lugo: _This is very important: As we do our best, He will not let us fail._ -
  **_Elder Neil L. Anderson_**
