
# 📘 Eldorian Legends: Survival of The Fated — Developer Documentation
_Written by Chen Shiri_

Welcome to the official documentation for **Eldorian Legends: Survival of The Fated**, a fully-featured first-person survival game developed in Unity as the final project for the Game Development course in 2024.

<div align="center">
  <img src="https://raw.githubusercontent.com/BlackD0C/EldorianLegends/refs/heads/main/docs/Into%20the%20Fog%20of%20Eldoria.png" alt="Eldoria Banner" width="500"/>
</div> 
</br>

This documentation is intended for:

- 🧑‍💻 **Developers and instructors** who want to explore the architecture, systems, and implementation details.
- 🎓 **Students and peers** seeking insight into the development process under tight time constraints.
- 🕹️ **Players and testers** curious about how the world of Eldoria was built.

Inside, you'll find a full breakdown of:

- 🎮 Game design, mechanics, and level flow
- 🧠 Character controller and AI system architecture
- 🧩 Modular interaction framework
- 💥 Combat logic and traps
- 🧪 QA/testing, timeline, challenges, and lessons learned

Whether you're reviewing the codebase, studying game architecture, or exploring how a two-person team created a full FPS experience in just three weeks — this documentation provides the complete picture.

> **Built with Unity. Powered by passion. Delivered under pressure.**

Now, let’s dive into the journey behind *Eldorian Legends*.
# 📚 Table of Contents – _Eldorian Legends: Survival of The Fated_

## 🧭 Overview

- Welcome & Usage Guide
- Purpose of this Documentation

---

## 1. 🎮 Introduction

- 1.1 Project Summary  
- 1.2 Team Members and Roles  
- 1.3 Development Timeline  
- 1.4 Game Vision and Concept

---

## 2. 🗺️ Game Design Overview

- 2.1 Genre, Platform, and Target Audience  
- 2.2 Core Gameplay Loop  
- 2.3 Narrative Summary  
- 2.4 Game World: Eldoria and its Regions  
- 2.5 Level Breakdown  
  - 2.5.1 Scene 1 – The Forest  
  - 2.5.2 Scene 2 – The Cemetery  
  - 2.5.3 Scene 3 – The Fortress

---

## 3. 🎯 Project Requirements & Fulfillment

- 3.1 Mapping Requirements to Implementation  
- 3.2 Unrealized or Extended Features  
- 3.3 Technical Constraints and Solutions

---

## 4. 🧠 Character & Control System

- 4.1 First-Person Controller Architecture  
- 4.2 New Unity Input System: Actions & Bindings  
- 4.3 Movement Mechanics  
  - Walking, Sprinting, Jumping, Crouching  
- 4.4 Gravity and Physics Handling  
- 4.5 Camera and Look Control  
- 4.6 Player Animation Integration

---

## 5. ❤️ Player Systems

- 5.1 Health System and UI  
- 5.2 Damage Feedback: Overlays and Clamping  
- 5.3 Game Over Handling  
- 5.4 Player UI Integration

---

## 6. 🔫 Combat System

- 6.1 Bullet Mechanics  
- 6.2 Shooting Logic and Raycasting  
- 6.3 Sound, Muzzle Flash, and Visual Feedback  
- 6.4 Enemy Hit Detection and Kill Count

---

## 7. 👾 Enemy AI System

- 7.1 Enemy Architecture and Behaviors  
- 7.2 Custom State Machine Framework  
  - 7.2.1 `BaseState.cs`  
  - 7.2.2 `PatrolState.cs`  
  - 7.2.3 `AttackState.cs`  
- 7.3 AI Vision and Detection (Raycasting)  
- 7.4 Enemy Animation and State Sync  
- 7.5 Patrol Pathing System (`Path.cs`)  
- 7.6 Future AI Extensions (Flee, Search, Idle)

---

## 8. 🧩 Modular Interaction System

- 8.1 `Interactable.cs`: Base Class Overview  
- 8.2 UnityEvents and Event-based Architecture  
- 8.3 Interactable Implementations  
  - 8.3.1 `CollectCube.cs` – Collectibles  
  - 8.3.2 `Keypad.cs` – Door Triggers  
  - 8.3.3 `AnimateCube.cs`, `ChangeColourCube.cs` – Puzzle Triggers  
  - 8.3.4 `PotionSound.cs` – Audio-Driven Items  
- 8.4 Player Interaction Flow (`PlayerInteract.cs`)  
- 8.5 UI Prompt System and Raycast Logic

---

## 9. 💥 Traps, Hazards & Environment

- 9.1 Trap Mechanics: `TrapBoxScript.cs` and `TrapScript.cs`  
- 9.2 Rigidbody Physics Triggers  
- 9.3 Terrain Design and Custom Level Art  
- 9.4 Realistic Mapping and Lighting Effects  
- 9.5 Procedural Experiments: `Voronoi.cs` and `VoronoiGenerator.cs`

---

## 10. 🌐 Scene Management & Progression

- 10.1 Scene Transitions Based on Kill Count  
- 10.2 `GameManager.cs`: Global State Management  
- 10.3 Level Objectives and Progression Logic  
- 10.4 Menu System (`MenuScript.cs`) and Scene Controls

---

## 11. 📊 UI and Feedback Systems

- 11.1 HUD Design (`PlayerUI.cs`, `FadeEffect.cs`)  
- 11.2 Health Bars, Win Conditions, and Game Over Text  
- 11.3 Interaction Prompts and Dynamic Text  
- 11.4 Audio Feedback Integration

---

## 12. 🎨 Design Choices and Aesthetics

- 12.1 Visual Themes and Worldbuilding  
- 12.2 Animation Implementation and Transitions  
- 12.3 Sound Design and Environmental Ambience  
- 12.4 Immersion Techniques (FOV, lighting, interaction timing)

---

## 13. 🛠️ Tools, Architecture & Best Practices

- 13.1 Script Organization and Structure  
- 13.2 Code Reusability and Extensibility  
- 13.3 Debugging and Editor Scripts (`Path.cs`)  
- 13.4 Performance Considerations and Optimization

---

## 14. 🧪 Testing & QA

- 14.1 Playtesting Feedback  
- 14.2 Edge Case Handling  
- 14.3 Bugs Encountered and Fixes Applied  
- 14.4 Missing Requirements and Rationale

---

## 15. 🎞️ Trailer, GDD & Submission Materials

- 15.1 Game Trailer and Highlights  
- 15.2 Final Game Design Document Summary  
- 15.3 Submission Package Checklist

---

## 16. 🧠 Reflections & Lessons Learned

- 16.1 Technical Skills Acquired  
- 16.2 Design & Collaboration Insights  
- 16.3 Future Improvements and Next Steps  
- 16.4 Advice to Other Developers

---

## 17. 📁 Appendix

- 17.1 Full Script Index  
- 17.2 Class Relationships and Diagrams  
- 17.3 Code Snippets and Explanations  
- 17.4 Known Issues and Developer Notes

---

# 1. 🎮 Introduction

Welcome to _"Eldorian Legends: Survival of The Fated"_, a first-person survival adventure built in Unity by Chen Shiri and Itay David as a final project for the Game Development course in 2024. This game represents not just a culmination of technical skills learned throughout the course, but also a demonstration of creativity, storytelling, and game design principles brought to life.

The core of _Eldorian Legends_ revolves around the player's journey through a mysterious and dangerous world. Stranded in an unfamiliar realm, the player must navigate through dense forests, haunted cemeteries, and ancient fortresses to survive and uncover the secrets of Eldoria. Along the way, they face dangerous enemies, solve environmental puzzles, interact with the world using a modular interaction system, and uncover fragments of the world’s hidden lore.

This project showcases:

- A **custom-built character controller** using Unity's new Input System.
    
- **Enemy AI** with a full-featured, modular **state machine** and patrol/search/combat logic.
    
- A robust **interaction system** based on inheritance and UnityEvents.
    
- **Dynamic health, UI, and scene progression systems.**
    
- **Realistic terrain and atmospheric environments**, all crafted by hand.
    
- **Integration of physics, raycasting, animations, and audio** for a polished gameplay experience.
    

Throughout the development process, we adhered closely to course requirements while also extending functionality far beyond the basics, adding AI vision systems, layered animation logic, procedural systems, and custom gameplay mechanics.

