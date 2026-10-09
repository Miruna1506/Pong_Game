# 🏓 Pong Game

A 2D version of the classic Pong arcade game, built with Unity and C#.

## 🎮 About the Game

Pong is a classic arcade game where two paddles compete to hit a ball back and forth across the playing field. The goal is to score points by getting the ball past the opponent's paddle.

This project recreates the core Pong gameplay, with a player-controlled paddle competing against a computer-controlled opponent. The opponent uses simple rule-based logic to track the ball's vertical position and adjust its movement, simulating basic AI-like behavior.

The game keeps track of the score throughout the match and ends when one of the players reaches the winning score.

## ✨ Features

- **Player Controls** — Move your paddle to hit the ball back toward the opponent.
- **AI Opponent Simulation** — A computer-controlled paddle that follows the ball's vertical position using simple rule-based logic.
- **Ball Physics** — The ball changes direction when it collides with paddles and other game objects.
- **Increasing Ball Speed** — The ball gradually becomes faster as the match progresses.
- **Score System** — Points are tracked as the game progresses.
- **Win Condition** — The match ends when a player reaches the target score.
- **Sound Effects** — Sound resources are included in the project.

## 🕹️ How to Play

1. Start the game in the Unity Editor.
2. Use the player controls to move your paddle and return the ball.
3. Try to get the ball past the opponent's paddle to score points.
4. Reach the winning score before your opponent to win the match.

## 🛠️ Built With

- **Unity** — Game engine
- **C#** — Gameplay logic and object behavior

## 📂 Project Structure

```text
Pong_Game/
├── Assets/
│   ├── Scenes
│   ├── Scripts
│   ├── Resources
│   └── Sounds
├── ProjectSettings/
├── .gitignore
└── README.md
```

The `Assets` folder contains the game's scenes, scripts, sound files, and other resources. `ProjectSettings` contains the Unity project configuration.

*Note: The folder names above illustrate the main asset categories; the exact structure may differ slightly from the repository.*

## 🚀 Getting Started

To run the game locally:

1. Clone or download this repository.
2. Open Unity Hub.
3. Select **Add Project from Disk** and choose the `Pong_Game` folder.
4. Open the project with a compatible Unity Editor version.
5. Open the main game scene from the `Assets` folder.
6. Press **Play** to start the game.

## 📌 Project Information

- **Engine:** Unity
- **Language:** C#
- **Original Unity Version:** `2017.1.2f1`