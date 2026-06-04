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


## W5
### Activity 1
Boss Phase 2 and Item Drop System


I want to build a Boss Phase 2 and item drop system. When the player attacks the Boss, the Boss will lose health. When the Boss health gets low enough, it will enter Phase 2. In Phase 2, the Boss will become stronger, such as attacking faster or moving faster. After the player defeats the Boss, the Boss will drop an item, and the player can pick it up.


Step 1: Make the Boss take damage



1.add a health system to the Boss, with max health and current health. Then, when the player’s attack hits the Boss, the Boss health will go down.

2.Test: Run the game, attack the Boss, and check if the Console shows “Boss took damage.” Also check if the Boss health number goes down.



Step 2: Make the Boss enter Phase 2



1.When the Boss health is below half, the Boss will change from Phase 1 to Phase 2. I can keep this simple at first, like making the Boss move faster or attack more often.

2.Test: Run the game and attack the Boss until its health is below half. Check if the Console shows “Boss entered Phase 2,” and see if the Boss becomes faster or more dangerous.




Step 3: Make the Boss die and drop an item



1.When the Boss health reaches 0, the Boss will die and stop attacking. Then, an item will appear at the Boss’s death position. The player can pick up the item by touching it.

2.Test: Run the game and defeat the Boss. Check if the Console shows “Boss died” and “Item dropped.” Also check if the item appears in the scene. When the player touches the item, the item should disappear.



### Activity 2
In class, I first spent some time browsing itch.io to pick out a boss, then spent a little while setting up its animations and basic controls. I think I’m running a bit behind, so I haven’t gotten to the part I was supposed to write yet））


## W6
### Activity 1
1.The game features newly added dialogue and a second attack phase, and the player and enemy health bars have been updated.



