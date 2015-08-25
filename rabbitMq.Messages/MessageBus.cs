using EasyNetQ;
using System;
using System.Threading.Tasks;

namespace rabbitMq.Messages
{
    public class MessageBus:IDisposable
    {
        public static IBus Bus { get; set; }

        public MessageBus()
        {
            Bus = RabbitHutch.CreateBus("host=localhost");
        }

        public void Dispose()
        {
            Bus.Dispose();
        }

        public void Send<T>(T message) where T : class
        {
            Bus.Send<T>("hubspot", message);
        }
        public void Receive<T>(Action<T> func) where T :class
        {
            Bus.Receive<T>("hubspot", func);
        }
    }
}
