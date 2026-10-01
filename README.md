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
| Responsive layout (Bootstrap)                      | 🚧 In progress              |
| Search by company/position + filter by status      | 🚧 UI done, backend pending |
| TODO: next planned features                        | ⬜ Not started              |

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

## Teammates

- [Patrick Armani](https://github.com/patrickarmani)
- [Ovinson Lugo](https://github.com/Obito2912)

### Quotes

- Patrick Armani: _Think celestial — even in the small things._ -
  **_President Russell M. Nelson_**

- Ovinson Lugo: _This is very important: As we do our best, He will not let us fail._ -
  **_Elder Neil L. Anderson_**
