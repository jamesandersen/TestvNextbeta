using Microsoft.AspNet.Mvc;
using System.Collections.Generic;
using System.Linq;
using Jander.HspService.Models;

namespace Jander.HspService.Controllers
{

    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        private readonly IProfileRepository _repository;

        public ProfileController(IProfileRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Profile> GetAll()
        {
            return _repository.AllProfiles;
        }

        [HttpGet("{id:int}", Name = "GetByIdRoute")]
        public IActionResult GetById (string id)
        {
            var item = _repository.GetById(id);
            if (item == null)
            {
                return HttpNotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPost]
        public void CreateProfile([FromBody] Profile profile)
        {
            if (!ModelState.IsValid)
            {
                Context.Response.StatusCode = 400;
            }
            else
            {
                _repository.Add(profile);

                string url = Url.RouteUrl("GetByIdRoute", new { id = profile.Id },
                    Request.Scheme, Request.Host.ToUriComponent());

                Context.Response.StatusCode = 201;
                Context.Response.Headers["Location"] = url;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(string id)
        {
            if (_repository.TryDelete(id))
            {
                return new HttpStatusCodeResult(204); // 201 No Content

            }

            return HttpNotFound();
        }
    }
}
