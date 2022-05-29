# Random Sentences Generator Application 
A console-based C# implementation of the "**Random Sentences Generator**".

<img alt="Image" src="https://user-images.githubusercontent.com/85368212/169107918-edbc7b4b-4de2-400e-93e3-c23c2fb4c68f.png" />

This **random sentence generator** is just for **fun**! These **sentences** can provide **humour** and be a **cool** way to **surprise** others by sharing a stand-out sentence on **social media** platforms and **gathering** your network’s reaction.

## Solution

The **Generator** is based on the following **model**:

- [Sentence] = `Who` + `Action` + `Details`.

  - **Who** = `Name` | `Name` from `Place`
    - Names = {Peter, Michell, Jane, Steve, ...}
    - Places = {Sofia, London, New York, Germany, ...}
    
  - **Action** = `Verb` + `Noun` | `Adverbs` + `Verb` + `Noun`
    - Verbs = {eats, holds, sees, plays with, brings, ...}
    - Nouns = {stones, cakes, apples, laptops, bikes, ...}
    - Adverbs = {slowly, diligently, warmly, sadly, rapidly}
    
  - **Details** = {near the river, at home, in the park}

[Source Code](RandomSentencesGenerator.cs)

## Screenshots

![Screenshot_2](https://user-images.githubusercontent.com/85368212/169245274-d0a89505-f320-4782-bee8-1d416552d759.png)

![Screenshot_3](https://user-images.githubusercontent.com/85368212/169245287-cfb08caf-3b09-4384-af26-60789662683f.png)

![Screenshot_4](https://user-images.githubusercontent.com/85368212/169245308-115e483c-d0f0-489a-9870-678fbb94aa26.png)


## Live Demo

You can try the generator directly in your Web browser here:

[<img alt="Play Button" src="https://user-images.githubusercontent.com/85368212/170882998-0ef5d9f0-9e1b-4990-adf0-3bdd180bcd9e.png" />](https://replit.com/@PetarPaunov/Random-Sentences-Generator#Main.cs)
