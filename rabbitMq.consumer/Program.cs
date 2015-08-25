using System;
using EasyNetQ;
using rabbitMq.Messages;
using System.Threading.Tasks;
using System.Threading;

namespace rabbitMq.consumer
{
    class Program
    {
        static void Main(string[] args)
        {

            var bus = new MessageBus();

            MessageBus.Bus.Subscribe<CreateIdeaMessage>("1", (message) =>
            {
                Thread.Sleep(1000);
                print(message.IdeaId, ConsoleColor.Red);
            });
            MessageBus.Bus.Subscribe<CreateObjectiveMessage>("1", (message) =>
            {
                Thread.Sleep(2000);
                print(message.ObjectiveId, ConsoleColor.Blue);
            });
            MessageBus.Bus.Subscribe<CreateTaskMessage>("1", (message) =>
            {
                Thread.Sleep(700);
                print(message.TaskId, ConsoleColor.Yellow);
            });
        }

        static void print(int id, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("Got message: {0}", id);
            Console.ResetColor();
        }
        
    }
}
