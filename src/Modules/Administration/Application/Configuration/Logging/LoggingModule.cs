﻿using Autofac;
using Serilog;

namespace CompanyName.MyMeetings.Modules.Administration.Application.Configuration.Logging
{
    internal class LoggingModule : Autofac.Module
    {
        private readonly ILogger _logger;

        internal LoggingModule(ILogger logger)
        {
            _logger = logger;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(_logger)
                .As<ILogger>()
                .SingleInstance();      
        }
    }
}