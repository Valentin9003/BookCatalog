namespace BookBlog.Common.Services
{
    public class CurrentTokenService
    {
        private string currentToken;

        public string Get() => this.currentToken;

        public void Set(string token) => this.currentToken = token;
    }
}