This document provides an in-depth look at the technical and design aspects of the game, with detailed explanations of its architecture, gameplay systems, AI, and development process. Whether you’re a fellow developer, an instructor, or simply curious about the process of building a full-featured FPS in Unity — welcome to our world.

**Let the journey into Eldoria begin.**

---

### 🎯 Game Vision and Concept

Our goal was to create a first-person survival experience that combines atmosphere, tension, and combat with an evolving story. We envisioned a world where the player would feel immersed and alert — scavenging resources, avoiding traps, and facing intelligent enemies that respond dynamically.

We focused on delivering a **complete, polished experience** across three distinct levels, each with its own feel, mechanics, and threats. By blending **fantasy lore, stealth, shooting, and exploration**, we aimed to make the game both intuitive and intense — something that invites curiosity but demands attention.

---

### ⏳ Development Timeline

The entire game, including design, programming, environment creation, testing, and documentation, was completed in **just three weeks**.

This was an intense challenge: both of us were simultaneously working **full-time jobs** and going through **the busiest semester of our degree**. Managing deadlines, implementing core systems, and polishing the game under such time constraints pushed us to plan efficiently, divide responsibilities, and build flexible, modular code that could evolve quickly.

Despite the pressure, we are proud of the result: a playable, immersive game that reflects our passion and commitment to game development.


---

### 👨‍💻 Chen Shiri – Main Programmer & Architect

Chen was responsible for designing and implementing the **entire gameplay logic** and **character systems**, including:

- First-person controller and camera system
    
- Combat, raycasting, and health logic
    
- Enemy AI with a custom state machine
    
- Modular interaction system and UI logic
    
- Game architecture, scene flow, and script organization
    

> “I focused on bringing systems to life — from movement to enemies to interactions — and making sure everything just _worked_.”

---

### 🌲 Itay David – Environment & World Designer

Itay led the creation of Eldoria’s **visual identity** and **environmental experience**, including:

- Realistic terrain and handcrafted scene layouts
    
- Lighting, fog, and post-processing effects
    
- Environmental storytelling and visual puzzles
    
- Scene polish, UI art feedback, and spatial immersion
    

> “My goal was to make Eldoria feel like a place you could get lost in — atmospheric, eerie, and alive.”
## 2. 🗺️ Game Design Overview

### 2.1 🎮 Genre, Platform, and Target Audience

**Genre:**  
_Eldorian Legends: Survival of The Fated_ is a **First-Person Shooter (FPS)** with **survival**, **exploration**, and **mystery-adventure** elements. It blends fast-paced combat, strategic stealth, environmental interaction, and puzzle-solving into a cohesive and immersive experience.

**Platform:**  
The game was developed using **Unity** for the **PC platform** (Windows), but the architecture and control system allow for easy porting to consoles or other platforms in the future.

**Target Audience:**  
This game targets **teenagers and young adults aged 16 and above**, particularly fans of survival adventures, fantasy lore, and combat-focused gameplay. The game includes themes of danger, exploration, and combat — ideal for players who enjoy tense, atmospheric environments and engaging AI encounters.

---

### 2.2 🔁 Core Gameplay Loop

The player begins in an unknown land, with no resources or weapons. The gameplay loop centers around:

1. **Exploration** – Traverse a vast and mysterious world filled with secrets, items, and environmental clues.
    
2. **Survival** – Avoid or confront hostile enemies using stealth, movement, and shooting mechanics.
    
3. **Interaction** – Engage with the world through raycast-based interactions: collect items, activate objects, unlock doors.
    
4. **Progression** – Unlock new levels by surviving enemy encounters and achieving goals like reaching kill thresholds or collecting key items.
    
5. **Combat** – Use intuitive FPS shooting mechanics to defeat enemies, preserve health, and manage risk.
    
6. **Navigation** – Move through three distinct scenes with increasing difficulty, unique themes, and new threats.
    

Each scene introduces **new mechanics**, **enemy behaviors**, and **interactables**, keeping the experience fresh while reinforcing core survival mechanics.

---

### 2.3 📖 Narrative Summary

The story of _Eldorian Legends_ unfolds in a **fantasy world ravaged by time and war**. The player, an unnamed survivor, finds themselves stranded in **Eldoria**—a mysterious land where ancient ruins, mystical forces, and corrupted creatures roam.

**Scene 1: The Enchanted Forest**  
The player awakens deep in the heart of Eldoria’s cursed forest. It’s eerily quiet, but something lurks behind the trees. Their only goal: survive. By scavenging supplies and navigating carefully, the player learns the rules of this world and the danger that stalks them.

**Scene 2: The Cemetery**  
After escaping the forest, the player finds themselves in a haunted cemetery. Spirits, traps, and shadowy figures guard a forgotten artifact. Here, the player must rely on more than just their aim — puzzle-solving and precision movement are key to making it through alive.

**Scene 3: The Fortress of Fate (Boss Level)**  
All paths lead to the ancient fortress, where the game’s final confrontation awaits. The player must defeat waves of enemies, overcome brutal traps, and reach the mystical portal that may be their only escape. The fortress is shrouded in secrets and holds the ultimate test of survival.

The story is delivered non-linearly — the player discovers hints and lore through environmental storytelling, interactable objects, and progression between levels. The minimalist approach gives room for interpretation while maintaining immersion and pacing.

---

### 2.4 🌍 Game World: Eldoria and its Regions

The world of _Eldoria_ is ancient, broken, and full of mystery. It is a place where remnants of forgotten civilizations lie buried beneath forests and ruins, and the boundaries between natural and supernatural have faded. Designed with immersion and realism in mind, Eldoria features hand-crafted terrain, atmospheric lighting, and carefully balanced enemy placement to encourage exploration, stealth, and action.

Eldoria is divided into **three main regions**, each with distinct themes, hazards, and gameplay mechanics:

- **The Enchanted Forest** – Dense, shadowy woodlands full of tight pathways, hidden traps, and roaming enemies. It introduces the player to basic survival, movement, and interaction mechanics.
    
- **The Cemetery of Whispers** – A ghostly graveyard where tombstones and crypts hide secrets and death. Puzzles, traps, and ambient horror increase the stakes.
    
- **The Fortress of Fate** – A dark and fortified structure high in the mountains. This final zone tests everything the player has learned — combat, timing, awareness — and culminates in a climactic battle.
    

Each region of Eldoria not only progresses the game mechanically and narratively but also evolves the tone and level of challenge. All regions were sculpted using Unity’s terrain tools and populated with interactable elements, enemies, and props for a grounded, fantasy-survival feel.

---

### 2.5 🧭 Level Breakdown

#### 2.5.1 🌲 Scene 1 – The Forest

The first playable scene introduces the player to the world of Eldoria and the core mechanics of survival and exploration. It is designed to be atmospheric, eerie, and slightly disorienting — capturing the feeling of waking up in a dangerous unknown.

**Key Features:**

- **Tutorial Through Discovery:** There are no explicit UI tutorials. Players learn by doing — interacting with the environment, exploring paths, and facing threats organically.
    
- **Realistic Terrain:** Designed using Unity’s terrain editor, with elevation changes, dense trees, and ground clutter to support stealth and line-of-sight gameplay.
    
- **Enemies:** Basic AI enemies patrol the area. They detect the player via raycasting and transition between patrol and attack states using the custom state machine.
    
- **Interactables:** Includes simple interaction puzzles like unlocking a path or collecting a key item. Players interact using a custom raycast-based system.
    
- **Health System:** Damage from traps and enemies introduces the player to the health mechanic. A dynamic health bar with clamping and damage overlay gives clear feedback.
    
- **Navigation Challenge:** The level is nonlinear, encouraging exploration while guiding the player through visual cues and enemy placement.
    

The goal of this level is not just to survive, but to **adapt** — to understand how to move, when to engage, and how to uncover what lies ahead. By the end of the forest, players are equipped (mentally and mechanically) for the more dangerous areas to come.

---

#### 2.5.2 ⚰️ Scene 2 – The Cemetery

The second scene marks a tonal shift in the game — from open woodland survival to claustrophobic tension and environmental danger. Set in a haunted cemetery, this level introduces **psychological atmosphere**, **tight navigation**, and **deadly traps** that force the player to think before acting.

**Key Features:**

