using CpiDataClient.Services.Interfaces;

namespace CpiDataClient.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
