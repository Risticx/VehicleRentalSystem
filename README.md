# Vehicle Rental CLI Application

## Overview

This project is a command-line interface (CLI) application that simulates a vehicle rental system. Users can rent different types of vehicles (cars, motorcycles, cargo vans) and generate an invoice for the rental period. The project demonstrates the use of Object-Oriented Programming (OOP) and SOLID principles.

## Features

* Rental of various vehicle types: Car, Motorcycle, Cargo Van
* Calculation of rental and insurance costs
* Early return with adjusted cost calculation
* Detailed invoice generation

## Key Concepts

## SOLID Principles

* Single Responsibility: Each class has one responsibility, e.g., Invoice handles invoice generation.
* Open/Closed: New vehicle types can be added without modifying existing code.
* Liskov Substitution: Subtypes can be used wherever their base types are expected.
* Interface Segregation: Interfaces provide clear contracts, e.g., IVehicleService.
* Dependency Inversion: High-level modules depend on abstractions, e.g., RentalService depends on IVehicleService.

## OOP Principles

* Encapsulation: Classes encapsulate data and behavior.
* Abstraction: Abstract classes and interfaces define common behavior.
* Inheritance: Specialized vehicle types inherit from the Vehicle class.
* Polymorphism: Different vehicle types are handled through a common interface (IVehicleService).

## Implementation of Clean Architecture

This project adopts Clean Architecture principles by rigorously implementing interfaces and services to manage business logic. Utilizing interfaces, such as IVehicleService, ensures a decoupled and flexible design, adhering to the principles of dependency inversion. The service classes (CarService, MotorcycleService, CargoVanService, etc.) encapsulate essential functionalities and operations, promoting a robust separation of concerns. This architectural approach enhances maintainability, facilitates comprehensive testing, and supports scalable growth of the application.
