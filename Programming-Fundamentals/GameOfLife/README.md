# The "Game of Life" Game
A console-based C# implementation of the "**Conway's Game of Life**" game.

<p align="center">
  <img width="800" src="https://user-images.githubusercontent.com/85368212/194079367-8f8a9d4b-e21f-4988-85ca-a4c857f4f775.png">
</p>

**[Conway's Game of Life](https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life)** is a **cellular automaton** that is played on a **2D square grid**. **Each square** (or "cell") on the **grid** can be either **alive** or **dead**, and they **evolve** according to the following rules:

- **Any live cell** with **fewer** than **two live neighbours dies**.
- **Any live cell** with **more** than **three live neighbours dies**.
- **Any live cell** with **two** or **three live neighbours lives**, **unchanged**, to the **next generation**.
- **Any dead cell** with **exactly three live neighbours** comes to **life**.

The **initial configuration** of cells can be **created by a you**, but all **generations** thereafter are **completely determined** by the **above rules**. 
