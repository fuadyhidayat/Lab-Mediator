using Mediator.Application.Notifiers;
using Microsoft.AspNetCore.Mvc;

namespace Mediator.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NotifierMediatorController : ControllerBase
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
    }
}