using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Threading.Tasks;
using BigJigSaw.Models;
using Microsoft.AspNetCore.Authorization;
using System.Net.Mail;
using System.Net;
using BigJigSaw.Services;

namespace BigJigSaw.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMailService _mailService;
        public ContactController(IMailService mailService)
        {
            _mailService = mailService;
        }
        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {                
                _mailService.SendMessage("boruckuba7@gmail.com", model.Subject, $"From:  {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail wyslany...";
                ModelState.Clear();
            }

            return View();
        }        
        
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}