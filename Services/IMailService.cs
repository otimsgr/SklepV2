namespace BigJigSaw.Services
{
    public interface IMailService
    {
        void SendMessage(string from, string subject, string body);
    }
}