﻿using System;
using CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration.Processing.InternalCommands;
using CompanyName.MyMeetings.Modules.UserAccess.Domain.UserRegistration;
using Newtonsoft.Json;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Users.CreateUser
{
    internal class CreateUserCommand : InternalCommandBase
    {
        [JsonConstructor]
        internal CreateUserCommand(Guid id, UserRegistrationId userRegistrationId): base(id)
        {
            UserRegistrationId = userRegistrationId;
        }

        public UserRegistrationId UserRegistrationId { get; }
    }
}