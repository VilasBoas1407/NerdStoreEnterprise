﻿namespace NSE.Auth.API.Models.Usuario
{
    public class UserLoginResponse
    {
        public string AccessToken { get; set; } 
        public double ExpiresIn { get; set; }
        public UserToken UserToken { get; set; }
    }
}
