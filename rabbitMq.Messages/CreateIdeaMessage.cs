using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rabbitMq.Messages
{
    public class CreateIdeaMessage
    {
        public int CaseId { get; set; }
        public int IdeaId { get; set; }
    }
}
