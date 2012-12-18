using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using NServiceBus;
using Unilib.Frontend.Models;
using Unilib.Messages;
using log4net;
using Unilib.Queries;

namespace Unilib.Frontend.Controllers
{
    public class RecordController : Controller
    {
        public IBus Bus { get; set; }
        public ILog Log { get; set; }

        //
        // GET: /RecordModel/

        public ActionResult CreateRecord()
        {
            /* for query
            var res = Bus.Send().Register(SimpleCo
             * mmandCallback, this);
            WaitHandle asyncWaitHandle = res.AsyncWaitHandle;
            asyncWaitHandle.WaitOne(50000);
             */
            return View();
        }

        private void SimpleCommandCallback(IAsyncResult asyncResult)
        {
            var response = asyncResult.AsyncState;

        }

        [HttpPost]
        public ActionResult CreateRecord(RecordModel model)
        {
            var command = new CreateRecordCommand
                        {
                            Id = Guid.NewGuid(),
                            SortTitle = model.SortTitle,
                            FullTitle = model.FullTitle,
                            OtherTitle = model.OtherTitle,
                            TitleDescription = model.TitleDescription,
                            Responsibility = model.Responsibility,
                            ChapterName = model.ChapterName,
                            Publication = model.Publication,
                            PublicationInfo = model.PublicationInfo,
                            PublicationYear = model.PublicationYear
                        };
            Bus.Send(command);
            var relationcommand = new CreateAuthorRecordRelationCommand
                        {
                            AuthorId = (Guid)Session["AuthorId"],
                            RecordId = command.Id
                        };
            Bus.Send(relationcommand);
            //Log.InfoFormat("CreateRecordCommand send. Id={0}", command.Id);
            return RedirectToAction("ClassifyRecord");
        }

        private GetClassificationMessageResponse classificationResponse;

        public ActionResult ClassifyRecord()
        {
            var res = Bus.Send(new GetClassificationMessage()).Register(ClassificationCallback, this);
            WaitHandle asyncWaitHandle = res.AsyncWaitHandle;
            asyncWaitHandle.WaitOne(50000);
            RecordClassificationModel model = new RecordClassificationModel();
            if (classificationResponse != null)
            {
                model = new RecordClassificationModel()
                                {
                                    Theme = classificationResponse.Tree.First().Value.Select(node =>
                                                                                             node.Title).ToArray()
                                };
                return View(model);
            }
            model.Theme = new string[0];
            return View();
            
        }

        private void ClassificationCallback(IAsyncResult asyncResult)
        {
            var result = asyncResult.AsyncState as CompletionResult;
            var controller = result.State as AuthorController;
            classificationResponse = (GetClassificationMessageResponse)(result.Messages[0]);
        }


        [HttpPost]
        public ActionResult ClassifyRecord(RecordClassificationModel model)
        {
            var command = new AddRecordClassificationCommand
            {
                //RecordId = model.RecordId,
                ISBN = model.ISBN,
                ISSN = model.ISSN,
                NationalNumber = model.NationalNumber,
                OtherIdentifier = model.OtherIdentifier,
                DocumentNumber = model.DocumentNumber,
                //ThemeClassificationId = model.RecordClassificationId
            };
            Bus.Send(command);
            return View();
        }

    }
}