- **Horror-Themed Environment:** A chilling ambient soundscape and fog-laden visuals create a sense of unease. Tombstones, broken mausoleums, and underground crypts deepen the sense of mystery.
    
- **Increased Trap Density:** Custom trap scripts and collider-based interactions punish reckless movement. The player must be more deliberate in how they explore.
	
- **Wave-Based Combat:** Enemies spawn in groups, forcing players to manage space,  and health wisely.
     
- **Enemy AI Upgrade:** Enemies in this level are more aggressive and numerous. The AI’s **search behavior** is more prominent, with longer vision cones and alert timers.
    
- **Environmental Storytelling:** Details in the gravestones, architecture, and hidden notes suggest something ancient and tragic occurred here — a fragment of Eldoria’s dark past.
    

This level’s purpose is to increase pressure on the player while introducing more mechanical depth. It rewards **caution**, **pattern recognition**, and **situational awareness**.

---

#### 2.5.3 🏰 Scene 3 – The Fortress

The final level — known in lore as **The Fortress of Fate** — is the apex of the game’s design and difficulty. It serves as the **climactic confrontation** between the player and the dark forces of Eldoria. Set inside a mountainous stronghold, this level combines everything introduced so far: exploration, AI combat, puzzle-solving, and survival instincts.

**Key Features:**

- **Vertical Multi-Layered Design:** Players must ascend through corridors, towers, and broken chambers to reach the final portal. The environment encourages tactical positioning and timing.
    

- **Kill Threshold Mechanic:** Similar to the earlier scenes, progression is tied to eliminating a required number of enemies — here, the player must **defeat seveal enemies** to unlock the portal and escape.
    
- **Advanced AI Patterns:** Enemies make use of advanced search patterns and better line-of-sight tactics. Their **animation state machine** adds realism to their responses.
    
- **Portal Sequence:** Once the requirement is met, a glowing portal activates, signaling the player’s opportunity to escape — but reaching it requires surviving a final gauntlet of traps and timed obstacles.
    

This scene represents the culmination of the player's journey — a final exam in stealth, agility, and combat mastery. It’s meant to feel intense, chaotic, and triumphant.

---

## 3. 🎯 Project Requirements & Fulfillment

### 3.1 ✅ Mapping Requirements to Implementation

This section details how the game fulfills or exceeds each of the original project requirements, as defined in the final project brief.

|**Requirement**|**Implementation in _Eldorian Legends_**|
|---|---|
|**First-person game**|Fully implemented using a custom first-person controller built on Unity’s **new Input System**.|
|**Three playable levels/scenes**|✔️ Scene 1: Forest, ✔️ Scene 2: Cemetery, ✔️ Scene 3: Fortress – each fully designed and functional.|
|**One goal per level**|Scene 1: Reach the goal; Scene 2: Solve environmental challenges; Scene 3: Kill enemies to unlock portal.|
|**Use of terrain**|All scenes feature **hand-crafted terrain** with realistic elevation, foliage, and textures.|
|**Realistic elements**|Includes terrain realism, lighting, physics-based movement, AI behavior, and detailed level theming.|
|**Character controller**|Designed from scratch using physics, raycasting, and Input Actions; includes walking, jumping, gravity.|
|**Health bar / UI**|Dynamic health system implemented with **Mathf.Clamp**, overlay effects, and responsive UI.|
|**Enemy with animations**|Custom enemies with **state machines**, **animation controllers**, and behavior logic (patrol/attack).|
|**At least one interaction**|Multiple raycast-based **Interactables**: collect cubes, activate animations, open doors, etc.|
|**Scene change via interaction**|Seamless level transitions using triggers and scripted scene management.|
|**Original content**|All terrain, character logic, UI, interaction systems, and code are original and student-developed.|

---

### 3.2 🛠️ Unrealized or Extended Features

Some features were intentionally **extended** beyond the requirement, while others were considered but deprioritized due to time constraints.

**Extended Features:**

- **Custom AI State Machine:** Instead of relying on Unity’s built-in systems, a fully modular state machine was built from scratch.
    
- **Multiple Interaction Types:** Including color-changing cubes, animated cubes, potion SFX, keypad locks, and particle systems.
    
- **Realistic Gravity and Jumping:** Applied via custom physics logic for better control and immersion.
    
- **Trap Mechanics:** Trigger-based traps (e.g., TrapBox, damage zones) that affect the health system.
    
- **Procedural Effects:** Voronoi diagram logic for advanced effects (not fully integrated due to time).
    

**Unrealized (Due to Time):**

- Save/load system.
    
- Full inventory UI for collected items.
    
- Enemy variety (only one enemy model with modular states).
    
- Cinematic cutscenes or voice-acted story beats.
    

---

### 3.3 🧩 Technical Constraints and Solutions

Given the **tight 3-week development window**, while managing **full-time jobs and academic overload**, the project faced multiple technical challenges:

|**Constraint**|**Solution**|
|---|---|
|Very limited time|Split tasks efficiently, built modular code to enable reuse across levels and features.|
|No asset budget|Used Unity built-ins or created assets manually (terrain, prefabs, UI, effects).|
|AI complexity vs. time|Built scalable state machine logic; reused transitions and added modular behaviors.|
|Physics inconsistencies|Refined character movement with physics + math hybrid (e.g., `Mathf.Clamp`, manual gravity).|
|Input System complexity|Used Unity’s new Input System with actions for movement, interaction, and UI control.|
|Multiple scenes|Designed scripts like `NextLevelScript.cs` and `GameManager.cs` to handle transitions safely.|
|UI scaling and health logic|Applied `Mathf.Clamp` and Unity Events for smooth feedback and damage processing.|

Despite the pressure, the final result is a **fully functional**, **visually coherent**, and **mechanically rich** FPS game that reflects strong project management and problem-solving skills under real-world conditions.

---

## 4. 🧠 Character & Control System

The character control system in _Eldorian Legends_ was built entirely from scratch using Unity’s **new Input System**, with realistic movement, gravity, camera control, and player feedback mechanisms. Every mechanic was fine-tuned to create a smooth and immersive first-person experience.

---

### 4.1 🧱 First-Person Controller Architecture

At the core of the player system is the **`PlayerMotor.cs`** script, which works in tandem with other components like `PlayerLook.cs`, `InputManager.cs`, and `CharacterController`. The system is modular and extensible, structured into clean responsibilities:

- **PlayerMotor.cs** – Handles actual movement logic (velocity, direction, jumping, sprinting).
    
- **InputManager.cs** – Connects Unity’s Input Actions to player movement and interaction.
    
- **PlayerLook.cs** – Controls camera rotation based on mouse input.
    
- **PlayerUI.cs** – Displays dynamic UI feedback, such as health and damage overlays.
    

This separation ensures clarity, testability, and scalability.

---

### 4.2 🎮 New Unity Input System: Actions & Bindings

The project uses Unity’s **new Input System**, which enables powerful event-based input handling. Key bindings are configured as **Input Actions**, supporting modular design and clean code.

Actions include:

- `Move` (WASD / Arrow Keys)
    
- `Jump` (Spacebar)
    
- `Sprint` (Left Shift)
    
- `Crouch` (Left Ctrl)
    
- `Look` (Mouse Delta)
    
- `Interact` (E)
    
- `Shoot` (Mouse Left)
    

Bindings are set up in the Input Actions asset and referenced dynamically in `InputManager.cs`, promoting reusability and compatibility with future devices (e.g., gamepads).

---

### 4.3 🏃 Movement Mechanics

All core movement mechanics were implemented programmatically using physics and math logic:

- **Walking:** Controlled via normalized directional vectors and `CharacterController.Move()`.
    
- **Sprinting:** Increases player speed while holding Shift, with a stamina-considerate mechanic in mind.
    
- **Jumping:** Conditional jump using `isGrounded` and a jump force applied over time.
    
- **Crouching:** Reduces player height and adjusts collider for tighter spaces and stealth.
    

Code Sample:

```csharp
Vector3 move = transform.right * input.x + transform.forward * input.y;
characterController.Move(move * speed * Time.deltaTime);
```

Each action blends naturally with camera motion and environmental interactions.

---

### 4.4 🌌 Gravity and Physics Handling

