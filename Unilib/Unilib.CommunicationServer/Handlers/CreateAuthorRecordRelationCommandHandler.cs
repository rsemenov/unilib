using NServiceBus;
using Unilib.CommunicationServer.Common;
using Unilib.CommunicationServer.DataEntities;
using Unilib.Messages;

namespace Unilib.CommunicationServer.Handlers
{
    public class CreateAuthorRecordRelationCommandHandler : IHandleMessages<CreateAuthorRecordRelationCommand>
    {
        public IRepository<AuthorRecordEntity> RecordsRepository { get; set; }

        public void Handle(CreateAuthorRecordRelationCommand message)
        {
            var entity = new AuthorRecordEntity()
                             {
                                 AuthorId = message.AuthorId,
                                 RecordId = message.RecordId
                             };
            RecordsRepository.Add(entity);
        }
    }
}