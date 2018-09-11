namespace WA.Services
{
    public interface IMailService
    {
        void SendMessage(string to, string body);
    }
}