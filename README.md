# Paper Rock Scissor HOT Assessment (.NET)

[![CI](https://github.com/cuvaalex/HOT_PaperScisorGame/blob/main/.github/workflows/ci.yaml/badge.svg?branch=main)](https://github.com/cuvaalex/HOT_PaperScisorGame/blob/main/.github/workflows/ci.yaml)

## Project Request
### User Story Front

 	Title: Waste an Hour Having Fun

 As a frequent games player,
 I'd like to play rock, paper, scissors
 so that I can spend an hour of my day having fun

 Acceptance Criteria
  - I can play Player vs Computer
  - I can play Computer vs Computer
  - I can play a different game each time

User Story Back

 Technical Constraints

 - Doesn't necessarily need a flashy GUI (can be simple)
 - Use Java or any other object-oriented language
 - Libs / external modules should only be used for tests
 - Using agile engineering practices

Don't know the game? http://en.wikipedia.org/wiki/Rock-paper-scissors

**Guidance**

* We wouldn't ask anyone to do a coding puzzle that we haven't done ourselves, so the people looking at your code understand the problem we're asking to be solved.  As an indicator, it should take about 5 hours to complete the work, depending on how flashy your UI is.
* We’re not too bothered with the UI; it is a nice to have though
* Do you test your code? As this is a test engineering position, this is the area where most of our focus will be on
* We are keen to see how much you think is enough and how much would go into a Minimum Viable Product. As a guide, elegant and simple wins over feature-rich every time, though extra gold stars are given to people who get excited and do more because they are having fun
* Run/build instructions are seen in a positive light, as it indicates you know how to work in that environment
* We also consider the extensibility of the code produced. Well-factored code should be relatively easily extended. http://en.wikipedia.org/wiki/Rock-paper-scissors-lizard-Spock may be a natural extension
* Submission should be in Java, Python, C#, or any other object-oriented language
* Any indicator of design (DDD or design patterns) would make us smile

## Prerequisites

.NET 8

## Instructions

Run Build

```
dotnet build
```

Run Tests:

To run only the test
```
dotnet test --logger "console;verbosity=detailed"
```
To get a coverage.corbetura.xml, so it can be interpreted by a corbetura tool
```
dotnet test --collect "XPlat Code Coverage"
```

To launch the game
```
cd /src/HOT.Assessment.RockPaperScissor.WebApp
dotnet run
```