# Monster Dodger Game

## Overview
Monster Dodger is a simple 2D game where the player's objective is to dodge monsters that spawn from both sides of the screen by jumping over them. The game features basic player controls for movement and jumping, monster spawning from random sides, and a scoring system based on the player's survival time.

---------------------------------------------------------------------------------------
![1 3](https://github.com/saahen-sriyan-mishra/Monster-Dodger-UNITY/assets/139043263/547e08e5-6314-46b9-95d8-0d18268bd1c2)
-------------------------------------------------------

## Gameplay
- **Controls**: The player can control the character using the arrow keys (or A and D keys) to move left or right and the spacebar to jump.
- **Objective**: Dodge the monsters by jumping over them. The longer the player survives, the higher the score.

------------------------------------------------------------------
![1 1](https://github.com/saahen-sriyan-mishra/Monster-Dodger-UNITY/assets/139043263/177e322c-3bf0-45f3-9d86-523556460f27)
----------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------
![1 2](https://github.com/saahen-sriyan-mishra/Monster-Dodger-UNITY/assets/139043263/99ad2b13-57f9-4ea2-9b94-eca79f358a5e)
--------------------------------------------------------------------------------------------------------------
## Project Structure
The project is structured as follows:

### Scripts
- **CameraFollow.cs**: Controls the camera movement to follow the player horizontally.
- **Collector.cs**: Destroys objects that collide with a trigger area, used to remove monsters and the player when they go out of bounds.
- **GameManager.cs**: Manages the game state, including player selection, scene loading, and singleton pattern implementation.
- **GameOverManager.cs**: Manages the game over state, displaying text when the player loses.
- **Home_RestartUI.cs**: Controls UI interactions for restarting the game or returning to the main menu to select different character.
- **MainMenu.cs**: Handles interactions with the main menu, including starting the game.
- **Monster.cs**: Defines the behavior of monsters, including their movement speed.
- **MonsterSpawner.cs**: Spawns monsters at random intervals from both sides of the screen.
- **Player.cs**: Implements player movement, jumping, collision detection, and interaction with monsters.

### Prefabs
- **Player**: Prefab for the player character.
- **Monster**: Prefab for the monsters that spawn in the game.

## Note:
-  I created this from learning from freecodecamp, my addition features are a scoring mechanism and a game over display.
  
## How to Use
- Clone the repository or download the .zip file
- Ensure that Unity Engine and Visual Studio is present in the system.
- Go to Scenes in Assets folder Click on MainMenu and press play to play the game.
