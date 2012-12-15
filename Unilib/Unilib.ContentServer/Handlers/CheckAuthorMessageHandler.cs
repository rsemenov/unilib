using System.Linq;
using log4net;
using NServiceBus;
using Unilib.Common.DataEntities;
using Unilib.Common.Extensions;
using Unilib.Common.Interfaces;
using Unilib.Queries;
using System.Threading;

namespace Unilib.ContentServer.Handlers
{
    public class CheckAuthorMessageHandler : IMessageHandler<CheckAuthorMessage>
    {
        public IRepository<AuthorEntity> AuthorRepository { get; set; }
        public ILog Log { get; set; }
        public IBus Bus { get; set; }

        public void Handle(CheckAuthorMessage message)
        {
            Log.InfoFormat("CheckAuthorQuery handled, name={0}, surname={1}", message.Name, message.Surname);
            var authors = AuthorRepository.GetAuthorsByName(message.Name, message.Surname).ToList();
            var resp = new CheckAuthorMessageResponse();
            if (authors.Count() == 0)
                Log.InfoFormat("Author with given name not found");
            else
                resp.AuthorId = authors.FirstOrDefault().AuthorId;
            Thread.Sleep(5000);
            Bus.Reply(resp);
            Log.InfoFormat("CheckAuthorQueryResponse replayed");
        }

    }
}