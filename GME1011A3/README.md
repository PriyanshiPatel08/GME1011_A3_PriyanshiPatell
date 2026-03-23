# GME1011A3 - Hero Inheritance Battle

## What This Project Is
A turn-based console battle game built in C# that demonstrates object-oriented programming concepts like inheritance and polymorphism.

A hero fights their way through a list of randomly generated enemies. Each enemy type has its own special attack and unique behaviour.

---

## How to Run It
1. Open `GME1011A3.sln` in Visual Studio
2. Press `Ctrl + Shift + B` to build
3. Press `Ctrl + F5` to run
4. Enter your hero's name, health, strength, and number of enemies when prompted
5. Watch the battle play out!

---

## Class Structure

### Heroes
- `Hero` — base class with health, name, basic attack and heal
- `Fighter` — has strength, can go Berserk for big damage
- `Healer` — lower health cap, can heal party members
- `Magician` — low health, can cast Lightning Strike

### Minions
- `Minion` — base class with health and armour
- `Goblin` — has dexterity, can dodge attacks, bites for special
- `Skellie` — takes half damage, rattles for special attack
- `Vampire` — takes reduced damage, drains health from hero and heals itself

---

## What I Changed from the Starter Project

- **Task 1** — Added user input for hero name, health, strength and number of enemies
- **Task 2** — Changed `List<Goblin>` to `List<Minion>` to make it polymorphic
- **Task 3** — Added 33/33/33 chance for Goblin, Skellie, or Vampire to spawn
- **Task 4** — Hero now has 33% chance to use Berserk special attack
- **Task 5** — Minions use their special attacks polymorphically using the `is` keyword
- **Task 6** — Created Vampire as a custom Minion subclass with BloodDrain special

---

## Notes
- Warnings about net6.0 being out of support are harmless, game runs fine
- Vampire heals itself when it uses BloodDrain, making it the toughest enemy
- Hero gets a small health boost after each kill to keep the battle interesting
