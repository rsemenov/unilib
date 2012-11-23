using NServiceBus;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;
using Unilib.Messages;

namespace Unilib.CommunicationServer.Handlers
{
    public class CreateAuthorCommandHandler : IHandleMessages<CreateAuthorCommand>
    {
        public IRepository<AuthorEntity> AuthorRepository { get; set; }

        #region IMessageHandler<CreateAuthorCommand> Members

        public void Handle(CreateAuthorCommand message)
        {
            var entity = new AuthorEntity()
            {
                AuthorId = message.AuthorId,
                Name = message.Name,
                FullName = message.FullName,
                FirstPart = message.FirstPart,
                NameAddition = message.NameAddition,
                OtherNames = message.OtherNames,
                SufixPart = message.SufixPart
            };
            AuthorRepository.Add(entity);
        }

        #endregion
    }
}