using System;
using System.Collections.Generic;
using NServiceBus;

namespace Unilib.Queries
{
    [Serializable]
    public class GetClassificationMessageResponse : IMessage
    {
        public Dictionary<string, List<ClasificationNode>> Tree { get; set; }

        public GetClassificationMessageResponse()
        {
            Tree = new Dictionary<string, List<ClasificationNode>>();
        }
    }
}