================================================================================================
README.txt
================================================================================================

Andrew Rimpici
Game Technology II
Assignment 4 Check In
10/18/2018

Github: https://github.com/Andy608/GameTechRepo/tree/assignment-4-checkin

Unity Version Number: 2018.2.8f1

================================================================================================

About

- The scene I have created my map in is called the "Level" scene.
- In the scene, there is an open area for the character to move around in that is surrounded by
  trees. In the future, zombies will spawn from inside the forest and the player will have to
  stay alive for as long as possible. For now, there are zombies spread throughout the field and
  the player can use left mouse to fire at them. These zombies move towards the player too.

================================================================================================

New Mechanics

- Added in zombie animations! Zombies now have an idle and running state using a blend tree.
- Updated the camera from being 3rd person to 1st person.
- Updated bullet spawning code to be a bit more responsive.

================================================================================================

Controls

- WASD to move around
- Space to jump
- Move the mouse to rotate the camera
- Hold the left mouse button to shot and rotate your camera to shoot in that direction

================================================================================================

Struggles

- I was having some trouble getting blendtrees to work on characters that the character doesn't
  control since I couldn't use Input data to change the state of them. I ended up just using
  the enemy's velocity to change the movement state of the animations in the blend tree.

================================================================================================