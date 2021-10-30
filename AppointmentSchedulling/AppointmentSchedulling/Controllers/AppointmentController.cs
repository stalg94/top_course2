using AppointmentSchedulling.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentSchedulling.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentservice;

        public AppointmentController(IAppointmentService appointmentservice)
        {
            _appointmentservice = appointmentservice;
        }

        public IActionResult Index()
        {
            _appointmentservice.GetDoctorList();
            return View();
        }
    }
}