Rather than relying on Unity’s built-in Rigidbody gravity, gravity was **manually applied using Mathf and velocity calculations** in `PlayerMotor.cs`:

- Gravity is accumulated each frame using a custom `yVelocity` variable.
    
- Jumping and falling are handled smoothly, with `Mathf.Clamp` used to limit extremes.
    
- This method avoids inconsistent Rigidbody physics while maintaining responsive control.
    

```csharp
yVelocity += gravity * Time.deltaTime;
Vector3 verticalMove = Vector3.up * yVelocity;
controller.Move((move + verticalMove) * Time.deltaTime);
```

This gives a **natural fall effect** and avoids common Unity physics issues like bouncing or floatiness.

---

### 4.5 🎥 Camera and Look Control

Camera control is managed by the `PlayerLook.cs` script, which rotates the camera smoothly based on mouse delta:

- **Horizontal rotation** (yaw) affects the player object.
    
- **Vertical rotation** (pitch) is clamped to avoid over-rotation.
    
- Mouse sensitivity is adjustable and frame-rate independent.
    

This system creates a **fluid FPS experience**, directly influenced by industry-standard mechanics.

---

### 4.6 🎞️ Player Animation Integration

Animations were integrated using **Animator Controllers**, with transitions triggered through movement states:

- Walking and idle animations blend based on player velocity.
    
- Jump and land animations play with event-based triggers.
    
- Crouch animations sync with the player height toggle.
    

Although the main focus was mechanics and systems, animation was used where it most enhances feedback and immersion, particularly for jumping and enemy interactions.

---

## 5. ❤️ Player Systems

To enhance immersion and create a responsive gameplay experience, _Eldorian Legends_ features a custom-built player system that includes dynamic health management, responsive UI feedback, and game state transitions. This system is designed for both clarity and challenge, integrating visual and audio cues that respond to in-game events like damage and death.

---

### 5.1 💉 Health System and UI

The health system is implemented in `PlayerHealth.cs` and uses a float-based model with values from **0 to 100**. Health is decreased by enemy attacks, traps, and other hazards. Players can also regain health using certain interactables (e.g., potions).

**Key Features:**

- Real-time updates to health UI (bars and text).
    
- Access to health value globally via `GameManager.health`.
    
- Damage and healing functions (`TakeDamage(float)` and `RestoreHealth(float)`).
    
- Uses `Mathf.Clamp()` to ensure values never exceed bounds.
    

```csharp
currentHealth = Mathf.Clamp(currentHealth - damage, 0, 100);
```

---

### 5.2 🩸 Damage Feedback: Overlays and Clamping

Visual feedback is crucial for immersion and clarity, especially during combat. The game uses a **red overlay effect** and a two-layer health bar system:

- **Front bar** drops instantly on damage.
    
- **Back bar** lags behind for a “smooth drop” effect.
    
- **Overlay effect** flashes red when taking damage.
    
- UI uses `CanvasGroup` and `Lerp()` functions for smooth fading.
    

This system ensures the player is always aware of their current state without breaking immersion.

---

### 5.3 ☠️ Game Over Handling

When health reaches **0**, the game enters a **Game Over** state:

- Displays a large “GAME OVER” UI text on screen.
    
- Triggers an animation and optionally plays a sound.
    
- Waits for a few seconds before reloading the scene (`SceneManager.LoadScene(0)`).
    

This is handled inside `PlayerHealth.cs`, ensuring that **health loss, UI, and death state** are tightly integrated into one logical flow.

---

### 5.4 🖥️ Player UI Integration

The game features a polished and minimalistic UI to support player health, objectives, and visual feedback:

- **Health Number** – dynamically displays current health in text form.
    
- **Health Bar UI** – two-layer bar for realistic damage presentation.
    
- **Damage Overlay** – alpha-faded red screen effect upon injury.
    
- **Interaction Prompt** – shown via `PlayerUI.cs` when looking at interactables.
    
- **Crosshair** – subtle but precise, always centered, assisting in aiming and interaction.
    

All UI elements are updated in real time using UnityEvents, `CanvasGroup`, and `TextMeshPro`, ensuring responsive, non-intrusive visual feedback that empowers the player.

---

## 6. 🔫 Combat System

The combat system in _Eldorian Legends_ is designed to deliver fast, responsive, and satisfying first-person shooting mechanics. Built from scratch using raycasting, physics, custom logic, and visual/audio effects, the system provides fluid enemy engagement and integrates seamlessly with the game's AI and health systems.

---

### 6.1 💥 Bullet Mechanics

Rather than using physical projectiles, the game implements **instantaneous bullet hits** using raycasting, allowing for immediate enemy impact and accuracy in a first-person context.

**Script:** `Bullet.cs`

- Bullets use `Physics.Raycast()` from the camera forward direction.
    
- On hit, the script checks for objects with a `Tag` (e.g., “Enemy”) or a health component.
    
- Damage is applied immediately through direct calls to enemy state logic.
    

Advantages:

- High performance (no Rigidbody required)
    
- Immediate hit feedback
    
- Allows precise enemy targeting
    

---

### 6.2 🎯 Shooting Logic and Raycasting

The player’s weapon fires a ray each time the shoot input is triggered. The raycast is handled from the **camera’s center** to ensure FPS accuracy.

**Implementation Details:**

- Input handled via Unity’s new Input System (`Fire` action)
    
- Raycast originates from `Camera.main.transform.position`
    
- `RaycastHit` captures the object, distance, and hit point
    
- Upon hitting an enemy, it triggers damage logic in `Enemy.cs` and visual effects
    

```csharp
if (Physics.Raycast(camera.position, camera.forward, out hit, range)) {
    if (hit.transform.CompareTag("Enemy")) {
        hit.transform.GetComponent<Enemy>().TakeDamage(damage);
    }
}
```

---

### 6.3 💡 Sound, Muzzle Flash, and Visual Feedback

To enhance immersion and realism, the shooting system includes audiovisual effects:

- **Muzzle Flash:** A particle system or quick UI flash is shown at the gun's barrel when firing.
    
- **Gun Sound Effect:** A gunshot SFX plays on each fire, using `AudioSource.PlayOneShot()`.
    
- **Impact Effect:** Optional blood spatter or hit marker feedback can be added for further polish.
    

These effects are synchronized with the raycast event to ensure consistency and clarity during combat.

---

### 6.4 🧟 Enemy Hit Detection and Kill Count

When an enemy is hit:

- The **enemy health** is reduced.
    
- If health <= 0, the enemy plays a **death animation** (via Animator) and is destroyed.
    
- Kill count is tracked through a **global counter** (used in the final level to unlock the portal).
    
- A feedback message (e.g., “Enemy Eliminated”) can be optionally shown via UI.
    

This system is central in the **third level**, where **killing a specific number of enemies (9)** is required to progress and activate the portal escape.


This combat system offers tight integration between player mechanics, enemy AI, and game objectives, ensuring that combat feels impactful and purposeful throughout the experience.


---

## 7. 👾 Enemy AI System

To bring the world of _Eldorian Legends_ to life, a **custom-built enemy AI system** was implemented using a modular **state machine** architecture. The system governs enemy behavior including patrols, vision detection, and attacks. It runs independently from the animation state machine, allowing for fine-tuned gameplay behavior and responsiveness.

---

### 7.1 🤖 Enemy Architecture and Behaviors

**Core Script:** `Enemy.cs`

The enemy system is composed of:

- A `NavMeshAgent` for movement and pathfinding.
    
- A `StateMachine` component to manage transitions between states.
    
- Vision and attack logic using raycasting.
    
- Health and death management via collision with player bullets.
    

Enemies behave as follows:

- Patrol along waypoints when idle.
    
- Detect and pursue the player via raycast-based vision.
    
- Transition to attack when in range.
    
- Die when health reaches 0, triggering animations and progression events.
    

---

### 7.2 🧠 Custom State Machine Framework

Instead of relying on Unity’s Animator-driven transitions for logic, a **custom state machine framework** was implemented in C# to control AI behavior at runtime.

#### 7.2.1 `BaseState.cs`

- Abstract base class.
    
- Defines common structure for `EnterState()`, `UpdateState()`, and `ExitState()`.
    
- Used to allow flexible transitions between different AI modes.
    

#### 7.2.2 `PatrolState.cs`

- Controls movement between waypoints.
    
