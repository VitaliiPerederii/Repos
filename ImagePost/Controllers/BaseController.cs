﻿using ImagePost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImagePost.Controllers
{
    public class BaseController : Controller
    {
        protected ActionResult PerformAjax(Action<AjaxDTO> func)
        {
            AjaxDTO dto = new AjaxDTO();
            func(dto);
            return Json(dto, JsonRequestBehavior.AllowGet);
        }

    }
}