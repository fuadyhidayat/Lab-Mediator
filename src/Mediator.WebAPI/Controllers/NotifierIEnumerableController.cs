using Mediator.Application.Notifiers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Mediator.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class NotifierIEnumerableController : ControllerBase
    {
        private readonly IEnumerable<INotifier> _notifiers;

        public NotifierIEnumerableController(IEnumerable<INotifier> notifiers)
        {
            _notifiers = notifiers;
        }

        [HttpGet]
        public ContentResult NotifyAllContentResult()
        {
            foreach (INotifier notifier in _notifiers)
            {
                notifier.Notify();
            }

            return Content("NotifyAllContentResult");
        }

        [HttpGet]
        public string NotifyAllString()
        {
            foreach (INotifier notifier in _notifiers)
            {
                notifier.Notify();
            }

            return "NotifyAllString";
        }

        [HttpGet]
        public IActionResult NotifyAllIActionResult()
        {
            foreach (INotifier notifier in _notifiers)
            {
                notifier.Notify();
            }

            return Ok("NotifyAllIActionResult");
        }
    }
}