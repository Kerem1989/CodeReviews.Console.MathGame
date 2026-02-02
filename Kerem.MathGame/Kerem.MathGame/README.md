# Math Game

A console-based math game built with C# and .NET 9.0. Test your arithmetic skills with addition, subtraction, multiplication, and division problems.

## Features

- **Four Math Operations**: Addition, Subtraction, Multiplication, and Division
- **Two Difficulty Levels**: Normal and Hard mode for each operation
- **Score Tracking**: Earn points for correct answers
- **Game History**: View past game results including player name, score, and completion time
- **Timer**: Track how long it takes to complete each game session

## How to Play

1. Run the application
2. Enter your name when prompted
3. Select from the main menu:
   - **Start New Game**: Play 5 rounds of math problems
   - **View Game History**: See your previous game results
   - **Game Rules**: Learn how to play
   - **Exit**: Quit the game

### During a Game

Each game consists of 5 rounds. For each round:
1. Choose a math operation (Addition, Subtraction, Multiplication, or Division)
2. Select a difficulty level (Normal or Hard)
3. Solve the math problem presented
4. Your score increases by 1 for each correct answer

### Difficulty Levels

| Operation | Normal | Hard |
|-----------|--------|------|
| Addition | 2 numbers (0-99) | 3 numbers (0-99) |
| Subtraction | 2 numbers (0-99) | 3 numbers (0-99) |
| Multiplication | 2 numbers (0-9) | 3 numbers (0-9) |
| Division | 2 numbers (whole number results) | 3 numbers (whole number results) |

## Requirements

- .NET 9.0 SDK

## Running the Application

```bash
dotnet run
```

Or build and run:

```bash
dotnet build
dotnet run --project Kerem.MathGame.csproj
```

## Project Structure

```
Kerem.MathGame/
├── Program.cs              # Application entry point
├── UserMenu.cs             # Main menu and game flow controller
├── GameEngine.cs           # Game logic for each math operation
├── CalculationLogic.cs     # Math problem generation and validation
├── Game.cs                 # Game configuration (score, rounds)
├── Player.cs               # Player information model
├── GameHistory.cs          # Game history data model
├── GameHistoryService.cs   # Service for displaying game history
├── GameRules.cs            # Game rules display
└── Kerem.MathGame.csproj   # Project file
```

## License

This project is part of [The C# Academy](https://www.thecsharpacademy.com/) code reviews.
