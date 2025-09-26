Brain Crown – Quiz Application

Brain Crown is an interactive quiz game developed using C# and Windows Forms.
The purpose of the application is to test general knowledge with multiple-choice questions while providing instant feedback for each answer.

This project can serve as both an educational tool and a practical programming example for beginners who want to understand event-driven programming in C#.

🎯 Features

✅ Multiple-choice questions with four options (A, B, C, D).

✅ Tracks correct and incorrect answers separately.

✅ Instant feedback with visual indicators (✔️ Correct / ❌ Wrong).

✅ "Next" button to move to the next question.

✅ Summary of results at the end of the quiz.

✅ Clean and simple Windows Forms interface.

🖥️ How It Works

The user selects one of the four available answers.

Once an answer is selected, the other buttons are disabled to prevent multiple attempts.

The program compares the selected answer with the correct one.

If correct, the "correct" counter increases, and a ✅ icon appears.

If incorrect, the "wrong" counter increases, and a ❌ icon appears.

The Next button unlocks the following question.

At the end of the quiz, a MessageBox displays the player’s results, showing the number of correct and incorrect answers.

🛠️ Technologies Used

Programming Language: C#

Framework: .NET (Windows Forms)

IDE: Visual Studio

📂 Project Structure

Form1.cs → Main quiz logic, including event handlers for buttons and score tracking.

Form1.Designer.cs → Contains the automatically generated code for UI components.

Resources → Images for correct/incorrect indicators.

🚀 Future Improvements

This project is designed as a simple demonstration, but it can be extended with:

A timer for each question.

A question bank loaded from a database or JSON file.

A scoreboard to store and compare player results.

Improved UI/UX with animations and modern design.

📦 Installation & Usage

Clone or download the project.

Open the solution file (.sln) in Visual Studio.

Build and run the project.

Start answering the questions and track your results!

📝 License

This project is created for educational purposes. You can use, modify, or extend it freely.
