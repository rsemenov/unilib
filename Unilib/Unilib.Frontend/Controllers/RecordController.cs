using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using NServiceBus;
using Unilib.Frontend.Models;

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
            var res = Bus.Send().Register(SimpleCommandCallback, this);
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
            return View();
        }

    }
}
