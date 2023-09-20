In the Hexagonal Architecture, also known as the Ports and Adapters Architecture, the business logic is typically placed 
in the "inner" part of the architecture, known as the "Core" or "Domain" layer.
The Hexagonal Architecture promotes a clean separation between the core business logic and the external dependencies 
and interfaces. Here's how it's structured:

1. Core (Domain) Layer:
   - Purpose: The core layer is where you place your business logic, domain entities, value objects, and the rules that define how your application behaves within its specific problem domain. This layer is isolated from external dependencies.
   - Responsibilities:
     - Defining domain entities and value objects.
     - Implementing business rules and logic.
     - Enforcing domain-specific constraints.
     - Handling use cases and application-specific operations. Application Services, often referred to as Use Cases, orchestrate and coordinate interactions between domain objects. They encapsulate the specific operations or workflows that your application supports. 

2. Ports and Adapters:
   - Purpose: The outer layers, often referred to as "Ports and Adapters," are responsible for interacting with external systems, frameworks, and services. These layers adapt the core domain logic to various input and output channels without contaminating the core with external concerns.
   - Responsibilities:
     - Adapters for different input and output channels (e.g., web controllers, database repositories, external APIs).
     - Implementing interfaces (or ports) that the core layer defines. These interfaces represent the interactions the core layer requires from external components.
     - Routing external requests to the appropriate core domain logic.
     - Managing dependencies and integrating with external systems.

In the Hexagonal Architecture, the business logic in the core layer remains agnostic of the specific delivery mechanisms, such as web interfaces, databases, or messaging systems. This separation makes the core logic highly testable and allows you to change or add adapters without affecting the core logic itself. It promotes flexibility and maintainability by isolating the domain from the details of the infrastructure.

References:
- https://youtu.be/92ZJcxJgmmE?si=cIVR49UazqvdWpyE (How To Make Your App Maintainable (hint: Adopt Hexagonal Architecture))