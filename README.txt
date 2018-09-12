================================================================================================
README.txt
================================================================================================

Andrew Rimpici
Game Technology II
Assignment 1
9/12/2018

================================================================================================

5 Additions

1. Adding more 3rd person camera options.
   - Added ThirdPersonCamera script in the new Camera folder located in the Scripts folder.
   - Now when you move the mouse up and down, the camera rotates along the x-axis.
   - Zooming in and out with the mouse will zoom the camera in and out too.

2. Added Coin Manager.
   - Added CoinManager object and script to manage all of the coins in the level.

3. Added Win Condition.
   - Uses the CoinManager to determine once all of the coins are destroyed from the parent,
     then the game goes to the win state.

4. Added Lose Condition.
   - If the player gets hit, the game is over. :o

5. Added End Scene.
   - Once the win or lose condition is satisfied, we go to the end scene to see our results!
   - There is a button that resets the game if the player wants to go again, or an exit button
     if they want to stop playing.

================================================================================================

Struggles

- I keep having a weird Unity bug that says "Copying assembly from 'Temp/Assembly-CSharp.dll'
  to 'Library/ScriptAssemblies/Assembly-CSharp.dll' failed" which forces me to have to restart
  Unity every few minutes.

- The camera rotation took me longer than I expected to implement, but I am pretty happy with 
  the results as of right now.

================================================================================================

Possible Future Topics

- I am interested in learning about TextMeshPro as I'm only familiar with using the default UI
  elements that Unity provides.

- In addition, I am interested in learning about Unity shaders, and lighting.

================================================================================================

I hope you enjoy my build!