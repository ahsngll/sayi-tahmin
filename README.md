# Yeniprjj

Yeniprjj is a Windows Forms application built using C# and .NET 8. The application includes a number-guessing game where the user attempts to guess a randomly generated 4-digit number within a limited number of attempts.

## Features
- Random 4-digit number generation.
- Input validation to ensure proper format.
- Feedback on how close the guess is to the target number.
- Limited attempts to guess the number.

## Requirements
- **.NET 8 SDK**: Ensure you have the .NET 8 SDK installed on your system.
- **Windows OS**: This application is designed to run on Windows as it uses Windows Forms.

## How to Run
1. Clone the repository or download the project files.
2. Open the project in Visual Studio 2022 or later.
3. Restore NuGet packages if required.
4. Build the solution using the __Build > Build Solution__ menu.
5. Run the application by pressing `F5` or selecting __Debug > Start Debugging__.

## How to Play
1. Enter a 4-digit number in the input box.
2. Click the "Guess" button.
3. Follow the feedback provided to adjust your guesses.
4. You have 10 attempts to guess the correct number.

## Project Structure
- **Form2.cs**: Contains the main logic for the number-guessing game.
- **Program.cs**: Entry point of the application.
- **yeniprjj.csproj**: Project configuration file.

## Notes
- Ensure that the input is a valid 4-digit number. Letters or numbers starting with `0` are not allowed.
- The game provides feedback on how close your guess is to the target number.

Enjoy the game!