- Uses `NavMeshAgent.destination` and `remainingDistance` for transition conditions.
    
- Transitions to `AttackState` when player is detected.
    
- Includes idle pauses and movement speed variations for realism.
    

#### 7.2.3 `AttackState.cs`

- Activated when the player enters vision range.
    
- Stops the agent, faces the player, and triggers attacks.
    
- Includes attack animations and damage logic.
    
- If the player escapes vision or moves too far, transitions back to patrol.
    

This modular design allows for **scalability and clarity** across enemy types.

---

### 7.3 👁️ AI Vision and Detection (Raycasting)

The enemy detects players using **Physics.Raycast()**:

- A ray is cast from the enemy’s "eye" toward the player’s direction.
    
- If it hits the player without obstruction and within a detection range, it triggers pursuit.
    
- Vision cones and obstacles are respected for stealth potential.
    

Code logic from `Enemy.cs`:

```csharp
if (Physics.Raycast(transform.position, directionToPlayer, out hit, detectionRange)) {
    if (hit.transform.CompareTag("Player")) {
        stateMachine.ChangeState(new AttackState());
    }
}
```

This technique mimics real-world line of sight, allowing players to hide behind objects or avoid detection.

---

### 7.4 🕺 Enemy Animation and State Sync

Enemy animations are managed **independently** via Animator Controllers:

- Walk, idle, and attack animations are triggered via bools in states.
    
- Sync logic is embedded within each state script (e.g., `animator.SetBool("isWalking", true)`).
    
- Death animation plays when health drops to zero before destroying the enemy GameObject.
    

This separation of animation and logic ensures both systems operate fluidly without interference.

---

### 7.5 🗺️ Patrol Pathing System (`Path.cs`)

Enemies use **custom waypoint systems** for patrol routes:

- Waypoints are manually placed in the scene and referenced by the `Path.cs` script.
    
- Enemies loop or reverse through waypoints with slight idle delays.
    
- Supports varied patrol behaviors (random, cyclic, etc.).
    

Code Sample:

```csharp
public Transform GetNextWaypoint(Transform current) {
    // Return next waypoint in path
}
```

This ensures **predictable but flexible patrol logic** that players can observe and learn from.

---

### 7.6 🔮 Future AI Extensions (Flee, Search, Idle)

Although the current implementation includes Patrol and Attack, the **state machine design is extensible** and can support:

- **SearchState:** For when an enemy loses sight but tries to re-acquire the player.
    
- **FleeState:** For low-health or weak enemies that retreat.
    
- **IdleState:** For guarding or stationary enemy types.
    
- **Aggro Chains:** Alerting nearby enemies upon detection or damage.
    

With only 3 weeks of development time, these were not fully realized, but the structure is ready to support them in future iterations.

---

## 8. 🧩 Modular Interaction System

The interaction system in _Eldorian Legends_ was designed to be **modular, event-driven, and extendable**, supporting a wide variety of object interactions through inheritance and UnityEvents. Whether collecting items, unlocking doors, triggering animations, or playing sounds, the same unified system powers it all — keeping the code clean and allowing for rapid expansion.

---

### 8.1 🧱 `Interactable.cs`: Base Class Overview

At the heart of the interaction system is the **`Interactable.cs`** abstract class, which all interactive objects inherit from.

Key elements include:

- A virtual `Interact()` method that can be overridden.
    
- A reference to the interaction prompt text.
    
- A `UnityEvent onInteract` that can be hooked via the Unity Editor.
    

This base class ensures that **any object** can become interactable with minimal setup.

```csharp
public virtual void Interact() {
    onInteract.Invoke();
}
```

---

### 8.2 ⚙️ UnityEvents and Event-based Architecture

All interaction logic is driven through **UnityEvents**, allowing designers to define behavior **without modifying code**:

- Set up triggers via the Inspector.
    
- Assign animations, sounds, or effects to play on interact.
    
- Greatly improves modularity and visual workflow.
    

This approach allows multiple actions to be triggered from one interaction and supports layering effects like animation + sound + logic.

---

### 8.3 🧪 Interactable Implementations

A wide variety of in-game interactables were implemented using the base class, demonstrating the flexibility of the system.

#### 8.3.1 🎁 `CollectCube.cs` – Collectibles

- Triggers when the player interacts (or collides).
    
- Increments a collectible counter and removes the object from the scene.
    
- Used for potion items, keys, or hidden pickups.
    

#### 8.3.2 🔢 `Keypad.cs` – Door Triggers

- Requires a specific player action to activate.
    
- Triggers door-opening animations or scene transitions.
    
- Used for puzzles and final scene unlock mechanisms.
    

#### 8.3.3 🎲 `AnimateCube.cs`, `ChangeColourCube.cs` – Puzzle Triggers

- Play object animations or change properties (like color) when interacted with.
    
- Used in the cemetery and fortress scenes for environment manipulation.
    

#### 8.3.4 🎵 `PotionSound.cs` – Audio-Driven Items

- Plays audio upon interaction.
    
- Often combined with `CollectCube` for healing potions and ambiance objects.
    

Each of these inherits from `Interactable.cs`, overriding `Interact()` when necessary or using `onInteract` directly for simple logic.

---

### 8.4 🤝 Player Interaction Flow (`PlayerInteract.cs`)

The `PlayerInteract.cs` script handles the **detection and execution** of interactions:

- Casts a **ray from the center of the camera** every frame.
    
- If an `Interactable` is found, displays a prompt.
    
- On pressing the interact key (E), calls `Interact()` on the object.
    

This allows for dynamic, frame-accurate detection of interactables in front of the player, without using triggers or colliders.

```csharp
if (Physics.Raycast(ray, out hit, range)) {
    var interactable = hit.transform.GetComponent<Interactable>();
    if (interactable != null) {
        interactable.Interact();
    }
}
```

---

### 8.5 🖥️ UI Prompt System and Raycast Logic

When an interactable is detected, a **contextual prompt** (e.g., “Press E to interact”) appears:

- Managed via `PlayerUI.cs`.
    
- Only shown when a valid object is hit by the ray.
    
- Updates dynamically each frame.
    

The prompt fades in/out based on raycast hit status, improving immersion while keeping the UI minimal and responsive.

---

## 9. 💥 Traps, Hazards & Environment

The environmental systems in _Eldorian Legends_ go beyond aesthetic design — they actively contribute to gameplay through hazards, ambiance, and terrain-driven gameplay flow. From deadly traps to handcrafted terrain and lighting, this section explores the systems that bring the world of Eldoria to life.

---

### 9.1 ⚠️ Trap Mechanics: `TrapBoxScript.cs` and `TrapScript.cs`

Traps play a critical role in increasing the tension and danger in specific regions (like the Fortress and Cemetery).

#### `TrapBoxScript.cs`

- A simple mechanism that **activates a trap zone** on collision.
    
- Detects the player via `OnTriggerEnter` and calls `PlayerHealth.TakeDamage()`.
    

#### `TrapScript.cs`

- A general-purpose script for any hazard object.
    
- Can damage the player, play animations (e.g., spikes rising), or trigger sounds.
    
- Often paired with animation and/or physics-based triggers for realism.
    

**Example:**

```csharp
if (other.CompareTag("Player")) {
    playerHealth.TakeDamage(damage);
}
```

This system encourages players to be alert and rewards careful exploration, especially in darker, trap-filled zones.

---

### 9.2 🧲 Rigidbody Physics Triggers

Some traps and interactables use **Rigidbody components** and physics forces:

- Triggered by pressure plates or hidden levers.
    
- Can knock the player back or activate complex chain reactions.
    
- Physics events are synced with Unity Events for layered behavior.
    

Used sparingly to avoid chaos but effectively to surprise and challenge the player.

---

### 9.3 🌄 Terrain Design and Custom Level Art

The entire terrain for all three scenes was **built manually** using Unity’s Terrain Tools, including:

- Hand-sculpted elevations and valleys.
    
- Custom texture painting for realism (grass, rock, dirt).
    
- Foliage painting with detail meshes and tree placement.
    

Each area was designed with gameplay in mind:

- **Scene 1**: Open, forested with natural obstacles.
    
- **Scene 2**: Dense, moody terrain with uneven ground.
    
- **Scene 3**: Structured layouts with elevation for strategic advantage.
    

