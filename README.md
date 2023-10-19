# DEU-game
A C# program for a simple DEU game

There are three arrays (A1, A2, and A3) with 15 in size. Initially, they are empty.
There are two players: player1 and player2. 

The aim of the game is to make the "D-E-U" sequence (straight or reverse) among connected squares (horizontally or 
vertically or diagonally).

The game turns alternate between players after each move. At each turn of the game, the program randomly inserts one 
of the three leters “D”, “E” or “U” to any array for a player. In other words, the program determines both the letter and 
target array randomly.

At the begging of the game, each player has a score of 120. At each turn, the score of the player decreases by 5 points.
The game is over
- if a player succeeds in creating a ”DEU” pattern (the winner is the player who made the first “DEU”)
or
- if all arrays are filled up and there is no any “DEU”. (the game is a draw (tie))
- 
The program must display all steps until the game is over.

There are two arrays to store a high score table:

string[] names = {“Derya”, “Elife”, “Fatih”, “Ali”, “Azra”, “Sibel”, “Cem”, “Nazan”, “Mehmet”, “Nil”, “Can”, “Tarkan”} 

int[] scores = {100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30 }

At the end of the game, the program will print the high score table. If the point of the winner exists in the score table, 
the player ID (Player1 or Player2) and his/her score are placed under the old one. First, insert the new element to the 
arrays, and then print the arrays.

![image](https://github.com/AliiBaher/DEU-game/assets/147366590/4a953d8e-f341-4270-88dd-b61e6b940734)
![image](https://github.com/AliiBaher/DEU-game/assets/147366590/4b5eaf3c-914a-48b1-835b-e0123b4c13da)


