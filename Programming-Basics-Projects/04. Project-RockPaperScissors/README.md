# The "Rock - Paper - Scissors" Game
A console-based C# implementation of the "Rock - Paper - Scissors" game.

<img alt="Image" width="200px" src="https://upload.wikimedia.org/wikipedia/commons/6/67/Rock-paper-scissors.svg" />

[Rock - Paper - Scissors](https://en.wikipedia.org/wiki/Rock_paper_scissors) is a simple **two player game**, where you and your oponent (the computer) simultaneously choose one of the following three options: "**rock**", "**paper**" or "**scissors**". The rules are as follows:

- **Rock beats scissors** (the scissors get broken by the rock)
- **Scissors beats paper** (the paper get cut by the scissors)
- **Paper beats rock** (the paper covers the rock)

The **winner** is the player whose choice beats the choice of his oponent. If both players choose the same option (e.g. "paper"), the game outcome is "**draw**".

## Input and Output

The player enters one of the following options:
- `rock` или `r`
- `paper` или `p`
- `scissors` или `s`

The computer chooses a **random option**, then reveals the **winner**.

## Solution

| You       | Computer | Outcome |
| :-------- | :------- | :------  |
|  rock     | rock     | Draw     |
|  rock     | paper    | You lose |
|  rock     | scissors | You win  |
|  paper    | rock     | You win  |
|  paper    | paper    | Drow     |
|  paper    | scissors | You lose |
|  scissors | rock     | You lose |
|  scissors | paper    | You win  |
|  scissors | scissors | drow     |

We handle all these situations using a series of checks.

[Sorce Code](https://github.com/PetarPaunov/SoftUni-School-Content/blob/main/Programming-Basics-Projects/04.%20Project-Rock-Paper-Scissors/Program.cs)

## Screenshots

<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/1689586/167416642-2b055cf0-e26f-4c19-98d9-851e071f80dc.png" />

<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/1689586/167416225-ea1b623f-3ca5-41eb-8871-54cbb9b7784e.png" />

<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/1689586/167416733-3b1c1bac-db50-4b89-9e5d-2d7f778ffc2d.png" />

<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/1689586/167416928-e86bcc6a-97c0-41df-8b24-2009509f253c.png" />

<img alt="Image" width="500px" src="https://user-images.githubusercontent.com/1689586/167417031-f47473e8-a0cf-4f0b-bc92-18d717a29305.png" />

## Live Demo

You can play the game directly in your Web browser here:

[<img alt="Play Button" src="https://user-images.githubusercontent.com/85368212/167705187-fe79e9e7-5dc5-448c-84f3-fc9f6d221ac1.png" />](https://replit.com/@PetarPaunov/Rock-Paper-Scissors#)

