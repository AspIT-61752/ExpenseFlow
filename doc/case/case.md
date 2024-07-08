# Project: Personal Finance Tracker

## Project Overview

Create a Personal Finance Tracker application that helps users manage their income, expenses, and savings. The application will allow users to input financial transactions, categorize them, view summary reports, and visualize their financial data.

### Key Features

1.  User Authentication: Users can register and log in to the application.
1.  Transaction Management: Users can add, edit, and delete transactions (income/expense).
1.  Category Management: Users can categorize transactions (e.g., groceries, rent, salary).
1.  Reporting and Visualization: Users can view reports and visualizations of their financial data (e.g., monthly expenses, savings trends).
1.  Settings and Preferences: Users can configure their currency, preferred reporting period, etc.

### Learning Objectives

- .NET MAUI: Develop a cross-platform mobile app using .NET MAUI.
- XAML: Design user interfaces using XAML.
- Databases and UML Diagrams: Design the database schema and create UML diagrams to model the application's structure.
- Entity Framework (EF): Use EF Core to interact with the SQLite database.

### Plan

#### Step 1: Project Setup

- Set up a new .NET MAUI project in Visual Studio.
- Configure the project for Android.

#### Step 2: User Interface Design (XAML)

- Create the login and registration pages using XAML.
- Design the main dashboard, transaction list, and transaction detail pages.
- Create category management and settings pages.

#### Step 3: Database Design

- Design the database schema using UML diagrams.
  - Tables: Users, Transactions, Categories, Settings
  - Relationships: Users have multiple Transactions, Transactions belong to one Category
- Implement the database schema using SQLite and EF Core.

#### Step 3.5: API Design

- Create the API
  - Create
  - Update
  - Put
  - Delete

#### Step 4: User Authentication

- Implement user registration and login functionality.
- Securely store user credentials using hashing and salting.

#### Step 5: Transaction Management

- Implement CRUD operations for transactions.
- Bind data to the UI using data binding in XAML.

#### Step 6: Category Management

- Implement CRUD operations for categories.
- Allow users to assign categories to transactions.

#### Step 7: Reporting and Visualization

- Use charts and graphs to visualize financial data.
- Implement summary reports (e.g., monthly expenses, income vs. expenses).

#### Step 8: Settings and Preferences

- Allow users to configure application settings.
- Implement features like changing the currency, selecting preferred reporting periods, etc.

#### Step 9: Testing and Debugging

- Thoroughly test the application on Android.
- Debug any issues and ensure smooth performance.

#### Step 10:
