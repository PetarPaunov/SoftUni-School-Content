# The "Game Of War" Game
A console-based C# implementation of the "**War (card game)**" game.

<img alt="Image" width="525px" src="https://user-images.githubusercontent.com/85368212/174969843-0b2c231a-8a25-42a0-aa03-f0764903682e.png" />

[Game Of War](https://en.wikipedia.org/wiki/War_(card_game)) is a simple **card game**, typically played by **two players** using a **standard playing card deck**. There are many **variations**.

Rules:
- Each of the **two players** is **dealt one half** of a **shuffled deck of cards**.
- Each turn, each **player draws one card** from their deck.               
- The player that **drew the card with higher value** gets **both** cards.      
  - **Both cards** return to the **winner's deck**.         
- If there is a **draw**, the **cards are thrown away**.    
  - Both players place the next three cards face down and then another card face-up. The owner of the higher face-up card gets all the cards on the table. 
- The player who **collects all the cards wins**.  

# Input and Output
- Press `Enter` each time to draw a new card until the game ends.  

The computer will **compare** the cards and **tell you which one has the higher value**.

[Source Code](GameOfWar.cs)

# Screenshots

<img alt="Image" width="525px" src="https://user-images.githubusercontent.com/85368212/177136595-c4616295-1e87-4571-aa3a-6566107c2960.png" />

<img alt="Image" width="525px" src="https://user-images.githubusercontent.com/85368212/177137188-142cb3e8-7eee-4915-8d3b-787cede82ee3.png" />

<img alt="Image" width="525px" src="https://user-images.githubusercontent.com/85368212/177001409-ee524d81-d018-4bac-8ffd-45547492c3c6.png" />

# Live Demo
You can play the game directly in your Web browser here:

[<img alt="Play Button" src="https://user-images.githubusercontent.com/85368212/177136327-998cee17-eca6-41a2-822a-a897bb36b32e.png" />](https://replit.com/@PetarPaunov/Game-of-WarCards#Main.cs)

