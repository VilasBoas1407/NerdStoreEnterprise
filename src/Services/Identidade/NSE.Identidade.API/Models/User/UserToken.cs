namespace NSE.Auth.API.Models.Usuario
{
    public class UserToken
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public IEnumerable<UserClaims> Claims { get; set; }   
    }
}