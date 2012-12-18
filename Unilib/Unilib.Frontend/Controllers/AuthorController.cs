using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Async;
using NServiceBus;
using Unilib.Frontend.Models;
using Unilib.Messages;
using Unilib.Queries;

namespace Unilib.Frontend.Controllers
{
    public class AuthorController : Controller
    {
        public IBus Bus { get; set; }
        CommandStatusEnum AuthorAdditionSuccess;
        CheckAuthorMessageResponse CheckAuthorresponse;
        //
        // GET: /Author/
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AuthorModel model, string textfield)
        {
            var command = new CreateAuthorCommand
                              {
                                  AuthorId = Guid.NewGuid(),
                                  Name = model.Name,
                                  FullName = model.FullName,
                                  FirstPart = model.FirstPart,
                                  NameAddition = model.NameAddition,
                                  OtherNames = model.OtherNames,
                                  SufixPart = model.SufixPart
                              };
            //AuthorAdditionSuccess = CommandStatusEnum.Error;
            Session["AuthorId"] = command.AuthorId;
            IAsyncResult res = Bus.Send(command).Register(CreateCommandCallback, this);
            WaitHandle asyncWaitHandle = res.AsyncWaitHandle;
            bool timeout = asyncWaitHandle.WaitOne(5000);
            if (AuthorAdditionSuccess == CommandStatusEnum.Success)
            {
                return RedirectToAction("CreateRecord", "Record");
            }
            else
            {

                return View();
            }
        }

        private void CreateCommandCallback(IAsyncResult asyncResult)
        {
            var result = asyncResult.AsyncState as CompletionResult;
            var controller = result.State as AuthorController;
            AuthorAdditionSuccess = (CommandStatusEnum)result.ErrorCode;
        }

        public ActionResult CreateCompleted(CommandStatusEnum createStatus)
        {
            if (createStatus == CommandStatusEnum.Success)
                return RedirectToAction("CreateRecord", "Record");
            else
                return View("Create"); // TODO:: Print error with red symbols in the page!!!
        }

        [HttpGet]
        public ActionResult Find()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Find(FindAuthorModel model)
        {
            var res = Bus.Send(new CheckAuthorMessage
                         {
                             Name = model.Name,
                             Surname = model.Surname
                         }).Register(FindCallback, this);
            WaitHandle asyncWaitHandle = res.AsyncWaitHandle;
            asyncWaitHandle.WaitOne(50000);

            if (CheckAuthorresponse != null)
            {
                return FindCompleted(CheckAuthorresponse.AuthorId);
            }
            return View();

        }

        private void FindCallback(IAsyncResult asyncResult)
        {
            var result = asyncResult.AsyncState as CompletionResult;
            var controller = result.State as AuthorController;
            CheckAuthorresponse = (CheckAuthorMessageResponse) (result.Messages[0]);
        }

        public ActionResult FindCompleted(Guid? authorGuid)
        {
            if (!authorGuid.HasValue)
                return RedirectToAction("Create"); //TODO NOT redirecting here!!!!
            else
            {
                Session["AuthorId"] = authorGuid;
                return RedirectToAction("CreateRecord", "Record");
            }
        }
      
    }
}
