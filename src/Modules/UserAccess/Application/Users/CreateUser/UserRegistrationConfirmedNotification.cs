﻿using CompanyName.MyMeetings.BuildingBlocks.Infrastructure.SeedWork;
using CompanyName.MyMeetings.Modules.UserAccess.Domain.UserRegistration;
using CompanyName.MyMeetings.Modules.UserAccess.Domain.UserRegistration.Events;
using CompanyName.MyMeetings.Modules.UserAccess.Domain.Users;
using Newtonsoft.Json;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Users.CreateUser
{
    public class UserRegistrationConfirmedNotification : DomainNotificationBase<UserRegistrationConfirmedDomainEvent>
    {
        [JsonConstructor]
        public UserRegistrationConfirmedNotification(UserRegistrationConfirmedDomainEvent domainEvent) : base(domainEvent)
        {
        }
    }
}