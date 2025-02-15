﻿namespace RuddIO.Server.SDK.Models.DTO
{
    public class TokenPair
    {
        public string AccessToken { get; set; }
        public DateTime? AccessTokenExpiration { get; set; }

        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiration { get; set; }
    }
}
