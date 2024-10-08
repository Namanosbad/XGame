﻿using XGame.Domain.Arguments.Player;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;
using XGame.Domain.ValueObjects;
using XGame.Domain.Enums;
using XGame.Domain.Interfaces.Arguments;
using prmToolkit.NotificationPattern;
using XGame.Domain.Resources;
using System.ComponentModel.DataAnnotations;
using prmToolkit.NotificationPattern.Extensions;
using System.Net.Http.Headers;

namespace XGame.Domain.Services
{
    public class ServicePlayer : Notifiable, IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;

        public ServicePlayer()
        {

        }
        public ServicePlayer(IRepositoryPlayer repositoryPlayer)
        {
            _repositoryPlayer = repositoryPlayer;
        }

        public AddPlayerResponse AddPlayer(AddPlayerRequest request)
        {
            var Name = new Name(request.FirstName, request.LastName);
            var Email = new Email(request.Email);
            Player player = new Player(Name,Email, request.Password);

            Guid id = _repositoryPlayer.AddPlayer(request);

            return new AddPlayerResponse() { Id = id, Message = "successful" };
        }

        public AuthenticatePlayerResponse AuthenticatePlayer(AuthenticatePlayerResponse request)
        {
            if (request == null)
            {
               AddNotification("AuthenticatePlayerRequest", Message.X0_IS_REQUIRED.ToFormat ("AuthenticatePlayerRequest"));
            }

            var email = new Email(request.Email);
            var player = new Player(email, request.Password);

            AddNotifications(player, email);

            var response = _repositoryPlayer.AuthenticatePlayer(request);
            return response;
        }
    }
}
