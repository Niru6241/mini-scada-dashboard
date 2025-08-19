# Mini SCADA Dashboard

![Dashboard Screenshot](images/good_scenario.png)

## Overview
This is a **Mini SCADA/HMI Dashboard** built using **VB.NET Windows Forms** and **PostgreSQL**.  
It simulates real-time sensor readings for a well site, displays them in a live chart, and raises alerts for threshold breaches.  
The project is designed as a **portfolio demonstration** for Industrial Automation/SCADA-related roles.

---

## Features
- Simulates sensor readings for multiple well sites.
- Real-time display of sensor values.
- Multi-threshold alert system for high values.
- Live chart plotting using Windows Forms Chart control.
- Stores sensor readings in **PostgreSQL** database.
- Start/Stop control for simulation.
- Password-free connection via **environment variable** for security.

---

## Tech Stack
- **Frontend/GUI:** VB.NET WinForms  
- **Database:** PostgreSQL  
- **Packages:** Npgsql for PostgreSQL connectivity  
- **Version Control:** Git & GitHub  

---

## Setup Instructions
1. **Clone the repo:**
   ```bash
   git clone https://github.com/Niru6241/mini-scada-dashboard.git
   cd mini-scada-dashboard
Set PostgreSQL password as environment variable

Windows:

Press Win + S → type Environment Variables → Edit the system environment variables

Click Environment Variables…

Under User variables, click New…

Name: PGPASSWORD

Value: your Postgres password

Click OK → OK → OK

Restart Visual Studio

Update connection string in Form1.vb (if needed):

vb.net
Copy
Edit
Dim dbPassword As String = Environment.GetEnvironmentVariable("PGPASSWORD")
Dim connStr As String = $"Host=localhost;Port=5432;Username=postgres;Password={dbPassword};Database=wellsite_db"
Open the solution in Visual Studio

WellSiteDashboard.sln

Build and run

Click Start to simulate sensor readings.

Screenshots
Main Dashboard with Live chart
images/good_scenario.png

High Value Alert/warning values
images/warning_cridical_value.png


