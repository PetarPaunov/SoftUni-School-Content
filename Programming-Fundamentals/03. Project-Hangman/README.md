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
<img alt="Image" width="350px" src="https://user-images.githubusercontent.com/85368212/174960199-5e9286fc-a96a-48fc-ac52-150bb6f8909a.png" />

<img alt="Image" width="350px" src="https://user-images.githubusercontent.com/85368212/174960463-c2a9d651-2e0c-419c-8f9e-f64eb23695af.png" />

<img alt="Image" width="475px" src="https://user-images.githubusercontent.com/85368212/174960923-8211adaa-4973-4fe8-9f38-867fad6e92ab.png" />

<img alt="Image" width="350px" src="https://user-images.githubusercontent.com/85368212/174961292-c85a98ac-c6ca-4021-a6bd-7363f81ab820.png" />

<img alt="Image" width="475px" src="https://user-images.githubusercontent.com/85368212/174961375-132c4865-0cfc-47fc-bafb-c1f2a52798bf.png" />

# Live Demo

You can play the game directly in your Web browser here:

[<img alt="Play Button" src="https://user-images.githubusercontent.com/85368212/174962304-4885afaa-35fb-4e11-bece-f0fcaf506b2c.png" />](https://replit.com/@PetarPaunov/Hangman#Main.cs)
