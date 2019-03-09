﻿using System.Collections.Generic;
using CSharpWars.DtoModel;
using CSharpWars.Enums;
using CSharpWars.Scripting.Model;
using CSharpWars.ScriptProcessor.Moves;
using FluentAssertions;
using Xunit;

namespace CSharpWars.Tests.Scripting.Moves
{
    public class SelfDestructTests
    {
        [Fact]
        public void Building_A_Move_From_SelfDestruct_Move_Should_Create_An_Instance_Of_SelfDestruct()
        {
            // Arrange
            var bot = new BotDto { };
            var arena = new ArenaDto { Width = 1, Height = 1 };
            var botProperties = BotProperties.Build(bot, arena, new List<BotDto>());
            botProperties.CurrentMove = PossibleMoves.SelfDestruct;

            // Act
            var move = Move.Build(botProperties);

            // Assert
            move.Should().NotBeNull();
            move.Should().BeOfType<SelfDestruct>();
        }
    }
}