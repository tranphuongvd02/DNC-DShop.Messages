namespace DShop.Messages.Commands.Identity
{
    public class SignUp
    {
        public Request Request { get; set; }
        public string Email { get; }
        public string Password { get; }

        protected SignUp()
        {
        }

        public SignUp(string email, string password)
        {
        }
    }
}