﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using NServiceBus;
using Unilib.Frontend.Models;
using Unilib.Messages;

namespace Unilib.Frontend.Controllers
{
    public class RecordController : Controller
    {
        public IBus Bus { get; set; }

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
            //var command = new CreateRecordCommand
            //            {
            //                Id = Guid.NewGuid()
            //                SortTitle = model.SortTitle,
            //                FullTitle = model.FullTitle,
            //                OtherTitle = model.OtherTitle,
            //                TitleDescription = model.TitleDescription,
            //                Responsibility = model.Responsibility,
            //                ChapterName = model.ChapterName,
            //                Publication = model.Publication,
            //                PublicationInfo = model.PublicationInfo,
            //                PublicationYear = model.PublicationYear
            //            };
            //Bus.Send(command);
            return RedirectToAction("ClassifyRecord");
        }

        public ActionResult ClassifyRecord()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult ClassifyRecord(RecordClassificationModel model)
        {
            //var command = new AddRecordClassificationCommand
            //{
            //    Id = 1,
            //    RecordId = model.RecordId,
            //    ISBN = model.ISBN,
            //    ISSN = model.ISSN,
            //    NationalNumber = model.NationalNumber,
            //    OtherIdentifier = model.OtherIdentifier,
            //    DocumentNumber = model.DocumentNumber,
            //    ThemeClassificationId = model.RecordClassificationId
            //};
            //Bus.Send(command);
            return View();
        }

    }
}
