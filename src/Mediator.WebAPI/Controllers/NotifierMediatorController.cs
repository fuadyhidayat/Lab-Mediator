using Mediator.Application.Notifiers;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NotifierMediatorController : ApiController
    {
        private readonly INotifierMediatorService _notifierMediatorService;

        public NotifierMediatorController(INotifierMediatorService notifierMediatorService)
        {
            _notifierMediatorService = notifierMediatorService;
        }

        [HttpGet]
        public ContentResult NotifyAllContentResult()
        {
            _notifierMediatorService.Notify();

            return Content("NotifyAllContentResult");
        }

        [HttpGet]
        public string NotifyAllString()
        {
            _notifierMediatorService.Notify();

            return "NotifyAllString";
        }

        [HttpGet]
        public IActionResult NotifyAllIActionResult()
        {
            _notifierMediatorService.Notify();

            return Ok("NotifyAllIActionResult");
        }

        [HttpGet]
        public IActionResult NotifyAll()
        {
            Mediator.Publish(new NotificationMessage { NotifyText = "This is a test notification" });

            return Ok("NotifyAll");
        }
    }
}