The terrain also integrates **NavMesh baking** for enemy pathfinding.

---

### 9.4 💡 Realistic Mapping and Lighting Effects

To heighten immersion:

- **Realtime and baked lighting** was used to control ambiance.
    
- **Post-processing effects** like bloom, vignette, and color grading enhance mood.
    
- **Directional lights** simulate sun and moon positions in different scenes.
    
- **Volumetric fog and darkness** are used in Scene 2 for a spooky, oppressive feel.
    

Torch-based lighting and moving shadows add tension, especially in tight corridors or trap-filled areas.

---

### 9.5 📐 Procedural Experiments: `Voronoi.cs` and `VoronoiGenerator.cs`

Though not deployed in the final build, a **procedural generation experiment** using Voronoi logic was implemented.

- **`Voronoi.cs`**: Handles generation of Voronoi points and diagram construction.
    
- **`VoronoiGenerator.cs`**: Uses the above to build dynamic patterns for level design.
    

This system was meant to explore the idea of procedural landscapes or dungeon generation, though ultimately the team prioritized handcrafted terrain due to time constraints.

Still, the system stands as a powerful future extension opportunity and technical proof-of-concept.


---

## 10. 🌐 Scene Management & Progression

Scene transitions and global progression are critical to maintaining pacing, flow, and narrative structure in _Eldorian Legends_. This section covers how the game manages scenes based on player actions and global states, from combat completion to menu navigation.

---

### 10.1 🔁 Scene Transitions Based on Kill Count

One of the core progression mechanics is the **enemy kill count**, used to trigger the transition to the next scene.

- Implemented via a central variable tracking how many enemies have been defeated.
    
- Once the required number is reached, a portal (or interaction trigger) becomes active.
    
- This keeps players engaged with combat while tying gameplay directly to narrative progression.
    

Code Example from `Enemy.cs`:

```csharp
GameManager.instance.IncreaseKillCount();
if (GameManager.instance.killCount >= requiredKills) {
    // Activate next level trigger
}
```

This ensures players must **clear objectives** to continue, enhancing pacing and difficulty ramping.

---

### 10.2 🧠 `GameManager.cs`: Global State Management

The **`GameManager.cs`** script acts as a singleton controller to maintain global state across scenes.

Responsibilities include:

- Tracking kill counts
    
- Managing game state (e.g., isGameOver)
    
- Centralized control of key gameplay variables
    
- Acting as a hub for other systems to communicate safely
    

It follows the Singleton pattern:

```csharp
public static GameManager instance;

void Awake() {
    if (instance == null) {
        instance = this;
        DontDestroyOnLoad(gameObject);
    } else {
        Destroy(gameObject);
    }
}
```

This design ensures continuity of state between scenes and avoids duplication of critical logic.

---

### 10.3 🎯 Level Objectives and Progression Logic

Each scene has **clear objectives** implemented through environmental and enemy-based conditions:

- **Scene 1:** Survive waves and defeat enemies to unlock the cemetery.
    
- **Scene 2:** Solve puzzle interactions while surviving ambushes.
    
- **Scene 3:** Defeat the boss enemy and access the exit portal.
    

Progression is modular and driven by scripts like:

- `NextLevelScript.cs` / `NextLevelScript2.cs`: For unlocking portals
    
- `Keypad.cs`: To gate progression until certain actions are taken
    

These transitions are **tied to player feedback**, such as effects, sounds, and UI prompts, ensuring a cohesive experience.

---

### 10.4 🧭 Menu System (`MenuScript.cs`) and Scene Controls

The **menu system** includes:

- Start screen with scene loading
    
- Quit option
    
- Reset game state logic
    

Script: `MenuScript.cs`

Features:

- Uses `SceneManager.LoadScene()` to load selected levels.
    
- Ensures player input is blocked during transitions.
    
- Can trigger fade effects for smooth changes.
    

```csharp
public void PlayGame() {
    SceneManager.LoadScene(sceneIndex);
}
```

Though simple, it ensures players are introduced properly into the game world and gives control over restarting or exiting.

---

Together, these systems form the **spine of progression and control** in _Eldorian Legends_, guiding the player from one challenge to the next while managing state across an immersive multi-scene experience.


---

## 11. 📊 UI and Feedback Systems

User interface (UI) and player feedback mechanisms are central to immersion and clarity in _Eldorian Legends_. Every interaction, damage event, or level transition is paired with responsive visual or audio cues to keep the player informed, alert, and engaged.

---

### 11.1 🧠 HUD Design (`PlayerUI.cs`, `FadeEffect.cs`)

The **HUD (Heads-Up Display)** was designed to be minimal, functional, and reactive.

#### `PlayerUI.cs`

- Displays current health, kill count, and contextual prompts.
    
- Handles showing/hiding messages like:
    
    - “Press E to interact”
        
    - “You Died”
        
    - “You Win!”
        

#### `FadeEffect.cs`

- Handles full-screen fade transitions using a Canvas Group.
    
- Smoothly fades in/out between scenes, during death, or cutscenes.
    

This creates a polished experience where visual transitions don't feel abrupt or jarring.

---

### 11.2 ❤️ Health Bars, Win Conditions, and Game Over Text

- The **health bar** is clamped using `Mathf.Clamp` and updates in real-time via `PlayerHealth.cs`.
    
- When health drops to 0:
    
    - A Game Over message is shown.
        
    - Inputs are disabled.
        
    - Optional scene reload or quit becomes available.
        

Victory is handled similarly — upon defeating all required enemies, a **“You Win”** message is displayed with transition options.

---

### 11.3 💬 Interaction Prompts and Dynamic Text

Interaction prompts are dynamically generated based on raycasts (`PlayerInteract.cs`):

- When looking at an interactable object, a message like “Press E to Collect” appears.
    
- Prompts are updated every frame based on player direction and proximity.
    

This ensures:

- **Zero unnecessary clutter** on screen.
    
- **Intuitive interaction** without tutorials.
    
- **Immersion maintained** even during complex puzzles.
    

---

### 11.4 🔊 Audio Feedback Integration

Audio was integrated for both ambiance and event feedback:

- Triggered through UnityEvents or directly in scripts like `PotionSound.cs`.
    
- Used for:
    
    - Collectibles
        
    - Trap activation
        
    - Gunshots and enemy death
        
    - Player damage and healing
        

Each sound enhances immersion and serves as **non-verbal feedback**, reinforcing player decisions and game state changes.

---

Together, these systems build a **reactive and immersive interface**, ensuring that the player always knows:

- What’s happening
    
- What they need to do
    
- How their actions affect the world
    

---

## 12. 🎨 Design Choices and Aesthetics

Beyond gameplay mechanics and systems, _Eldorian Legends: Survival of The Fated_ places a strong emphasis on mood, atmosphere, and world coherence. Every visual, auditory, and experiential element was deliberately crafted to evoke mystery, tension, and a sense of discovery.

---

### 12.1 🌌 Visual Themes and Worldbuilding

The game's visual identity is rooted in fantasy-survival with a subtle post-mythological tone.

- **Scene 1 (The Forest):** Soft greens, dense foliage, scattered ruins. Designed to feel natural yet uncanny.
    
- **Scene 2 (The Cemetery):** Faded greys, broken stones, and moonlit darkness. Inspired by horror motifs.
    
- **Scene 3 (The Fortress):** Harsh lines, firelight, and deep shadows create a militarized final zone.
    

**Terrain painting**, hand-placed **props and assets**, and **skybox variations** reinforce the emotional arc of the player's journey — from lost, to fearful, to empowered.

---

### 12.2 🎞️ Animation Implementation and Transitions

Animations were used across:

- **Enemies:** Patrol, alert, attack, and death states all have unique transitions.
    
- **Player Controller:** Jumping and walking animations blend based on movement state.
    
- **Environment:** Moving objects (like traps or interactive cubes) use Animator components for fluid motion.
    

Transitions are synchronized with game state using:

- `Animator.SetTrigger()` or `SetBool()`
    
- State machine triggers (especially in AI logic)
    
- UnityEvents for modular syncing with gameplay actions
    

This approach ensures smooth, immersive transitions that feel responsive to the player.

---

### 12.3 🎧 Sound Design and Environmental Ambience

Audio design was aimed at enhancing immersion and emotional tone:

