# GDIM 33 In-Class Activities
## W1
### Activity 1
[brainstorm](https://docs.google.com/drawings/d/1juUyadzY5pdLHZYG_7olUoVZ2hORbiA3c5x0oQTOyw8/edit)

1.My inspiration sources mostly consist of puzzle games, narrative-driven games, and Metroidvania-style games. I really like the feeling of freely exploring a map, and solving puzzles while exploring, with a high level of freedom. Personally, when I play games, I also tend to prefer 2D games (mainly because I get motion sickness from 3D). I also really like colors and colorful lighting.


2.My tablemate really wants to make a 3D horror game. She prefers a more horror-oriented style and leans toward RPG shooter types of games. Our styles are somewhat different, but we both really like the RPG format！


3.The LA prefers multiplayer competitive shooter games, similar to Overwatch. Our tastes are completely different. I don’t really like PvP games—I prefer single-player games and don’t enjoy competitive gameplay.


### Activity 2
1.I want do 2D platformer＋ puzzle＋story


2.The core gameplay is that the player needs to progress through platforming and puzzle-solving to obtain items, unlock new areas, and advance the game, ultimately escaping. NPCs or narration will be used to drive the progression of the game, and the entire game will have an underlying background story.The gameplay loop is: story → exploration → platform → puzzle-solving → item collection → unlock new areas → Again.

[break-down](https://docs.google.com/drawings/d/19ndeEQ2fwK5_1Ei4o9wf03d8gsiIuWsXk3kHsQobrTg/edit)


## W3
### Activity 1
[break-down](https://docs.google.com/drawings/d/19ndeEQ2fwK5_1Ei4o9wf03d8gsiIuWsXk3kHsQobrTg/edit)


### Activity 2
1.Saving the event name as a Scene variable is a little more convenient, because I do not need to keep typing the same name again and again in different graphs. This not only keeps things more organized, but also makes it less likely that I will make a typo. If I want to change the event name later, I only need to change it in one place instead of updating every graph one by one.


2.What was helpful about Debug.Log() for me was that it let me first check whether a specific step was actually being triggered, instead of waiting until the whole system was finished to find out if something was wrong. For example, I added a Debug.Log() when clicking on the walrus, so when I clicked it and saw a message appear in the Console, I knew that the click itself was working.


3.I think Set Cursor Lock State is not especially relevant to my Vertical Slice, because my game is a 2D platformer and does not really need the cursor to be locked in the center of the screen. However, the idea behind it is still helpful, because if the game has dialogue or UI, different states may still need different control methods.


4.I think the concept of a game state is relevant to my Vertical Slice, but not completely. It is relevant because the assignment requires me to use this system in my game, so I still need to include it. But personally, I feel like writing code directly works better for me and is easier to use. Even so, for this assignment, game states did help organize different situations in the game more clearly.


## W4
### Activity 1
1.In my game, the player can currently move, jump, press E to collect herbs, and check at the gate whether it can be opened. When monsters see the player, they will chase the player and launch attacks.


2.My testing goal is to check whether the functions above are working properly, whether there are any bugs, and whether the movement and jump values are reasonable.



3.playtest team members：Tina Zhang, Xichan Zheng, JingyiBi, Yan Zhang, Alex Ding


4.The issues found during testing are:

The player sometimes gets stuck on the jumping platforms.

The camera is too close to the player.

The attack input should be disabled for now.

If the player falls off the map, they should return to the spawn point.

The player should not be able to move while jumping, so that needs to be disabled as well.


### Activity 2
1.I think yes. Because in this system, the dialogue content is mainly controlled by the DialogueNodeW4 ScriptableObjects. The writer would only need to keep creating new dialogue nodes, write each line of dialogue and player reply, and then connect them to the next node.


2.I think they could make a lot, because each dialogue node is basically just a ScriptableObject. The writer can keep adding new nodes and new branches without writing code. The real limit is not the number of nodes, but how the system and UI are designed. For example, in this activity, the screen can only fit about four options at the same time. So adding more dialogue is not a big problem, but having too many reply options under one node would be limited.


3.I understand this button as something that makes Visual Scripting rescan the code and types in the project, and then update the node library it can use.

