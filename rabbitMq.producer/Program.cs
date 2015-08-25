using System;
using EasyNetQ;
using rabbitMq.Messages;

namespace rabbitMq.producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bus = new MessageBus();
            var input = "";
            while ((input = Console.ReadLine()) != "Quit")
            {
                if (input == "1")
                    MessageBus.Bus.Publish(new CreateIdeaMessage
                    {
                        IdeaId = 1,
                        CaseId = 100
                    });
                else if(input=="2")
                    MessageBus.Bus.Publish(new CreateObjectiveMessage
                    {
                        ObjectiveId = 12,
                        CaseId = 100
                    });
                else
                    MessageBus.Bus.Publish(new CreateTaskMessage
                    {
                        TaskId = 12,
                        CaseId = 100
                    });
            }
        }
    }
}
