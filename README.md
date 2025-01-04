# Hexagonal Architecture Example

This repository contains an example implementation of a solution using **Hexagonal Architecture**. This example is intended to demonstrate the core concepts of Hexagonal Architecture, focusing on how different layers communicate with each other while keeping the **Domain** at the center.

## Overview

The goal of this project is to showcase how different layers interact in a Hexagonal Architecture-based solution. In this architecture, the core logic of the application resides in the **Domain** layer, which is completely isolated from the external infrastructure and frameworks. The application interacts with external systems via **Ports** and **Adapters**, which decouple the core logic from external dependencies.

### The key layers are:

1. **Domain**: Contains the business logic and entities. This layer should be free of dependencies and frameworks.
2. **Application**: Defines the **Use Cases** (the application-specific business processes) and **Ports** (interfaces for interacting with external systems).
3. **Infrastructure**: Provides the implementations of the **Driven Ports** (outgoing ports), such as repositories, database access, or external services.
4. **Presentation**: Contains the **Drivers** (incoming ports), such as web controllers, APIs, or command-line interfaces that trigger use cases.

## Architecture Flow

- **Domain**: The center of the application, where business logic is implemented. The Domain does not know anything about frameworks or infrastructure.
- **Application**: Orchestrates the flow of the use cases and coordinates between the **Domain** and external systems. It defines interfaces (Ports) for interacting with the infrastructure and presentation layers.
- **Infrastructure**: Implements the outgoing ports (Driven Adapters) defined in the **Application**. It could include a database repository, external API calls, etc.
- **Presentation**: Acts as the entry point for external clients. It receives requests and calls the corresponding use case via the incoming ports (Drivers).

## Limitations

Please note that this implementation is **not a production-ready example** of good code practices. It's a **conceptual demonstration** of Hexagonal Architecture and is missing important elements like:

- **Tests**: No unit tests or integration tests are included.
- **Mapping**: Systems like **AutoMapper** are not used for DTO-to-Entity mapping.
- **Validations**: There is no use of validation libraries like **FluentValidation**.
- **Entity Framework**: The implementation does not use a full-fledged database solution like **Entity Framework** for persistence.

This example is **not intended to be a reference for clean code** or best practices in real-world projects. It's only meant to serve as a basic structure to demonstrate how Hexagonal Architecture works in a .NET context.

## Conclusion

This example illustrates the **core principles** of Hexagonal Architecture, where the business logic is decoupled from external concerns. It provides a clear separation of responsibilities and makes it easier to swap out external systems (e.g., databases, APIs) without affecting the core business logic.

Remember, this is just a **proof of concept**, and you should adapt the architecture to your own needs and include all the necessary features for a real-world application, such as validation, mapping, persistence, and testing.

---

Feel free to contribute, improve, or extend this project as needed.