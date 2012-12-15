using System.Collections.Generic;
using System.Linq;
using log4net;
using NServiceBus;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;
using Unilib.Queries;
using Unilib.Common.Extensions;

namespace Unilib.ContentServer.Handlers
{
    public class GetClassificationMessageHandler: IMessageHandler<GetClassificationMessage>
    {
        public IRepository<ThemeClassificationEntity> ClasificationRepository { get; set; }
        public ILog Log { get; set; }
        public IBus Bus { get; set; }

        #region IMessageHandler<GetClassificationQuery> Members

        public void Handle(GetClassificationMessage message)
        {
            Log.InfoFormat("GetClassificationQuery handled");
            var resp = new GetClassificationMessageResponse();
            var leafs = ClasificationRepository.GetAllLeafEntities().ToList();
            var notLeafs = ClasificationRepository.GetAllNotLeafEntities().ToList();
            foreach (var l in leafs)
            {
                var parent = notLeafs.FirstOrDefault(e => e.Id == l.Id);
                if(parent!=null)
                {
                    if (!resp.Tree.ContainsKey(parent.Title))
                        resp.Tree.Add(parent.Title, new List<ClasificationNode>());
                    resp.Tree[parent.Title].Add(new ClasificationNode{Id = l.Id, Description = l.Description, Title = l.Title});
                }
            }
            Bus.Reply(resp);
            Log.InfoFormat("GetClassificationQueryResponse replayed");
        }


            #endregion
    }
}
