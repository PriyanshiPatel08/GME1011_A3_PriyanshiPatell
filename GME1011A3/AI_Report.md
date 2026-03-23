# AI Use Report - GME1011A3

## How I Used It

I used Claude to help me in two specific ways during this assignment.

### 1. Analysing My Code for Errors
After writing my changes to Program.cs I was getting a build error in
SneakyMinion.cs that I couldn't figure out. I pasted the error message into
Claude and it explained that the constructor was passing a string argument
where Minion's base constructor expected an int. It pointed me to the exact
line so I could fix it myself.

I also used it to double check that my Vampire class constructor was calling
base() correctly with the right argument types before I tried to build.

### 2. Help Structuring the Polymorphism Section
Task 5 was the trickiest part for me. I understood the concept of polymorphism
but wasn't sure of the exact C# syntax for checking what type a Minion was at
runtime. I asked Claude to explain how the `is` keyword works with pattern
matching in C#. It gave me a simple example and I used that understanding to
write my own if/else block in Program.cs that checks for Goblin, Skellie, and
Vampire and calls the right special attack for each.

---

## What I Did On My Own
- Came up with the Vampire idea and designed its BloodDrain mechanic myself
- Wrote all the logic in Program.cs for Tasks 1 through 6
- Structured all the if/else blocks and the battle loop myself
- Tested and debugged the game by running it multiple times
- Made all the commits and connected the project to GitHub myself

---

## How Helpful Was It
Claude was helpful for understanding syntax I wasn't sure about and for
quickly identifying what was causing a build error. It saved me time that
I would have spent searching through documentation. However the actual
thinking, design decisions, and coding were all done by me. I used it the
same way I would use a textbook or ask a classmate for a quick explanation.

---

