using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace Unilib.Messages
{
    [Serializable]
    public class CreateAuthorCommand:IMessage
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string FirstPart { get; set; }
        public string SufixPart { get; set; }
        public string OtherNames { get; set; }
        public string NameAddition { get; set; }
    }
}
