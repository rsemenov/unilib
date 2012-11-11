using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NServiceBus;
using Unilib.Frontend.Models;
using Unilib.Messages;

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

            Bus.Send(command);

            return View();
        }
      
    }
}
