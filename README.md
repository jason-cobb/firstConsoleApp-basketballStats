# firstConsoleApp-basketballStats
This app will allow you to enter field goals taken and field goals made to calculate a field goal percentage for players entered for sports such as basketball that use the verbage of field goals and shots made.
This console app will present on the screen 3 opportunities. 1. will give the chance to add a player name and then enter their statistics of field goals attempted and made which will produce the field goal percentage. You may do this for another player by repeating the option 1 after hitting return on the previous player.
Option 2. Will display the information of the players on the team, which will include 3 preset players as well as any that are entered in the console by step one.  The number of shots made out of number taken will be shown as well as the field goal percentage will be calculated behind the scenes and displayed for each player. The total number of players is also counted and produced on this line, which will be the 3 pre-set players as well as any additional players entered.
Option 3. will allow you to exit the console app, then hit the spacebar to close the window.

A class of Player is created and an object is Player.Name as well as the Player.ShotsAttempted and other values that can be entered to populate the data, as well as the 3 pre-entered players and their data.
This value is returned to the user when they select option 2 to Display Player Information and it returns the calculation of the field goal percentage.
The methods under the player class are Name, ShotsAttempted, ShotsMade, and percentage.
The methods under the Main in Program are the 3 questions of AskName, Ask, and AskTwo.

Feature list:
1. A "master loop" - is created in the menuSelection where option 3 is used to exit the loop.
2. Create a list - is pre-populated with 3 players and the option 2 in the menuSelection allows you to add players and their data to return their name and shot data as well as the calculated field goal percentage.
3. Use of a conversion tool - was made to convert the shots made of the shots taken to convert it to a field goal percentage and present it to the screen for the user.
4. Calculate and display data - is done with the playerNames.Count feature is used to total the number of players which is the 3 pre-populated players as well as any that the user inputs in the console.
