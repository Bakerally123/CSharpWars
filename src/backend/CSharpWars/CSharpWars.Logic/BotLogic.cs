﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CSharpWars.Common.Extensions;
using CSharpWars.DataAccess.Repositories.Interfaces;
using CSharpWars.DtoModel;
using CSharpWars.Enums;
using CSharpWars.Logic.Interfaces;
using CSharpWars.Mapping.Interfaces;
using CSharpWars.Model;

namespace CSharpWars.Logic
{
    public class BotLogic : IBotLogic
    {
        private readonly Random _randomGenerator = new Random();
        private readonly IRepository<Bot> _botRepository;
        private readonly IMapper<Bot, BotDto> _botMapper;
        private readonly IMapper<Bot, BotToCreateDto> _botToCreateMapper;
        private readonly IArenaLogic _arenaLogic;

        public BotLogic(
            IRepository<Bot> botRepository,
            IMapper<Bot, BotDto> botMapper,
            IMapper<Bot, BotToCreateDto> botToCreateMapper,
            IArenaLogic arenaLogic)
        {
            _botRepository = botRepository;
            _botMapper = botMapper;
            _botToCreateMapper = botToCreateMapper;
            _arenaLogic = arenaLogic;
        }

        public async Task<IEnumerable<BotDto>> GetAllActiveBots()
        {
            var activeBots = await _botRepository.Find(x => x.CurrentHealth > 0);
            return _botMapper.Map(activeBots);
        }

        public async Task<BotDto> CreateBot(BotToCreateDto botToCreate)
        {
            var bot = _botToCreateMapper.Map(botToCreate);
            var arena = await _arenaLogic.GetArena();
            bot.Orientation = (Orientation)_randomGenerator.Next(0, 4);
            bot.LocationX = _randomGenerator.Next(0, arena.Width);
            bot.LocationY = _randomGenerator.Next(0, arena.Height);
            bot.CurrentHealth = bot.MaximumHealth;
            bot.CurrentStamina = bot.MaximumStamina;
            bot.Memory = new Dictionary<String, String>().Serialize();
            bot = await _botRepository.Create(bot);
            var createdBot = _botMapper.Map(bot);
            return createdBot;
        }
    }
}