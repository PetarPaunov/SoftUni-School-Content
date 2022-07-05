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
  - Both players place the **next three cards face down** and then **another card face-up**. The owner of the **higher face-up** card **gets all the cards** on the table. 
- The player who **collects all the cards wins**.  

# Input and Output
- Press `Enter` each time to draw a new card until the game ends.  

The computer will **compare** the cards and **tell you which one has the higher value**.

[Source Code](GameOfWar.cs)

# Screenshots

<img alt="Image" width="525px" src="https://user-images.githubusercontent.com/85368212/177323960-02aaab18-1d8a-46fd-a3c2-4c924b126bb0.png" />

<img alt="Image" width="525px" src="https://user-images.githubusercontent.com/85368212/177324156-01d46572-19c2-49ed-a5d9-6727ca994f32.png" />

<img alt="Image" width="525px" src="https://user-images.githubusercontent.com/85368212/177001409-ee524d81-d018-4bac-8ffd-45547492c3c6.png" />

# Live Demo
You can play the game directly in your Web browser here:

[<img alt="Play Button" src="https://user-images.githubusercontent.com/85368212/177325385-4ae44df7-ddeb-4a85-9737-51ffd91398c2.png" />](https://replit.com/@PetarPaunov/Game-of-WarCards#Main.cs)

