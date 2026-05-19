# Pulzz Dashboard

Pulzz Dashboard is a standalone Windows Forms sample based on a first-year project. It packages the dashboard screen from the Pulzz application into a small, runnable desktop project. It is intended for UI review, form editing, and quick local testing without including the rest of the original multi-page system.

## Overview

This repository contains a single WinForms application targeting `.NET 8` on Windows. The form uses `Guna.UI2.WinForms` controls for styling and includes the generated designer files and embedded resources needed to open and run the dashboard as a standalone project.

The current dashboard is a static UI prototype. It focuses on layout and presentation rather than live data loading or backend integration.

## Repository

- GitHub: `https://github.com/msnavodya/dashboard-csharp`
- Default branch: `main`

## What Is Included

- `Dashboard.cs`
  The main form code-behind.
- `Dashboard.Designer.cs`
  The WinForms designer-generated layout and control initialization.
- `Dashboard.resx`
  Embedded resources used by the form, including images and component resources.
- `Program.cs`
  Application entry point that launches the dashboard form.
- `DashboardOnly.csproj`
  Standalone project file that targets `net8.0-windows`.
- `Properties/AssemblyInfo.cs`
  Assembly metadata for the project.

## UI Sections

The dashboard currently includes these main visual areas:

- Clinic information panel
- Approval request and upcoming appointment summary cards
- Today's appointment section with sample treatment entries
- Employee profile details panel
- Leave management inputs
- Attendance summary
- Payroll summary
- Navigation-style shortcuts such as `Go to Profile` and `Go to Shift Management`

Most values shown in the form are sample or placeholder values stored directly in the designer.

## Technology Stack

- C#
- Windows Forms
- `.NET 8.0` (`net8.0-windows`)
- `Guna.UI2.WinForms` `2.0.4.4`

## Prerequisites

Before running the project, make sure you have the following:

- Windows
- .NET 8 SDK
- Visual Studio 2022 or later with Windows desktop development workload, or the `dotnet` CLI
- Access to restore the `Guna.UI2.WinForms` NuGet package if it is not already cached locally

## Getting Started

### Open in Visual Studio

1. Open `DashboardOnly.csproj`.
2. Allow NuGet packages to restore if prompted.
3. Build and run the project.

### Run from the Command Line

```powershell
dotnet restore
dotnet build
dotnet run --project DashboardOnly.csproj
```

If package restore is blocked on a restricted network, Visual Studio or `dotnet` may show a NuGet source warning until internet access to `https://api.nuget.org/v3/index.json` is available again.

## Project Structure

```text
Dashboard/
|-- Dashboard.cs
|-- Dashboard.Designer.cs
|-- Dashboard.resx
|-- DashboardOnly.csproj
|-- Program.cs
|-- Properties/
|   `-- AssemblyInfo.cs
`-- README.md
```

## Notes for Development

- The repository contains only the dashboard screen, not the full Pulzz application.
- The form currently has minimal code-behind logic and several empty event handlers.
- Most customizations should be made through the WinForms designer or by editing `Dashboard.Designer.cs` carefully.
- Because the UI relies on generated designer code, manual edits should be tested in Visual Studio after changes.

## Customization Ideas

You can extend this standalone dashboard by:

- Replacing placeholder labels with live data
- Wiring buttons and panels to real navigation or modal flows
- Connecting leave management fields to validation and persistence
- Loading clinic, employee, payroll, or appointment data from a database or API
- Breaking the large form into reusable user controls

## Current Limitations

- The project is a UI-focused sample and does not include backend services or persistent storage.
- Most values displayed in the dashboard are static placeholders defined in the form resources and designer.
- Some event handlers are intentionally minimal and should be expanded before using the project in production.

## Troubleshooting

- If the project fails to build because `Guna.UI2.WinForms` is missing, run `dotnet restore` or restore packages through Visual Studio.
- If the form opens with missing assets, confirm that `Dashboard.resx` is included and has not been renamed or moved.
- If the designer becomes unstable after manual edits, reopen the project in Visual Studio and verify the generated code structure in `Dashboard.Designer.cs`.

## Repository Status

This is currently a clean standalone extraction of the dashboard UI intended for further development, documentation, and integration work.
