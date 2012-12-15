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
            Session["AuthorId"] = command.AuthorId;
            IAsyncResult res = Bus.Send(command).Register(CreateCommandCallback, this);
            WaitHandle asyncWaitHandle = res.AsyncWaitHandle;
            asyncWaitHandle.WaitOne(50000);
            return View();
        }

        private void CreateCommandCallback(IAsyncResult asyncResult)
        {
            var result = asyncResult.AsyncState as CompletionResult;
            var controller = result.State as AuthorController;
            var status = (CommandStatusEnum)result.ErrorCode;
            CreateCompleted(status);
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
        public void Find(FindAuthorModel model)
        {
            var res = Bus.Send(new CheckAuthorMessage
                         {
                             Name = model.Name,
                             Surname = model.Surname
                         }).Register(FindCallback, this);
            WaitHandle asyncWaitHandle = res.AsyncWaitHandle;
            asyncWaitHandle.WaitOne(50000);
            
        }

        private void FindCallback(IAsyncResult asyncResult)
        {
            var result = asyncResult.AsyncState as CompletionResult;
            var controller = result.State as AuthorController;
            var response = result.Messages[0] as CheckAuthorMessageResponse;
            if (response != null)
            {
                FindCompleted(response.AuthorId);
            }
        }

        public ActionResult FindCompleted(Guid? authorGuid)
        {
            if (!authorGuid.HasValue)
                return View("Create"); //TODO NOT redirecting here!!!!
            else
            {
                //TODO: save guid somewhere
                return RedirectToAction("CreateRecord", "Record");
            }
        }
      
    }
}
