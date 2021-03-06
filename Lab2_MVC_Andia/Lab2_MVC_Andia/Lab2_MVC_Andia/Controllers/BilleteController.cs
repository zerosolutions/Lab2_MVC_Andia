﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab2_MVC_Andia.Models;

namespace Lab2_MVC_Andia.Controllers
{
    public class BilleteController : Controller
    {
        // GET: Billete
        public ActionResult Index()
        {
            return View();
        }


        // Visualizar
        public ActionResult Visualizar(Cls_Billete objBillete)
        {

            int cantidad;
            cantidad = objBillete.monto;

            int cant100, cant50, cant20, cant10;
            int res100, res50, res20, res10;

            cant100 = cantidad / 100;
            res100 = cantidad % 100;

            cant50 = res100 / 50;
            res50 = res100 % 50;

            cant20 = res50 / 20;
            res20 = res50 % 20;

            cant10 = res20 / 10;
            res10 = res20 % 10;

            objBillete.b100 = cant100;
            objBillete.b50 = cant50;
            objBillete.b20 = cant20;
            objBillete.b10 = cant10;

            return View(objBillete);

        }
    }
}