
# CSharpGrapher

A C# Sharp solution that explores graph theory topics such as:
	- Maze solving
	- Algorithm visualization

## Description of the projects

### GraphUtil

Main library which contains the data stucture I use for every other project.

It is an implementation of a connected graph that it is best suited for grids.
This means that it is really usefull for grid like mazes.

It has two path finding algorithms:

- A*
- Dijkstra (Priotity queue version)

### AStarTest

Just a console project that test basic functionality.

### AStarWinApp

A Windows Forms App that allows you to play visually with both algorithms.

### MazeSolver

This code reads a PNG image to create the graph pixel by pixel.
Then it creates a solver version of the maze drawing the path in red.

## Special thanks:

	- To [Mike Pound](https://github.com/mikepound/mazesolving)'s Maze Solving Python project. All the mazes are his creation.