# Unity Slot Machine

A slot machine game developed in **Unity 6** as part of a technical assignment. The project features randomized reel spinning, a betting system, coin management, animated lever interaction, sound effects, and win detection based on matching symbols.

---

## Game Overview

The player starts with **1000 coins** and selects a bet amount before each spin. Once a bet is placed, the lever is pulled automatically, the reels spin with randomized outcomes, and the game checks the middle row for matching symbols. Matching all three symbols results in a win and rewards the player based on the selected bet.

---

## Features

- Randomized reel spinning
- Coin management system
- Betting system (50, 100, 150, and 200 coins)
- Sequential reel stopping
- Lever pull animation
- Middle-row win detection
- Sound effects for betting, lever pull, reel spinning, and jackpot
- Clean and responsive user interface

---

## Technologies Used

- Unity 6
- C#
- Unity UI
- TextMeshPro
- Unity Animator
- Sprite Mask

---

## Project Structure

```
Assets
├── Animations
├── Prefabs
├── Scenes
├── Scripts
├── Sounds
└── UI

Build
└── WebGL
```

---

## Running the Project

### Unity Project

1. Clone or download the repository.
2. Open the project using **Unity 6**.
3. Open the main scene.
4. Press **Play** to run the project.

### Web Build

The Web build is located in:

```
Build/WebGL
```

To run the Web build locally, host the folder using a local web server (such as Live Server in Visual Studio Code) or deploy it using a static hosting service like GitHub Pages.

### Windows Build

If included, navigate to:

```
Build/Windows
```

Run:

```
SlotMachineAssignment.exe
```

---

## Bonus Features

- Automatic lever pull after bet selection
- Smooth sequential reel stopping
- Randomized reel outcomes
- Coin balance management
- Audio feedback for gameplay interactions
- Modular script architecture

---

## Development Approach

The project was developed using a modular architecture where individual systems such as reel control, betting, lever animation, coin management, and win detection are separated into dedicated scripts. This approach improves readability, maintainability, and makes the project easier to extend with additional gameplay features.

---

## Developer
**Tushar Saxena**
Unity Game Developer
GitHub: https://github.com/Tushar2677
