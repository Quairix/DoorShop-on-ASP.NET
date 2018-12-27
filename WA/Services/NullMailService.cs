using Microsoft.Extensions.Logging;

namespace WA.Services
{
    public class NullMailService : IMailService
    {
        private readonly ILogger<NullMailService> _logger;
        public NullMailService(ILogger<NullMailService> logger)
        {
            _logger = logger;
        }
        public void SendMessage(string to, string body)
        {
            // Log the message
            _logger.LogInformation($"To: {to} Body: {body}");
        }
    }
}
