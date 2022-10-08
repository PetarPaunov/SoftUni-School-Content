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
  - `[Arrow keys]` to **move the cursor**.
  - `[Spacebar]` **toggle the cell**.
  - `[Backspace]` **start/stop** the **life**.
  - `[Enter]` **clear** the **board**.
  - `[Escape]` go to **start menu**.
- Press `[B]` to **test the build-in fields**.
  - `[F1]` **generate random field**.
  - `[F2]` **pulsar** - build-in field.
  - `[F3]` **glider gun** - build-in field.
  - `[F4]` **living forever** - build-in field.
  - `[Backspace]` **start/stop** the **life**.
  - `[Escape]` go to **start menu**.

[Source Code](GameOfLife.cs)

# Screenshots

<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/85368212/194705331-9060c8f7-26cd-4f6c-9246-f51132fe8bc6.png" />
<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/85368212/194705381-c7cb3eb6-e877-43c9-be3d-bd43f4052002.png" />
<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/85368212/194705438-cecb5a3c-a116-45d4-bd9e-ef70ef5e1ca0.png" />
<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/85368212/194705477-20188cec-d8db-4080-a634-bd214fc5779e.png" />

# Live Demo
You can play the game directly in your Web browser here:

[<img alt="Play Button" src="https://user-images.githubusercontent.com/85368212/194705655-9b4942ac-3a17-49e6-a7be-2a86d449a83f.png" />](https://replit.com/@PetarPaunov/GameOfLifeTest#GameOfLife.cs)
