using EmployeeQuiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EmployeeQuiz.Controllers
{
    public class HomeController : Controller
    {
     
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employe emp)
        {
            //creo el objeto del modelo de datos
            PayrollDm nomina = new PayrollDm(@"C:\Users\YOSS LIN\Documents\Visual Studio 2012\Projects\Recover\EmployeeQuiz\Models\empleados.csv");
            // Busco empleado dado su id
            var empleado = nomina.GetEmployeById(emp.Id);
            
            double validacion = double.Parse(emp.Id);
            

            if (validacion == 0 || validacion >=6)
            {
                return View("Error");             }
             
            else{
                return View("WorkerView", empleado);

                 }


        }


    }
}
