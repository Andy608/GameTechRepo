================================================================================================
README.txt
================================================================================================

Andrew Rimpici
Game Technology II
Assignment 4 Complete
11/04/2018

Github: https://github.com/Andy608/GameTechRepo/tree/assignment-4-complete

Unity Version Number: 2018.2.8f1

================================================================================================

About

- The game starts in the "Title Scene" and has a cinemachine camera in combination with Timeline
  that pans across the scene.
- In the "Level Scene", there is an open area for the character to move around in that is surrounded by
  trees. In the future, zombies will spawn from inside the forest and the player will have to
  stay alive for as long as possible. For now, there are zombies spread throughout the field and
  the player can use left mouse to fire at them. These zombies move towards the player too.

================================================================================================

New Mechanics

- Added in zombie animations! Zombies now have an idle and running state using a blend tree.
- Updated the camera from being 3rd person to 1st person.
- Updated bullet spawning code to be a bit more responsive.
- Cinemachine camera in combination with Timeline that pans across the Title Scene.
- Fading title text animation that appears with activation tracks in timeline.

================================================================================================

Controls

- WASD to move around
- Space to start game in Title Scene
- Space to jump in Level Scene
- Move the mouse to rotate the camera
- Hold the left mouse button to shot and rotate your camera to shoot in that direction

================================================================================================

Struggles

- I was having some trouble getting blendtrees to work on characters that the character doesn't
  control since I couldn't use Input data to change the state of them. I ended up just using
  the enemy's velocity to change the movement state of the animations in the blend tree.
- I had a lot of trouble getting the Cinemachine camera to work with other camera and switching
  between the normal camera and cinemachine cameras. Originally I had the panning feature in the 
  Level Scene but was forced to move it to it's own scene since cinemachine wasn't switching back
  to the normal camera after it finished.
- I also had a bit of trouble with timeline. Overall I liked working with the animation track 
  though.
- I am also in a giant time crunch for my other Unity based class Advanced Seminar, but I have been 
  implementing new things I've learned from this class into that build like the Manager pattern 
  and animations, which has been really helpful.

================================================================================================