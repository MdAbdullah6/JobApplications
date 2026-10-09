# JobApplications
# JobTracker

A web application to track job applications and their status, built with ASP.NET Core MVC.

## Features

- Add, edit, and delete job applications (full CRUD)
- Track company, job title, location, applied date, and notes
- Color-coded status badges: Applied, Interview, Offer, Rejected
- Data stored in a SQLite database using Entity Framework Core migrations
- Server-side validation for required fields
- Responsive layout with Bootstrap

## Tech Stack

| Area | Technology |
|------|------------|
| Language | C# |
| Framework | ASP.NET Core MVC |
| Database | SQLite |
| ORM | Entity Framework Core |
| UI | Razor Views, Bootstrap |
| Version control | Git and GitHub |

## Screenshots

<img width="1912" height="487" alt="image" src="https://github.com/user-attachments/assets/386d1417-e386-4f76-bd5c-218ed393b626" />


## Project Structure

```
JobApplications
 ├── Controllers   -> JobApplicationsController (handles requests)
 ├── Models        -> JobApplication (data shape)
 ├── Data          -> AppDbContext (database connection)
 ├── Migrations    -> database schema history
 └── Views         -> Razor pages (Index, Create, Edit, Delete)

## What I Learned

- The MVC pattern (Models, Views, Controllers)
- Database migrations with Entity Framework Core
- Form handling, POST requests, and validation in ASP.NET Core
- Debugging real errors step by step

## Planned Improvements

- Dashboard with application statistics
- Search and filter by company or status
- User login so each person sees only their own applications

## Author
MD. Abdullah Al Mamun
**Md Abdullah**
GitHub: [MdAbdullah6](https://github.com/MdAbdullah6)
LinkedIn: [Add your LinkedIn profile link here]
