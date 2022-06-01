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

![7](https://user-images.githubusercontent.com/85368212/171246377-40c24629-71f7-44be-ba44-494660deec85.png)

![5](https://user-images.githubusercontent.com/85368212/171243475-b155a08e-f4e9-4106-9b05-868ed1d28ad7.png)

![6](https://user-images.githubusercontent.com/85368212/171245531-23cedf88-78d8-4e5f-a201-def7e9492d6d.png)

## Live Demo

You can try the generator directly in your Web browser here:

[<img alt="Play Button" src="https://user-images.githubusercontent.com/85368212/171252376-1083cfd7-6e44-4439-8dd4-94ff212ce0bf.png" />](https://replit.com/@PetarPaunov/Random-Sentences-Generator#Main.cs)
