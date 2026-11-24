# CSC-360-FinalProject

## DogAdoption Application

This project is a simple C# application demonstrating the use of the Factory Design Pattern. The main focus is on how to encapsulate object creation logic, making the codebase more modular and easier to extend.

### Features

- Demonstrates the Factory Design Pattern in a practical scenario.
- Simulates process where different types of dogs can be created using the Factory Pattern.

### How It Works

The application uses a factory class to create instances of different dog breeds based on user input or program logic. This approach decouples the client code from the specific classes of dogs, adhering to the Factory Pattern principles.

### How to Run

1. Clone the repository.
2. Open the solution in Visual Studio 2022.
3. Build and run the project.

### Project Structure

- `DogAdoption/` - Contains the main application code, including the factory and dog classes.
- `README.md` - Project documentation.

### Factory Pattern Overview

The Factory Pattern is used to create objects without specifying the exact class of object that will be created. In this project, it allows for easy addition of new dog breeds without modifying the client code.

### Strategy Pattern: Dog Display

The application also uses the Strategy pattern to choose how dog information is displayed. When prompted, enter `1` for the brief display (name only) or `2` for the detailed display (name and description). An invalid choice prompts you to try again.

- `IDogDisplayStrategy` is the strategy interface.
- `BriefDogDisplayStrategy` and `DetailedDogDisplayStrategy` are the concrete strategies.
- `DogDisplay` is the context: it holds the chosen strategy and delegates displaying each dog to it.
- `Program` selects the strategy based on the user's choice and supplies it to the context.

The existing factories still create the dogs; the strategy controls only how they are displayed. Additional display formats can be added by implementing `IDogDisplayStrategy` and making the new option available in `Program`.
