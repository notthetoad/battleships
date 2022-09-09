all: binary
	mono Program.exe
binary: Program.cs Game.cs Battleship.cs Destroyer.cs Ship.cs Field.cs
	csc Program.cs Game.cs Battleship.cs Destroyer.cs Ship.cs Field.cs
