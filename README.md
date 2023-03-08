# Dimensional-Hops-Unity-Game

Hopping between two dimensions was an intresting concept and I thought I'd implement it in a 2D game. The mechanics were 
different enough from my first 2 games I thought I would learn new concepts. The aim of the game is to get to the finnishing 
portal by hopping between 2 dimensions and jump over obstacles.

Game Mechanics- 
  -Player can move on the X axis, as well as jump. Jump can only be activated if touching ground
  -Added animations (idle animation, jump animation)
  -Player can hop between the two dimensions using the S key (this is just an illution, player and the camera 
  actually add 50 to their X positin, and the colour of the background changes colour)
  -I had to put a 0.01 second cooldown for the dimension jump, otherwise it executed both X position + 50 
  and X position - 50 at the same time leaving the player in same spot
  -End portal loads new scene
  -Home button lets you exit game as well as choose levels
  
  Imrovements for nect time-
    -Have the scene restart when player falls too low
    -Add enemies
    -Add sound effects 
