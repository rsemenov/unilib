using NServiceBus;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;
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