2.[Milestone 2](https://yanzhang111.itch.io/milestone-20506)



3.My testing objective for today is to verify whether the new dialogue and attack mechanics I added are functioning correctly, and to ensure that my character's attack power and health points are reasonably balanced.


4.The NPC dialogue is incorrect and needs to be adjusted; the enemies' attack power also needs tweaking, as it is currently a bit too difficult.



### Activity 2
1.I think it is because Multiply does not simply put two colors on top of each other. Instead, it multiplies the RGB values of the two colors. Since RGB values are usually between 0 and 1, when two numbers smaller than 1 are multiplied together, the result usually becomes smaller. When the value becomes smaller, the color looks darker and less saturated.



2.I think the result will become more transparent. Alpha is also a number between 0 and 1. If we use Multiply, it multiplies the two Alpha values together. The result usually becomes smaller, and a smaller Alpha means the object is more transparent, so it will look more transparent than before.


3.I think these UV values should come from the model itself. Because when a model is made, it usually already has a UV map.


4.Noooooooo, I hate math. (╥﹏╥)



## W7
### Activity 1
1.The Vertex Color node gets its data from the Shiba model itself. The mesh already has color information saved on its vertices, so the shader is just reading that color data and showing it on the model.



2.I think it blends because the color is only saved on the vertices, not on every tiny part of the model. So when Unity shows the model, it has to fill in the color between those vertices. That makes the colors mix together a little instead of having a very clean hard edge.



3.The vertex color Shiba is less detailed because the colors only come from the vertices. A texture can store much more detail, so it looks clearer. I think vertex color is useful for simple color effects, stylized models, or debug views？



4.Maybe something is wrong with the vertex normals, especially around the Shiba’s back-left leg. The color there looks a little strange compared to the rest of the model, so I think that part might have some normal issue.



5.I think we could test UV data with a debug shader. It would be useful because if the UVs look wrong, the texture might stretch or appear in the wrong place on the model. So using color to check UVs can help find texture mapping problems.



6.The lighting has an error because part of the Shiba’s normal data seems wrong. Since the shader uses the normals to calculate lighting, the back of the Shiba gets lit in a strange way when those normals are not correct.



7.I think we used Additive because fire is supposed to look bright and glowing. Additive blending makes the bright parts add light on top of the background, so the fire looks more like it is shining instead of just being a flat texture.



## W8
### Activity 1
1.Since the second stage, I made a lot of small adjustments to my game. Most of them were balance changes, such as adjusting the boss’s health, the enemies’ health, and the player’s health. I also changed some parts of the map and adjusted the difficulty of the platforming sections.




[520 playtest](https://yanzhang111.itch.io/520playtest)




The goal of this playtest was to see whether players felt the difficulty was too hard, whether they could follow my instructions and complete the whole game flow correctly, and whether there were any bugs.



2.Players felt that the character’s attack animation was too long, so it could be shortened a little. They also said that some game items were a bit hard to find. Another issue was that the player’s collider was too large.



### Activity 2
1.I think the Fraction node is used to make the shine texture move in a loop. Since Time keeps going up, the value would keep getting bigger if we used it directly. The Fraction node only keeps the decimal part, so the value keeps looping from 0 to 1. This makes the ShineTex UV move, so it looks like the chest has a moving shine effect on it.



2.The Shine texture needs to be black by default because we use an Add node to add it to the original texture. If it was not black, it would always make the sprite brighter. Black does not really add anything, so the sprite can still look normal.



3.Because the building texture is only used to preview the effect in the ShaderGraph. In the scene, each SpriteRenderer still uses its own sprite, so they do not all become the building texture.



4.I think it is because ShineSpeed should affect Time first, and then the Fraction node loops that value. This way, it changes the speed of the whole shine animation, so it looks more normal. If we multiply after the Fraction node, it only makes the already-looped value bigger, and the effect can look less smooth, like it is jumping a little.




## W9
### Activity 1
1.The game my table chose was Fruit Ninja.



2.The rendering effect we thought of is a full-screen white flash. For example, when the player cuts fruit, gets a combo, or hits a bomb, the screen suddenly flashes bright. We think this effect is probably a full-screen post-processing effect. If we were going to make it, we could make the screen turn white or brighter for a very short time, then quickly go back to normal. The strength of the effect could be controlled by a value, like brightness or opacity. The way to trigger it would probably be through code: when the player cuts a fruit, the game plays the white flash effect once, and then turns it off automatically.




Another effect is the screen effect after cutting a bomb. In Fruit Ninja, if the player cuts a bomb, the screen has a strong reaction, like getting darker or flashing for a second. This is also a full-screen effect. If we were going to make it, when the player cuts a bomb, we could use a time-based component to control the camera shake a little bit, and then quickly return everything back to normal.



### Activity 2
1.<img width="2424" height="1240" alt="image" src="https://github.com/user-attachments/assets/c7be7d7b-61da-4c17-8def-0e18d7741e1a" />



Today, I recreated a similar shader effect in my own game based on what we learned in class. Then I added my own color to the basic effect.




## W10
### Activity 1
1.My playtesting goal this time was to see if players could finish the full game flow, and to check if there were any new bugs.




2.The feedback I got from my classmates was that the attack timing felt a little weird, and the text was kind of hard to read in the game. They also suggested that I should add an “E” prompt when the player gets close to an NPC or an interactive object. Another piece of feedback was that the player should not be able to get close to the Boss before collecting the herbs, because that makes the game flow a little confusing.




3.[Final playtest](https://yanzhang111.itch.io/final-0603)



### Activity 2
1.Our group’s planning method is to first decide the main direction of the game, like whether it is 2D or 3D, and whether it is a platformer, horror game, exploration game, or another type. After that, we can roughly list the main systems the game needs, such as the player, enemies, quests, interactions, and UI.




Next, we can draw a simple object diagram to help us understand the relationships between these systems. Finally, we can break the bigger features into tasks that can be finished step by step, so coding feels more clear.




I think planning helps me understand the overall amount of work better. Some ideas sound simple at first, but after breaking them down, I realize they actually need many parts. Planning ahead helps me decide which features I can actually make and which ones may not be possible.



### Activity 3
1.Today, I changed the font a little and mainly fixed some bugs related to the text. Some dialogue and UI text were not very clear before, so I adjusted the text display to make it easier for players to read during the game.
