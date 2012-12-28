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
using Unilib.Common;

namespace Unilib.Frontend.Controllers
{
    public class ContentController : Controller
    {
        //
        // GET: /Content/
        private IBus Bus;
        public ActionResult Upload()
        {
            ContentModel model = new ContentModel
            {
                DataType = new ListViewModel[2],
                SelectedList = new int[0],
            };

            model.DataType[0] = new ListViewModel
            {
                Id = (int) DataTypes.Doc,
                Title = "DOC"
            };

            model.DataType[1] = new ListViewModel
            {
                Id = (int) DataTypes.Pdf,
                Title = "PDF"
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Upload(ContentModel model)
        {
            AddRecordContentCommand command = new AddRecordContentCommand
            {
                //RecordId = (Guid) Session["RecordId"],
                DataType = (DataTypes)model.SelectedList[0],
                DescriptionFile = null,
                //ContentFile = new byte[model.ContentFile.ContentLength]
            };
            model.ContentFile.InputStream.Read(command.ContentFile, 0, model.ContentFile.ContentLength);
            Bus.Send(command);
            return View();
        }

    }
}
