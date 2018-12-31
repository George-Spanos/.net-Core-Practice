namespace GayApp.Services
{
    public interface IMailService
    {
        //void sendRejectMessage(string to, string subject, string body);
        void SendMessage(string to, string subject, string body);
    }

}