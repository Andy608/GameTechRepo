================================================================================================
README.txt
================================================================================================

Andrew Rimpici
Game Technology II
Assignment 2 Complete
10/04/2018

Github: https://github.com/Andy608/GameTechRepo/tree/assignment-2-complete

Unity Version Number: 2018.2.8f1

================================================================================================

About

- The scene I have created my map in is called the "Level" scene.
- In the scene, there is an open area for the character to move around in that is surrounded by
  trees. In the future, zombies will spawn from inside the forest and the player will have to
  stay alive for as long as possible. For now, there are zombies spread throughout the field and
  the player can use left mouse to fire at them. These zombies move towards the player too.

================================================================================================

Two New Mechanics

- The first new mechanic is the addition of enemies to the scene. There are now zombie entities
  that chase the player. These zombies will eventually spawn in the forest and come after the
  player in waves.
- The second new mechanic is shooting. The player can now shoot bullets in the direction they
  are facing. Bullets disappear when they collide with something. If the bullet hits a zombie,
  the zombie dies.

================================================================================================

Lighting

- I chose to use baked lighting as I have a lot of trees in my scene and using real time 
  lighting would most likely slow it down. To remedy the amount of objects in my scene, I also
  turned on Occlusion culling like we learned in class.
- I made the directional light seem like it was dusk time to give the level a more ominous feel.
- In addition, I placed lights in the forest to light up the environment as well as make it 
  seem more spooky. In the future, zombies may spawn near these light points.

================================================================================================

Post-Processing

- I added Antialaising, Ambient Occlusion, Depth of Field, Eye Adaption, Bloom, Color Grading,
  and Dithering to my post processing all of which work together to make the scene more ominous.
- Without the post processing, I think the scene still looks nice, but the post-processing gives
  the scene that extra push towards professionalism. I noticed the biggest change when I turned
  on the Antialaising property as it got rid of most of the jagged pixel edges.

================================================================================================

Controls

- WASD to move around
- Space to jump
- Move the mouse to rotate the camera
- Hold the left mouse button to shot and rotate your camera to shoot in that direction

================================================================================================

Struggles

- The lighting took hours upon hours to bake, so I was not able to play around with lighting as
  much as I would have liked. I still like the results though.

================================================================================================