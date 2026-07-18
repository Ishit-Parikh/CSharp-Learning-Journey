# C# Masterclass — Learning Journey

**Course:** [Complete C# Masterclass](https://www.udemy.com/share/1013Gg/) by Denis Panjuta  
**Duration:** 46h 12m · 484 lectures · 28 sections  
**Repo:** Code + notes from every section.

---

## Progress

- [x] **Section 1** — Introduction, DataTypes & Variables
- [x] **Section 2** — Making Decisions
- [x] **Section 3** — Loops
- [x] **Section 4** — Functions and Methods
- [x] **Section 5** — Object Oriented Programming (OOP)
- [ ] **Section 6** — Collections
- [ ] **Section 7** — Error Handling
- [ ] **Section 8** — Inheritance
- [ ] **Section 9** — Interfaces and Polymorphism
- [ ] **Section 10** — Structs
- [ ] **Section 11** — Events and Delegates
- [ ] **Section 12** — Regular Expressions
- [ ] **Section 13** — WPF: Windows Presentation Foundation
- [ ] **Section 14** — WPF Project: Currency Converter (Part 1)
- [ ] **Section 15** — Using Databases With C#
- [ ] **Section 16** — WPF Project: Currency Converter (Part 2)
- [ ] **Section 17** — LINQ
- [ ] **Section 18** — WPF Project: Currency Converter with API (Part 3)
- [ ] **Section 19** — Coding Interview Exercises
- [ ] **Section 20** — C# Clean Code
- [ ] **Section 21** — C# Generics
- [ ] **Section 22** — Threads
- [ ] **Section 23** — Unit Testing / TDD
- [ ] **Section 24** — Unity Basics
- [ ] **Section 25** — Unity: Pong
- [ ] **Section 26** — Unity: Zig Zag Clone
- [ ] **Section 27** — Unity: Fruit Ninja Clone
- [ ] **Section 28** — Thank You & Next Steps

---

## Notes

### Section 1 — Introduction, DataTypes & Variables

- Visual Studio Community setup, Hello World
- Comments, top-level statements, `using` directives
- Variables: `string`, `int`, `double`, `char`, `bool`
- Value types vs reference types
- Type conversion: implicit, explicit (`Parse`, `Convert`)
- `var` keyword (implicitly typed)
- Operators, order of evaluation, math
- Debugging: breakpoints, runtime vs compile-time errors
- String manipulation, formatting, indexing, escape sequences
- Char and UTF-16 (emojis)
- Mini project: Addition Calculator

### Section 2 — Making Decisions

- Logical operators (AND, OR, NOT), bool datatype
- If, else, else-if, nested if
- Relational operators (==, !=, <, >, <=, >=)
- Switch statements, when to pick switch vs if
- One-line if (ternary-style)
- String methods: Trim, ToLower (input sanitization)
- Increment/decrement (++/--), modulo operator
- TryParse for safe numeric conversion
- Random class for generating random numbers
- Mini project: Quiz app, conditional calculator

### Section 3 — Loops

- For loop: syntax, init, condition, iterator
- While loop: counter and condition-based iteration
- Do-while (guaranteed one execution)
- Break and continue statements
- Arrays: declaration, indexing, length, inline init
- Foreach loop
- Multi-dimensional arrays (2D, 3D), jagged arrays
- Escape characters (\r, \n), Thread.Sleep
- Challenges: Rocket Landing, Guess the Number, text adventure, Average Calculator

### Section 4 — Functions and Methods

- Void methods: no params, single param, multiple params
- Parameter modifiers: ref, out, in
- Argument promotion (automatic type widening)
- Top-level statements → classical Program class template
- Fields: instance vs local variables
- Expression-bodied members (=> syntax)
- Recursion (methods calling themselves)
- Mini project: WeatherSimulator (arrays, Random, for loops)

### Section 5 — Object Oriented Programming (OOP)

- Classes vs objects, creating custom classes
- Member variables, custom constructors, constructor overloading
- Auto-generated properties, custom get/set logic
- Computed properties, read-only / write-only properties
- Static methods and fields
- Expression-bodied members, nested/partial classes
- Optional and named parameters
- Operator overloading, pass by value vs by reference
- Access modifiers: public, private, const vs readonly
- `is` and `as` operators (type checking)
- ID Key pattern, the `this` keyword
- Mini project: Quiz App (Question class, scoring, console colors)

---

## Running the Code

Each section is its own console project. Run a section with:

```bash
dotnet run --project section-XX-name
```

### Examples

```bash
dotnet run --project section-01-intro
dotnet run --project section-02-decisions
```

Or build everything at once:

```bash
dotnet build
```

## Structure

```
section-01-intro/         # Section 1 project
section-02-decisions/     # Section 2 project
...
```

Each folder is a separate .NET console project.
