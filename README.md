# Flappy Bird Clone

A basic Flappy Bird clone made with Unity 6. My first completed game project.

---

## Features

- Jump with Space or LMB
- Pipes spawn from the right side
- Spawn speed increases when score reaches 10
- Score counter in the top-left corner
- Death animation triggers on collision with a pipe
- Game over screen shows final score
- Main menu with a start button
- ESC to quit the game
- Tutorial text disappears after the first click

---

## Controls

| Action | Key |
|--------|-----|
| Jump | Space / Left Mouse Button |
| Restart | R |
| Quit | ESC |

---

## Assets

- Sprites: Unity Asset Store (Free)
- All other assets: Built-in Unity components

---

## Scenes

1. MainMenu – Start the game
2. GameScene – Main gameplay
3. DefeatScene – Shows final score, restart via R key

---

## Project Structure

Assets/
├── Scripts/
│   ├── BirdMovement.cs         # Bird control: jump, physics, score, death state
│   ├── Spawner.cs              # Pipe spawning, speed increases after 10 points
│   ├── PipesMovement.cs        # Pipe movement to the left, stops on player death
│   ├── PipeTriggerSetup.cs     # Trigger setup on pipes for scoring when bird passes through
│   ├── GameManager.cs          # Scene switching, ESC to quit
│   ├── StartMenu.cs            # Start button in the main menu
│   └── TextDisappearing.cs     # Tutorial text disappears after the first click
├── Animations/                 # Flight and death animations
├── Sprites/                    # Graphics from Asset Store
└── Scenes/                     # All game scenes

---

## Builds

- WebGL build available on [Itch.io](https://ginwu.itch.io/flappy-bird)
- Windows build also available

---

## What I Learned

- Basic Unity physics (Rigidbody2D, linearVelocity)
- Animator setup and transitions
- Static variables for data sharing between scenes
- Scene management with SceneManager
- Dynamic difficulty implementation
- Publishing to Itch.io and GitHub

---

## Status

Completed. No active development planned.

