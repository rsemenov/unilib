using NServiceBus;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;
using Unilib.Messages;

namespace Unilib.CommunicationServer.Handlers
{
    public class CreateRecordCommandHandler : IHandleMessages<CreateRecordCommand>
    {
        public IRepository<RecordEntity> RecordsRepository { get; set; }

        #region IMessageHandler<CreateRecordCommand> Members

        public void Handle(CreateRecordCommand message)
        {
            var entity = new RecordEntity()
                             {
                                 Id = message.Id,
                                 ChapterName = message.ChapterName,
                                 FullTitle = message.FullTitle,
                                 OtherTitle = message.OtherTitle,
                                 Publication = message.Publication,
                                 PublicationInfo = message.PublicationInfo,
                                 PublicationYear = message.PublicationYear,
                                 Responsibility = message.Responsibility,
                                 SortTitle = message.SortTitle,
                                 TitleDescription = message.TitleDescription
                             };
            RecordsRepository.Add(entity);
        }

        #endregion
    }
}