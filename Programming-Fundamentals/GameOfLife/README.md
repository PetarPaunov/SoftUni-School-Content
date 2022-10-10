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

# Controls
- Press `[O]` to **create your own field**.
  - `[Arrow keys]` -> **move the cursor**.
  - `[Spacebar]` -> **toggle the cell**.
  - `[Backspace]` -> **start/stop** the **life**.
  - `[Enter]` -> **clear** the **board**.
  - `[Escape]` -> go to **start menu**.
- Press `[B]` to **test the build-in fields**.
  - `[F1]` **generate random field**.
  - `[F2]` generate **pulsar** field (build-in).
  - `[F3]` generate **glider gun** field (build-in).
  - `[F4]` generate **living forever** field (build-in).
  - `[Backspace]` -> **start/stop** the **life**.
  - `[Escape]` -> go to **start menu**.

[Source Code](GameOfLife.cs)

# Screenshots

<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/85368212/194705331-9060c8f7-26cd-4f6c-9246-f51132fe8bc6.png" />
<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/85368212/194762155-a9b27635-4b27-45dc-8ab2-599db20a28d1.png" />
<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/85368212/194762157-a0a97606-8be0-4c5d-8e02-b5b3c3450158.png" />
<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/85368212/194762160-f942657d-1e47-4a9e-8c9e-c6b0100a7f50.png" />

# Live Demo
You can play the game directly in your Web browser here:

[<img alt="Play Button" src="https://user-images.githubusercontent.com/85368212/194762162-c4538fff-6d3f-4357-ac89-81a0c60e9e68.png" />](https://replit.com/@PetarPaunov/GameOfLife-1#GameOfLife.cs)
