using System;
using log4net;
using NServiceBus;
using Unilib.Common.Interfaces;
using Unilib.Messages;
using Unilib.Common.DataEntities;

namespace Unilib.CommunicationServer.Handlers
{
    public class AddRecordContentCommandHandler : IHandleMessages<AddRecordContentCommand>
    {
        public IRepository<RecordContentEntity> RecordContentRepository { get; set; }
        public ILog Log { get; set; }
        public IBus Bus { get; set; }

        #region IMessageHandler<AddRecordContentCommand> Members

        public void Handle(AddRecordContentCommand message)
        {
            try
            {
                Log.InfoFormat("AddRecordContentCommand handled for RecordId={0}", message.RecordId);
                RecordContentEntity entity = new RecordContentEntity()
                                                 {
                                                     RecordId = message.RecordId,
                                                     DataType = message.DataType,
                                                     FileContent = message.ContentFile,
                                                     DescriptionContent = message.DescriptionFile
                                                 };
                RecordContentRepository.Add(entity);
                Log.InfoFormat("RecordContentEntity added for RecordId={0}", message.RecordId);
                Bus.Return(CommandStatusEnum.Success);
            }catch(Exception e)
            {
                Bus.Return(CommandStatusEnum.Error);
            }
        }

        #endregion
    }
}