# The "Hangman" Game
A console-based C# implementation of the "**Hangman**" game.

<img alt="Image" width="475px" src="https://user-images.githubusercontent.com/85368212/174783516-1f9955bd-e74c-4639-96c4-ef4c256ea386.jpg" />

[Hangman](https://en.wikipedia.org/wiki/Hangman_(game)) is an **old-school favourite**, a **word game** where the goal is simply to guess the **missing word**. You will be presented with a number of **blank spaces** representing the **missing letters** of the guessed word. Use your **keyboard** to type letters.

- If your **chosen letter** exists in the answer, then **all blank spaces** in the answer where that **letter appears will be revealed**.
- Be warned, every time you **type a wrong letter** you lose a life and the **hangman appears piece by piece**.
- **Solve** the puzzle **before the hangman dies**.

# Input and Output
- Type a letter from `a` to `z` **inclusive**.
- Press `Enter`.

The computer will **check** whether the **letter** is **contained** in the **current guessed word** or **not**. It will also show you the letter in the word or change the hangman.

[Source Code](Hangman.cs)

# Screenshots
<img alt="Image" width="350px" src="https://user-images.githubusercontent.com/85368212/177145745-fe4adad1-4ebd-41e2-aa37-5261ca722f26.png" />

<img alt="Image" width="350px" src="https://user-images.githubusercontent.com/85368212/177145889-b57223a4-094a-4329-a2e5-2e7a64bb0cfa.png" />

<img alt="Image" width="475px" src="https://user-images.githubusercontent.com/85368212/174960923-8211adaa-4973-4fe8-9f38-867fad6e92ab.png" />

<img alt="Image" width="350px" src="https://user-images.githubusercontent.com/85368212/177146374-9f027299-924e-48e7-b1b8-11a5e9c98bce.png" />

<img alt="Image" width="475px" src="https://user-images.githubusercontent.com/85368212/177146505-e2d9333c-8f3d-434a-91b4-1394bef8ef98.png" />

# Live Demo

You can play the game directly in your Web browser here:

[<img alt="Play Button" src="https://user-images.githubusercontent.com/85368212/177146817-86696c1b-6023-4e98-852a-571a37bc690d.png" />](https://replit.com/@PetarPaunov/Hangman#Main.cs)

