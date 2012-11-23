using NServiceBus;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;
using Unilib.Messages;

namespace Unilib.CommunicationServer.Handlers
{
    public class AddRecordClassificationCommandHandler : IHandleMessages<AddRecordClassificationCommand>
    {
        public IRepository<ThemeClassificationEntity> ClassificationRepository { get; set; }
        public IRepository<RecordClassificationEntity> RecordsClassificationRepository { get; set; }

        public void Handle(AddRecordClassificationCommand message)
        {
            throw new System.NotImplementedException();
        }
    }
}