- Ambient sounds: wind, forest rustling, haunted moans, distant thunder.
    
- SFX: used in **interactions, attacks, damage, pickups, keypad use**, and more.
    
- Enemy growls and screams are tied to AI states (e.g., attack or alert).
    

SFX were timed intentionally — often with slight delays or echo — to simulate real-world acoustics and suspense.

---

### 12.4 🔦 Immersion Techniques (FOV, lighting, interaction timing)

A variety of subtle enhancements were employed to deepen player immersion:

- **Field of View (FOV):** Calibrated for FPS immersion without exaggeration.
    
- **Lighting:** Realtime + baked lighting mixes, including torch flicker, fog volumes, and day/night transitions.
    
- **Interaction Timing:** Raycast checks were fine-tuned to avoid jitter. Prompt delays reduce UI noise.
    
- **Feedback Delay:** Fade effects and audio pacing ensure the player has time to feel outcomes (e.g., trap hits, kills, portal opens).
    

Together, these techniques keep players anchored in the world of Eldoria, making every moment feel deliberate and cinematic.


---

## 13. 🛠️ Tools, Architecture & Best Practices

The success of _Eldorian Legends_ depended not only on gameplay features but also on how well the project was structured under the hood. From reusable code to smart debugging tools and performance tuning, this section explores the engineering choices that supported rapid development in a limited timeframe.

---

### 13.1 🗂️ Script Organization and Structure

All scripts were categorized into clearly defined folders based on function:

- `Player/` – Movement, camera, UI, input handling
    
- `Enemy/` – AI logic, state machine, bullets
    
- `Interaction/` – Interactable objects, raycasting logic
    
- `Traps/` – Environmental hazards
    
- `UI/` – Health display, messages, scene transitions
    
- `Managers/` – GameManager, Menu scripts, fade effects
    
- `Misc/` – Experimental systems like Voronoi generation
    

This structure ensured clarity when debugging or extending systems, especially in a team setup.

---

### 13.2 🔁 Code Reusability and Extensibility

Many systems were built with **inheritance** and **event-driven architecture** for scalability:

- `Interactable.cs` is the base class for all interactables — reused by objects like keys, potions, cubes, and doors.
    
- The custom **State Machine** architecture supports plug-and-play states (e.g., `AttackState`, `PatrolState`, future states like `SearchState`).
    
- The UnityEvent system decouples logic from implementation, allowing non-coders to attach new interactions in the Editor.
    

This future-proofs the codebase and allows rapid prototyping of new ideas.

---

### 13.3 🐛 Debugging and Editor Scripts (`Path.cs`)

#### `Path.cs`

- This script is used to define **waypoints for enemy patrols**.
    
- Includes editor gizmos to visually display patrol paths.
    
- Useful for both **debugging AI logic** and rapid scene design.
    

**Why it matters:**

- Debugging AI movement without visuals is time-consuming.
    
- Custom gizmos speed up testing and balance work.
    

Additionally, standard practices like log messages, `Debug.DrawRay()`, and consistent naming conventions supported efficient troubleshooting.

---

### 13.4 🚀 Performance Considerations and Optimization

Despite the rich environment and systems, care was taken to maintain smooth framerates:

- **Culling:** All heavy objects and enemies were placed in separate layers with camera culling masks and LODs.
    
- **Pooling:** Reused objects like bullets and enemy corpses to avoid instantiating during runtime.
    
- **Raycasting:** Kept short and targeted (interactions only cast within a few meters).
    
- **Scene Loading:** Optimized by preloading critical components and avoiding large scene-wide updates.
    

Even under real-time lighting and physics-driven environments, the game maintains stable performance on most systems tested.


These engineering choices enabled _Eldorian Legends_ to go from concept to polished prototype in under three weeks — while staying clean, efficient, and ready for future development.


---

## 14. 🧪 Testing & QA

With only three weeks to deliver a complete FPS experience — while working full-time jobs and finishing a demanding academic semester — **testing** had to be lean, continuous, and purposeful. This section outlines how we validated functionality, managed quality, and prioritized what to fix or leave behind.

---

### 14.1 🕹️ Playtesting Feedback

Playtesting was conducted iteratively — often daily — across:

- Our personal development machines
    
- Multiple Unity Editor play sessions
    
- Final builds exported for friends and peers
    

#### Key insights from feedback:

- Players enjoyed the **interaction variety** (potions, puzzles, enemies).
    
- The **AI patrol and detection** felt responsive and unpredictable in a good way.
    
- Jumping felt a bit too floaty early on — we adjusted gravity and mass accordingly.
    
- Players occasionally missed interaction prompts — prompting a more visible UI change.
    

All feedback was documented in a shared spreadsheet and used to guide polish during the last few development days.

---

### 14.2 🚧 Edge Case Handling

We proactively tested edge cases like:

- Interacting with objects at awkward angles or through walls → **Fixed with raycast distance and layer filtering**
    
- Player reaching kill count without triggering portal → **Solved by enforcing order of operations in `GameManager.cs`**
    
- AI stuck on geometry during patrols → **Fixed with `NavMeshAgent` tweaks and collider review**
    
- Clicking too fast on doors or keypads → **Debounced interactions with a small cooldown**
    

This ensured a smoother experience, especially in non-ideal inputs or chaotic gameplay states.

---

### 14.3 🐞 Bugs Encountered and Fixes Applied

Some major bugs we addressed:

|Bug|Fix|
|---|---|
|Bullet hitting enemies but not registering damage|Raycast distance was too short; extended it and improved hit detection|
|Player falling through terrain|Terrain collider wasn't properly applied — fixed by rebaking navigation mesh|
|Sound not playing on certain pickups|AudioSource missing or not properly attached — standardized prefab structure|
|“You Died” appearing incorrectly|Added proper flag checks before displaying UI|
|Enemies spawning on top of each other|Manually spaced enemy spawn points and added small random offsets|

All critical bugs were resolved before final submission.

---

### 14.4 ⚖️ Missing Requirements and Rationale

Despite covering nearly every course requirement (and more), some smaller features were intentionally not implemented:

|Missing|Reason|
|---|---|
|Multiplayer|Out of scope and not required|
|Saving/Loading Game State|No time; would require persistence logic|
|Full settings menu|Basic menu was sufficient for gameplay loop|

Instead, we **focused on polish**, AI depth, and interaction richness — areas where we could provide value beyond the minimal grade requirements.

---

## 15. 🎞️ Trailer, GDD & Submission Materials

In addition to the working game build and comprehensive documentation, _Eldorian Legends: Survival of The Fated_ was submitted with a full creative and technical package to fulfill all course deliverables — including a gameplay trailer, a detailed Game Design Document (GDD), and organized submission materials.

---

### 15.1 🎬 Game Trailer and Highlights

A short gameplay **trailer** was created to showcase:

- First-person movement through handcrafted environments
    
- AI patrol and attack sequences
    
- Interaction with puzzles, potions, and keys
    
- Environmental hazards and traps
    
- Scene transitions, visual effects, and UI overlays
    

The trailer was edited to emphasize **gameplay clarity** over cinematic flair, demonstrating core mechanics in action and aligning with grading criteria.

Highlights include:

- Forest combat ambushes
    
- Cemetery atmosphere and torchlight traversal
    
- Final fortress confrontation with multiple enemies
    

This trailer serves as both a presentation tool and a record of the game's core experience.

---

### 15.2 📘 Final Game Design Document Summary

The **GDD (Game Design Document)** titled _“Eldorian Legends – Survival of The Fated”_ includes:

- Genre and gameplay overview
    
- Core narrative and backstory
    
- World and level design breakdown
    
- Mechanics: combat, AI, interactions, traps, and puzzles
    
- UI mockups and visual references
    
- Technical implementation strategy
    

The GDD was consistently updated during development and reflects both the **original design vision** and the **actual implemented experience**, showing a clear evolution of the game concept.

---

### 15.3 📦 Submission Package Checklist

Our final submission included the following:

|Deliverable|Status|
|---|---|
|✅ Final Unity Project Folder|Included and verified|
|✅ Compiled Game Build (PC)|Tested and included|
|✅ Game Trailer|Uploaded with video link|
|✅ GDD PDF|Fully written and formatted|
|✅ Project Report (DOCX)|Aligned with course template|
|✅ All C# Scripts|Structured, commented, and attached|
|✅ Screenshots and Visuals|Used in report and trailer|
|✅ Extra Materials (Voronoi, AI Experiments)|Packaged with source|

