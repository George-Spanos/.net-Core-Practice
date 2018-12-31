using GayApp.Services;
using GayApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GayApp.Controllers
{
    public class AppController : Controller
    {
        public IMailService MailService { get; }

        public AppController (IMailService mailService)
        {
            MailService = mailService;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            ViewBag.Title = "Contact";
            if (ModelState.IsValid)
            {
                MailService.SendMessage(
                    model.Email,"Test mail",$"From :{model.Name} - {model.Email}, Message : Sample Message");
                ViewBag.UserMessage = "Mail Sent";

                //
            }else
            {

            }
            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }
    }
}
