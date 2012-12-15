using System;
using NServiceBus;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;
using Unilib.Messages;
using log4net;

namespace Unilib.CommunicationServer.Handlers
{
    public class AddRecordClassificationCommandHandler : IHandleMessages<AddRecordClassificationCommand>
    {
        public IRepository<ThemeClassificationEntity> ClassificationRepository { get; set; }
        public IRepository<RecordClassificationEntity> RecordsClassificationRepository { get; set; }
        public ILog Log { get; set; }
        public IBus Bus { get; set; }

        public void Handle(AddRecordClassificationCommand message)
        {
            try
            {
                Log.InfoFormat("AddRecordClassificationCommand handled for RecordId={0}", message.RecordId);
                var recordClassificationEntity = new RecordClassificationEntity()
                                                     {
                                                         RecordId = message.RecordId,
                                                         DocumentNumber = message.DocumentNumber,
                                                         ISBN = message.ISBN,
                                                         ISSN = message.ISSN,
                                                         NationalNumber = message.NationalNumber,
                                                         OtherIdentifier = message.OtherIdentifier,
                                                         ThemeClassificationId = message.ThemeClassificationId
                                                     };
                RecordsClassificationRepository.Add(recordClassificationEntity);
                Log.InfoFormat("RecordClassificationEntity for RecordId={0} saved sucessfully", message.RecordId);
                Bus.Return(CommandStatusEnum.Success);
            }
            catch(Exception e)
            {
                Bus.Return(CommandStatusEnum.Error);
                throw e;
            }
        }
    }
}