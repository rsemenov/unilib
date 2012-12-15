using System;
using NServiceBus;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;
using Unilib.Messages;
using log4net;

namespace Unilib.CommunicationServer.Handlers
{
    public class CreateAuthorCommandHandler : IHandleMessages<CreateAuthorCommand>
    {
        public IRepository<AuthorEntity> AuthorRepository { get; set; }
        public ILog Log { get; set; }
        public IBus Bus {get;set;}

        #region IMessageHandler<CreateAuthorCommand> Members

        public void Handle(CreateAuthorCommand message)
        {
            try
            {
                Log.InfoFormat("CreateAuthorCommand handled with AuthorId={0}", message.AuthorId);
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
                Log.InfoFormat("Author entity with AuthorId={0} saved successfully", message.AuthorId);
                Bus.Return(CommandStatusEnum.Success);
               
            }
            catch (Exception e)
            {
                Bus.Return(CommandStatusEnum.Error);
                throw e;
            }
        }

        #endregion
    }
}