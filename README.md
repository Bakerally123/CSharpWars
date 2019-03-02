# The Making of CSharpWars

![CSharp Wars Logo](https://www.djohnnie.be/csharpwars/logo.png "CSharp Wars Logo")

| Build | Status |
|-------|--------|
| CI | [![Build Status](https://involvedcloud.visualstudio.com/CSharp-Wars/_apis/build/status/Djohnnie.CSharpWars?branchName=master)](https://involvedcloud.visualstudio.com/CSharp-Wars/_build/latest?definitionId=54&branchName=master) |



## Part 1 - Forming the Idea

### Context

I have been working as a software development consultant and C# and .NET teacher for the past years. Sometimes developers and students can use some extra fun to awaken their creativity and improve their enthousiasm. In order to make students have some fun while learning and make developers creative while being competitive, I wanted to create a game that can be scripted using C#.

### Game?

The easiest idea for a game that can be scripted using .NET and C# is a deathmatch game where players fight a match inside an arena. Each player can script one, or even multiple robots inside the arena. Once a robot has been scripted and deployed into the arena, its future is entirely dependent of the script. It cannot be changed, and it cannot be revoked.

#### Scripting

#### Moves

In order to give the player a variety of options, he can use a number of different moves in his scripts to make his robot walk around the arena and fight other robots. Because a robot is governed by a health and stamina property, his time in the arena is limited and he must use his stamina wisely and take care of his health.

A robot has five options to move around:
| WalkForward | Performing this move makes the robot walk forward in the direction he is currently oriented. This move consumes one stamina point. |
| TurnLeft | Performing this move makes the robot turn anti-clockwise by 90°. This move does not consume stamina because the robot will not move away from it's current location in the arena grid. |
| TurnRight | Performing this move makes the robot turn clockwise by 90°. This move does not consume stamina because the robot will not move away from it's current location in the arena grid. |

### Technology?

Because I am a developer myself and I obviously wanted to have some fun, I took this opportunity to dive into some new technologies. At the core of the game itself, because it should be possible to script robots using C#, I looked at the **Microsoft Compiler Platform (Roslyn)**. As a total newbie I wanted to challenge myself and use the **Unity Game Engine** to create a good looking 3D client application to display the arena with fighting robots. For communication between frontent, middleware and backend I chose to use **ASP.NET Core WebApi** and **Microsoft SQL Server** for storing simple relational data.

## Part 2 - Implementing a simple API

Placeholder

## Part 3 - Implementing a Unity3D Client

Placeholder

## Part 4 - Implementing a Scripting Middleware

Placeholder

## Part 5 - Putting everything together

Placeholder

## Appendix I - Project Structure

Placeholder

## Appendix II - Setup and Run

Placeholder
