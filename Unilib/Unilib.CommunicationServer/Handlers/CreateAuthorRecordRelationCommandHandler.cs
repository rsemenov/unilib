using System;
using NServiceBus;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;
using Unilib.Messages;
using log4net;

namespace Unilib.CommunicationServer.Handlers
{
  
    public class CreateAuthorRecordRelationCommandHandler : IHandleMessages<CreateAuthorRecordRelationCommand>
    {
        public IRepository<AuthorRecordEntity> RecordsRepository { get; set; }
        public ILog Log { get; set; }
        public IBus Bus { get; set; }

        public void Handle(CreateAuthorRecordRelationCommand message)
        {
            try
            {
                Log.InfoFormat("CreateAuthorRecordRelationCommand handled with AuthorId={0}, RecordId={1}",
                               message.AuthorId, message.RecordId);
                var entity = new AuthorRecordEntity()
                                 {
                                     AuthorId = message.AuthorId,
                                     RecordId = message.RecordId
                                 };
                RecordsRepository.Add(entity);
                Log.InfoFormat("AuthorRecordEntity with AuthorId={0}, RecordId={1} saved sucessfully.", message.AuthorId,
                               message.RecordId);
                Bus.Return(CommandStatusEnum.Success);
            }
            catch (Exception e)
            {
                Bus.Return(CommandStatusEnum.Error);
                throw e;
            }
        }
    }
}