Everything was organized into a single compressed submission folder with clear structure, naming conventions, and an index for the reviewer.

---

## 16. 🧠 Reflections & Lessons Learned

Looking back on the three intense weeks of building _Eldorian Legends: Survival of The Fated_, we gained far more than a finished product. This project challenged us to rapidly apply our technical knowledge, push creative limits, collaborate under pressure, and make tough decisions — all while balancing full-time work and academic responsibilities.

---

### 16.1 🛠️ Technical Skills Acquired

Over the course of the project, we deepened and expanded our technical toolbox:

- ✅ Built a **modular first-person controller** using Unity’s new Input System
    
- ✅ Developed a **custom enemy state machine** with real AI behaviors
    
- ✅ Implemented **interactions via inheritance and UnityEvents**
    
- ✅ Created a responsive **UI system** tied to player health, objectives, and prompts
    
- ✅ Used **mathematical logic** to handle gravity, clamping, and health management
    
- ✅ Applied **raycasting** across combat, interactions, and AI vision
    
- ✅ Integrated sound, animation, and lighting to enhance immersion
    
- ✅ Experimented with procedural content (e.g., Voronoi terrain logic)
    

This wasn’t just about finishing a project — it was about transforming ideas into systems and learning by doing.

---

### 16.2 🤝 Design & Collaboration Insights

Working together taught us valuable lessons in planning and teamwork:

- We **divided responsibilities** smartly — player systems vs. AI vs. design tasks — and kept communication constant.
    
- We **iterated quickly**, testing after every feature and adjusting when needed.
    
- Our **GDD acted as a source of truth**, helping align ideas with actual implementation.
    
- We learned that **great gameplay** comes from refinement and polish — not just features.
    

Despite the time pressure, we were able to collaborate efficiently by relying on shared goals, mutual accountability, and respect for each other’s skillsets.

---

### 16.3 🔄 Future Improvements and Next Steps

If we had more time (or continue post-submission), we’d like to expand:

- ✅ **More enemy types** (e.g., ranged attackers, stealth units)
    
- ✅ **Search state** and smarter AI reactions to lost targets
    
- ✅ **Inventory system** with item pickups and usage
    
- ✅ **Save/load system** for checkpoint progression
    
- ✅ **Advanced puzzles** and interactive objects
    
- ✅ **Voice acting and lore elements** to deepen the narrative
    

The foundation we’ve built is scalable — we can easily plug in new mechanics or content in the future.

---

### 16.4 💡 Advice to Other Developers

To anyone starting a similar project:

- **Plan early.** A clear GDD, even if simple, makes decisions easier later.
    
- **Keep systems modular.** Your future self will thank you when fixing or expanding.
    
- **Test constantly.** Don’t wait until the end — bugs compound quickly.
    
- **Polish what matters.** A few well-executed features feel better than many broken ones.
    
- **Have fun.** Passion shows in your game. Don’t let stress override creativity.
    

This project reminded us why we love game development — it’s not just code or assets, but storytelling through systems.

---

## 17. 📁 Appendix

This appendix includes reference material, technical diagrams, and developer annotations to help reviewers or future developers better understand the internal workings of _Eldorian Legends: Survival of The Fated_. It is designed as a behind-the-scenes companion to the core documentation.

---

### 17.1 📜 Main Scripts Index

All custom scripts developed and submitted with the project, organized by category:

#### 🔹 Player Scripts

- `PlayerMotor.cs`
    
- `PlayerLook.cs`
    
- `PlayerHealth.cs`
    
- `PlayerUI.cs`
    
- `PlayerInteract.cs`
    
- `InputManager.cs`
    
- `NewBehaviourScript.cs` _(deprecated/test)_
    

#### 🔹 Interaction System

- `Interactable.cs` _(Base class)_
    
- `EventsOnlyInteractable.cs`
    
- `InteractionEvent.cs`
    
- `CollectCube.cs`
    
- `Keypad.cs`
    
- `AnimateCube.cs`
    
- `ChangeColourCube.cs`
    
- `PotionSound.cs`
    

#### 🔹 Combat and Enemies

- `Bullet.cs`
    
- `Enemy.cs`
    
- `StateMachine.cs`
    
- `BaseState.cs`
    
- `PatrolState.cs`
    
- `AttackState.cs`
    
- `Path.cs`
    

#### 🔹 UI & Menu

- `FadeEffect.cs`
    
- `MenuScript.cs`
    

#### 🔹 Environment & Traps

- `TrapScript.cs`
    
- `TrapBoxScript.cs`
    
- `Voronoi.cs`
    
- `VoronoiGenerator.cs`
    

#### 🔹 Scene Management

- `GameManager.cs`
    
- `NextLevelScript.cs`
    
- `NextLevelScript2.cs`
    

---

### 17.2 🧩 Class Relationships and Diagrams

**Interaction System UML Sketch:**

```
Interactable (abstract)
│
├── EventsOnlyInteractable
├── CollectCube
├── Keypad
├── AnimateCube
├── ChangeColourCube
└── PotionSound
```

**Enemy AI State Machine Flow:**

```
StateMachine
   │
   ├── PatrolState
   │       ↓
   ├── AttackState
   │       ↓
   └── (Future: SearchState, IdleState)
```

**Player System Overview:**

- `PlayerMotor` ← handles movement physics
    
- `PlayerLook` ← handles mouse input
    
- `PlayerHealth` + `PlayerUI` ← manage feedback and health bar
    
- `PlayerInteract` ← handles raycasting and interaction detection
    

---

### 17.3 🧠 Code Snippets and Explanations

**1. Damage Clamp Logic:**

```csharp
currentHealth = Mathf.Clamp(currentHealth - damageAmount, 0, maxHealth);
```

Used to prevent health from going below 0 or above max.

**2. AI Raycasting for Player Detection:**

```csharp
RaycastHit hit;
if (Physics.Raycast(transform.position, directionToPlayer, out hit, viewRange)) {
    if (hit.collider.CompareTag("Player")) {
        // Engage attack state
    }
}
```

**3. Scene Transition Trigger:**

```csharp
if (killCount >= requiredKills) {
    SceneManager.LoadScene(nextSceneIndex);
}
```

---

### 17.4 📝 Known Issues and Developer Notes

|Issue|Status|Notes|
|---|---|---|
|Occasional AI stutter when changing states|Minor|Happens on rapid player movement; may be resolved with NavMesh smoothing|
|Player interaction prompt disappears mid-animation|Visual glitch|Only occurs if interacting during scene fade transitions|
|Unused legacy script (`NewBehaviourScript.cs`)|Safe to delete|Was used for early movement testing|
|No save/load support|Expected|Could be added with `PlayerPrefs` or JSON-based save manager|
|No mobile/console support|Out of scope|PC build only for final submission|


---

## 18. 🏁 Conclusion

_Eldorian Legends: Survival of The Fated_ was more than just a final assignment — it was a rapid, immersive, and demanding development journey. In only three weeks, while working full-time jobs and handling one of the busiest academic semesters, we managed to conceptualize, design, and develop a complete first-person survival experience with custom systems, unique aesthetics, and meaningful gameplay.

We started with a vision: to build a mysterious world that challenges the player to survive, explore, and fight for answers. Through consistent collaboration and creative problem-solving, that vision became a reality. Every script, interaction, trap, enemy, and terrain detail was a piece of a larger puzzle — and assembling it under pressure taught us more than any tutorial or classroom ever could.

This game showcases:

- Technical mastery of Unity and C#
    
- Game architecture and modularity
    
- Effective UI/UX and feedback design
    
- A working AI system with behavior transitions
    
- Custom character control, interaction, and physics
    
- Artistic design, mapping, and environmental storytelling
    

But most of all, it represents what’s possible when passion meets focus.

We hope that our work inspires others to build their own worlds, explore new ideas, and never shy away from pushing their creative limits — even when time is short and the challenge feels overwhelming.

Thank you for taking the time to explore _Eldorian Legends_ with us.

See you in the next game.

— Chen Shiri & Itay David  
**2024 | Game Development Final Project** 🎮
