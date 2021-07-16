﻿using System.Collections.Generic;
using CryptoApp.Domain.Commands.Implementation;
using CryptoApp.Domain.Commands.Interface;
using CryptoApp.Domain.Services.Interface;

namespace CryptoApp.Domain.Services.Implementation
{
    public class CommandService : ICommandService
    {
        private readonly List<ITelegramCommand> _commands;

        public CommandService()
        {
            _commands = new List<ITelegramCommand>
            {
                new HelpCommand()
            };
        }

        public List<ITelegramCommand> Get() => _commands;
    }
}