# GUI "Tic Tac Toe" App
Simple **C# Windows Forms App** implementation of **Tic Tac Toe** game.

<img width= 325px src="https://user-images.githubusercontent.com/85368212/175223641-f2999e3b-a7ca-4afe-b2e6-927f9859b4a6.jpg" />

[Tic-Tac-Toe](https://en.wikipedia.org/wiki/Tic-tac-toe) is a **paper-and-pencil** game for **two players** who take turns **marking the spaces** in a **three-by-three** grid with **X or O**. The player who succeeds in **placing three of their marks** in a **horizontal**, **vertical**, or **diagonal** row is the **winner**.

Rules:
- The game is played on a grid that's **3 squares by 3 squares**.
- You are **X**, your friend is **O**. Players take turns **putting their marks on the empty squares**.
- The first player to **get 3 of their marks in a row** (up, down, or diagonally) is the **winner**.
- When all **9 squares are full**, the game is **draw**.

# Settings of the Format and the Separate Controls

| Setting                         |  Picture                 |
| --------------------------------|:------------------------:| 
| **TicTacToeForm**:<br>Text = "Tic Tac Toe",<br>Font = Microsoft Sans Serif, 7.8pt,<br>AutoScaleMode = Font,<br>Size = 850, 664|                                           <img alt="Image" width="400" src="https://user-images.githubusercontent.com/85368212/175228278-6fa851e6-abb5-4430-8b5f-0c612b57a873.png" />                
| **playerLabel**:<br>Font = Microsoft Sans Serif, 15.75pt, style=Bold,<br>Text = Player,<br>AutoSize = True,<br>Location = 664, 65,<br>Margin = 4, 0, 4, 0,<br>Size = 97, 31|<img alt="Image" width="125" src="https://user-images.githubusercontent.com/85368212/175231705-e01d6b80-f7ae-4be2-8055-6fba575d1e7b.png" />   
| **buttonsPanel**:<br>Font = Microsoft Sans Serif, 7.8pt, <br>Location = 35, 31,<br> Margin = 4, 4, 4, 4,<br>Size = 600, 554|                                             <img alt="Image" width="400" src="https://user-images.githubusercontent.com/85368212/175229402-76f57df2-e224-40c9-bed3-ced80677417d.png" />   
| **playerButton**:<br>Font = Microsoft Sans Serif, 48pt, style=Bold,<br>Text = X,<br>UseVisualStyleBackColor = True,<br>Location = 664, 100,<br>Margin = 4, 4, 4, 4,<br>Size = 133, 123,<br>Enabled = False|<img alt="Image" width="150" src="https://user-images.githubusercontent.com/85368212/175233498-28a998da-2eff-410b-b595-c818b8b59841.png" />  
| **restartButton**:<br>Font = Microsoft Sans Serif, 7.8pt,<br>Text = Restart,<br>UseVisualStyleBackColor = True,<br>Location = 682, 259,<br>Margin = 3, 3, 3, 3,<br>Size = 94, 29|<img alt="Image" width="150" src="https://user-images.githubusercontent.com/85368212/175234598-2c0bae94-7d60-473f-ad21-02758a684c23.png" />  

# Solution

<img alt="Image" width="450" src="https://user-images.githubusercontent.com/85368212/175240370-0a54ebef-237d-48fd-bc91-44f0c812a90f.png" />

We handle all these situations using a series of **loops and checks**.

[Form Source Code](TicTacToeForm.cs)

# Screenshots

<img alt="Image" width="450" src="https://user-images.githubusercontent.com/85368212/175283153-1ecf9612-ec1c-492e-8787-28899f6db942.png" />

<img alt="Image" width="450" src="https://user-images.githubusercontent.com/85368212/175283950-dc8187e7-8908-4e08-b4fd-4dc5071f1a01.png" />

<img alt="Image" width="450" src="https://user-images.githubusercontent.com/85368212/178105290-4b67e262-8ccf-4e3b-929d-9b2d9c0a6968.png" />

# Download and Try the Application

Download: [here](https://github.com/PetarPaunov/SoftUni-School-Content/releases)
